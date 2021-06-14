using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public class AddCollection : List<string>,IAdd
    {
        private List<string> list = new List<string>();
        public List<int> result = new List<int>();
        public new void Add(string item)
        {
            list.Add(item);
            result.Add(list.IndexOf(item));
        }

        
        
    }
}
