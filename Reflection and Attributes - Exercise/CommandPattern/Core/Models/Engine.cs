using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Core.Models
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter interpreter)
        {
            this.commandInterpreter = interpreter;
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    string result=this.commandInterpreter.Read(input);
                    Console.WriteLine(result);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                

            }
        }
    }
}
