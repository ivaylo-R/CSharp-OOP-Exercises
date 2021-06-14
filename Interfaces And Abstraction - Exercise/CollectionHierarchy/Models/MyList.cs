using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class MyList :List<string>, IAdd, IRemove, IUsed
    {
        public List<int> resultOfAddOpp = new List<int>();
        public List<string> resultOfRemoveOpp = new List<string>();
        public int Used => this.Count;

        public new void Add(string item)
        {
            this.Insert(0, item);
            resultOfAddOpp.Add(this.IndexOf(item));
        }

        public void Remove()
        {
            string removed = string.Empty;
            if (Used>0)
            {
                removed = this[0];
                this.Remove(removed);
            }
            resultOfRemoveOpp.Add(removed);
        }
    }
}
