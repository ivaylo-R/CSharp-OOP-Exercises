using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList random = new RandomList();
            random.Add("gosho");
            random.Add("gosho2");
            random.Add("gosho3");
            random.Add("gosho5");
            random.Add("gosho7");
            Console.WriteLine(random.RandomString());
        }
    }
}
