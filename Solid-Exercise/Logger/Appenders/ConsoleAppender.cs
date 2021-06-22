
using LoggerProblem.Appenders;
using LoggerProblem.Contracts;
using LoggerProblem.Enums;
using LoggerProblem.IO.Contracts;
using LoggerProblem.IO.Models;
using System;

namespace LoggerProblem.Models
{
    public class ConsoleAppender : Appender
    {

        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
            
        }

        public override void Append(string dateTime, ReportLevel logLevel, string message)
        {
            if (this.ReportLevel <= logLevel)
            {
                this.writer.WriteLine(string.Format(this.Layout.Format, dateTime, logLevel, message));

            }
        }
    }
}
