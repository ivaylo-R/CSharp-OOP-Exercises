using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Stack<string> stack1 = new Stack<string> ();
            stack.Push("a");
            stack.Push("c");
            stack1.Push("y");
            stack1.Push("z");
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(stack1);
        }
    }
}
