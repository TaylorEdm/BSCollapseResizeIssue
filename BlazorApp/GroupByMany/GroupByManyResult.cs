using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.GroupByMany
{
    public class GroupByManyResult<T> : IGroupByManyResult<T>
    {
        private readonly List<T> _selectedDetails;
        private readonly IEnumerable<GroupByManyResult<T>> _subGroups;

        private bool _selected;

        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                OnSelectedChanged();
            }
        }

        public string Key { get; set; }
        public string GroupName { get; set; }
        public object Item { get; set; }
        public int Count { get; set; }
        public T FirstDetail { get; set; }
        public IEnumerable<T> Details { get; set; }
        public IEnumerable<T> SelectedDetails => _selectedDetails;
        public IEnumerable<IGroupByManyResult<T>> SubGroups => _subGroups;
        public GroupByManyResult<T> Parent { get; set; }

        public event EventHandler SelectionChanged;

        public GroupByManyResult(IEnumerable<GroupByManyResult<T>> subGroups)
        {
            _selectedDetails = new List<T>();
            _subGroups = subGroups;
        }

        public override string ToString()
        {
            return Item.ToString();
        }

        private void OnSelectedChanged()
        {
            UpdateSelection();
            SelectionChanged?.Invoke(this, new EventArgs());
            Parent?.ChildSelectionChanged();
        }

        protected void ChildSelectionChanged()
        {
            _selected = _subGroups.All(g => g.Selected);
            _selectedDetails.Clear();
            _selectedDetails.AddRange(_subGroups.SelectMany(g => g.SelectedDetails));

            SelectionChanged?.Invoke(this, new EventArgs());
            Parent?.ChildSelectionChanged();
        }

        public void SetSelected(bool value)
        {
            _selected = value;
            UpdateSelection();
        }

        private void UpdateSelection()
        {
            _selectedDetails.Clear();

            if (Selected)
                _selectedDetails.AddRange(Details);
            

            if (SubGroups == null)
                return;

            foreach (var subGroup in _subGroups)
                subGroup.SetSelected(Selected);
        }
    }
}
