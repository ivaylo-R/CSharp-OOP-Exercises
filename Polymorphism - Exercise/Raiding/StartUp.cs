using Raiding.Core;
using Raiding.IO.Interfaces;
using Raiding.IO.Models;
using System;

namespace Raiding
{
    class StartUp
    {
        static void Main()
        {
            IReadable reader = new Reader();
            IWritable writer = new Writer();
            Engine engine = new Engine(reader,writer);
            engine.Run();
        }
    }
}
