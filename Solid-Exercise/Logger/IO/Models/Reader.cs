using LoggerProblem.IO.Contracts;
using System;
namespace LoggerProblem.IO.Models
{
    public class Reader : IReadable
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
