using System;
using System.Collections.Generic;

namespace BlazorApp.GroupByMany
{
    public interface IGroupByManyResult<T>
    {
        bool Selected { get; set; }
        string Key { get; }
        string GroupName { get; }
        object Item { get; }
        int Count { get; }
        T FirstDetail { get; }
        IEnumerable<T> Details { get; }
        IEnumerable<T> SelectedDetails { get; }
        IEnumerable<IGroupByManyResult<T>> SubGroups { get; }

        event EventHandler SelectionChanged;
    }
}
