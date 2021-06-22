using LoggerProblem.Enums;

namespace LoggerProblem.Contracts
{
    public interface IAppender
    {

        void Append(string dateTime, ReportLevel logLevel, string message);
        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }
    }
}
