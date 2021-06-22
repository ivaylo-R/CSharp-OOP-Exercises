using LoggerProblem.Contracts;
using System;
using System.Reflection;

namespace LoggerProblem.Core
{
    public class Engine
    {
        public void Run()
        {
            ReadInput();
        }

        private void ReadInput()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string typeOfAppender = inputArgs[0];
                var type = Assembly.GetCallingAssembly().GetFile(typeOfAppender);
            }
        }
    }
}
