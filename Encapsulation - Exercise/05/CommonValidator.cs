using System;
using System.Collections.Generic;
using System.Text;

namespace _05
{
    public class CommonValidator
    {
        private const int Min_Stat_Points = 0;
        private const int Max_Stat_Points = 100;
        public static void ValidateName(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

        }

        public static void ValidateStatsPoints(int value, string stat)
        {
            if (value < Min_Stat_Points || value > Max_Stat_Points)
            {
                throw new ArgumentException($"{stat} should be between 0 and 100.");
            }
        }
    }
}
