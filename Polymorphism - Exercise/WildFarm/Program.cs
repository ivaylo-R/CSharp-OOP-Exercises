using Raiding.IO.Interfaces;
using Raiding.IO.Models;
using System;
using WildFarm.Core;

namespace WildFarm
{
    class Program
    {
        static void Main()
        {
            IReadable reader = new Reader();
            IWritable writer = new Writer();
            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
