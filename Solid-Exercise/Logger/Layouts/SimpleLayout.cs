using LoggerProblem.Contracts;

namespace LoggerProblem.Models
{
    public class SimpleLayout : ILayout
    {
        public string Format 
            => "{0} - {1} - {2}";
    }
}
