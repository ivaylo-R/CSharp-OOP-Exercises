using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : List<string>, IRemove, IAdd
    {
        public List<int> resultOfAddOpp = new List<int>();
        public List<string> resultOfRemoveOpp = new List<string>();
        public new void Add(string item)
        {
            this.Insert(0, item);
            resultOfAddOpp.Add(this.IndexOf(item));
        }

        public void Remove()
        {
            string removed = string.Empty;
            if (this.Any())
            {
                removed = this[this.Count - 1];
                this.Remove(removed);
            }
            resultOfRemoveOpp.Add(removed);
        }
    }
}
