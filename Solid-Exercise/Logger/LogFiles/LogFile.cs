using LoggerProblem.Contracts;

using System.IO;
using System.Linq;
using System.Text;

namespace LoggerProblem.Models
{
    public class LogFile : ILogFile
    {
        private const string FilePath = "../../../log.txt";
        
        public long Size => File.ReadAllText(FilePath).Where(char.IsLetter).Sum(x=>x);

        public object Enviroment { get; private set; }

        public void Write(string message) => File.AppendAllText(FilePath,message);
    }
}
