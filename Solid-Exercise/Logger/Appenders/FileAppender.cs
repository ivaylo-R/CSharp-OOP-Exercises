using LoggerProblem.Appenders;
using LoggerProblem.Contracts;
using LoggerProblem.Enums;

namespace LoggerProblem.Models
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.File = logFile;
        }

        protected ILogFile File { get; }

        public override void Append(string dateTime, ReportLevel logLevel, string message)
        {
            if (this.ReportLevel <= logLevel)
            {
                this.writer.WriteLine(string.Format(this.Layout.Format, dateTime, logLevel, message));

            }
        }
    }
}
