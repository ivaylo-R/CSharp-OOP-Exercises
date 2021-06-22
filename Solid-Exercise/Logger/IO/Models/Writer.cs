using LoggerProblem.IO.Contracts;

namespace LoggerProblem.IO.Models
{
    public class Writer : IWritable
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
