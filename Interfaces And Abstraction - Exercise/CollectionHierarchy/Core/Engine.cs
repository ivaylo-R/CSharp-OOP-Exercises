using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine
    {
        public void Run()
        {
            var addCollection = new AddCollection();
            var addRemoveColl = new AddRemoveCollection();
            var myList = new MyList();
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            AddItems(addCollection, addRemoveColl, myList, input);
            RemoveItems(addRemoveColl, myList, n);
            PrintOutput(addCollection, addRemoveColl, myList);
        }

        private void PrintOutput(AddCollection addCollection, AddRemoveCollection addRemoveColl, MyList myList)
        {
            Console.WriteLine(string.Join(" ", addCollection.result));
            Console.WriteLine(string.Join(" ", addRemoveColl.resultOfAddOpp));
            Console.WriteLine(string.Join(" ", myList.resultOfAddOpp));
            Console.WriteLine(string.Join(" ", addRemoveColl.resultOfRemoveOpp));
            Console.WriteLine(string.Join(" ", myList.resultOfRemoveOpp));
        }

        private void RemoveItems(AddRemoveCollection addRemoveColl, MyList myList, int n)
        {
            for (int i = 0; i < n; i++)
            {
                addRemoveColl.Remove();
                myList.Remove();
            }
        }

        private void AddItems(AddCollection addCollection, AddRemoveCollection addRemoveColl, MyList myList, string[] input)
        {
            foreach (var item in input)
            {
                addCollection.Add(item);
                addRemoveColl.Add(item);
                myList.Add(item);
            }
        }
    }
}
