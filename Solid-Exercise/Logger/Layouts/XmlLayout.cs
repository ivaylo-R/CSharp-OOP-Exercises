using LoggerProblem.Contracts;
using LoggerProblem.Enums;
using System;
using System.Text;

namespace LoggerProblem.Layouts
{
    public class XmlLayout : ILayout
    {

        public string Format => XmlFormat();

        private string XmlFormat()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine(" <date>{0}</date>");
            sb.AppendLine(" <level>{1}</level>");
            sb.AppendLine(" <message>{2}</message>");
            sb.AppendLine("</log>");
            return sb.ToString();
        }

    }
}
