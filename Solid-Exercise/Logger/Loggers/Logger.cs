using LoggerProblem.Contracts;
using LoggerProblem.Enums;

namespace LoggerProblem.Models
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appender)
        {
            this.Appenders = appender;
        }

        public IAppender[] Appenders { get; }

        public void AppendAppenders(ReportLevel reportLevel, string dateTime, string message)
        {
            foreach (var appender in this.Appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void Error(string dateTime, string message)
        => AppendAppenders(ReportLevel.Error, dateTime, message);

        public void Info(string dateTime, string message)
        => AppendAppenders(ReportLevel.Info, dateTime, message);

        public void Fatal(string dateTime, string message)
        => AppendAppenders(ReportLevel.Fatal, dateTime, message);

        public void Critical(string dateTime, string message)
        => AppendAppenders(ReportLevel.Critical, dateTime, message);

        public void Warning(string dateTime, string message)
        => AppendAppenders(ReportLevel.Warning, dateTime, message);

    }
}
