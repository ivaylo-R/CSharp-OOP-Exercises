using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.IO.Interfaces
{
    public interface IWritable
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
