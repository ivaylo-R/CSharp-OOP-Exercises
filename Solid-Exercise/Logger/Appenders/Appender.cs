using LoggerProblem.Contracts;
using LoggerProblem.Enums;
using LoggerProblem.IO.Contracts;

namespace LoggerProblem.Appenders
{
    public abstract class Appender : IAppender
    {
        protected readonly IWritable writer;
        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string dateTime, ReportLevel logLevel, string message);
        
    }
}
