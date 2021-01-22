using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BlazorApp.GroupByMany
{
    public static class GroupingFns
    {
        public static IGroupByManyResult<T> GroupByMany<T>(this IEnumerable<T> source, params Expression<Func<T, object>>[] keySelectors)
        {
            return source.GroupByMany(EqualityComparer<object>.Default, keySelectors);
        }

        public static IGroupByManyResult<T> GroupByMany<T>(this IEnumerable<T> source, IEqualityComparer<object> equalityComparer, params Expression<Func<T, object>>[] keySelectors)
        {
            var groups = GroupByMany(string.Empty, source, equalityComparer, keySelectors).ToList();
            var group = new GroupByManyResult<T>(groups)
            {
                Key = string.Empty,
                Count = groups.Count,
                Details = groups.SelectMany(g => g.Details)
            };
            foreach (var subGroup in groups)
                subGroup.Parent = group;
            return group;
        }

        private static List<GroupByManyResult<T>> GroupByMany<T>(string parentKey, IEnumerable<T> source, 
            IEqualityComparer<object> equalityComparer, params Expression<Func<T, object>>[] keySelectors)
        {
            if (!keySelectors.Any())
                return new List<GroupByManyResult<T>>();

            var curSelector = keySelectors.First();
            var nextSelectors = keySelectors.Skip(1).ToArray();
            var index = 0;
            var results = new List<GroupByManyResult<T>>();
            var groupName = GetName(curSelector);

            var compiled = curSelector.Compile();
            foreach (var group in source
                .GroupBy(compiled, equalityComparer)
                .Where(g => g.Key != null))
            {
                var key = string.IsNullOrEmpty(parentKey) ? index++.ToString() : $"{parentKey}-{index++}";
                var subGroups = GroupByMany(key, group, equalityComparer, nextSelectors);
                var result = new GroupByManyResult<T>(subGroups)
                {
                    Key = key,
                    GroupName = groupName,
                    Item = group.Key,
                    Count = group.Count(),
                    Details = group,
                    FirstDetail = group.FirstOrDefault(),
                };
                foreach (var subGroup in subGroups)
                    subGroup.Parent = result;
                results.Add(result);
            }

            return results;
        }

        public static IEnumerable<IGroupByManyResult<T>> AllGroups<T>(this IGroupByManyResult<T> grouping)
        {
            var subGroups = new List<IGroupByManyResult<T>>(new[] { grouping });
            subGroups.AddRange(grouping.SubGroups.SelectMany(g => g.AllGroups()));
            return subGroups;
        }

        private static string GetName<TSource>(Expression<Func<TSource, object>> field)
        {
            if (Equals(field, null))
            {
                throw new NullReferenceException("Field is required");
            }

            MemberExpression expr;

            switch (field.Body)
            {
                case MemberExpression body:
                    expr = body;
                    break;
                case UnaryExpression expression:
                    expr = (MemberExpression)expression.Operand;
                    break;
                default:
                {
                    const string Format = "Expression '{0}' not supported.";
                    var message = string.Format(Format, field);
                    throw new ArgumentException(message, nameof(field));
                }
            }

            return expr.Member.Name;
        }
    }
}

