using Raiding.IO.Interfaces;
using System;

namespace Raiding.IO.Models
{
    public class Reader : IReadable
    {
        public string ReadLine() => Console.ReadLine();
    }
}
