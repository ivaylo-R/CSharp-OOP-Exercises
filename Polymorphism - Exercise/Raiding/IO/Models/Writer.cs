using Raiding.IO.Interfaces;
using System;

namespace Raiding.IO.Models
{
    public class Writer : IWritable
    {
        public void Write(string text) => Console.Write(text);


        public void WriteLine(string text) => Console.WriteLine(text);
        
    }
}
