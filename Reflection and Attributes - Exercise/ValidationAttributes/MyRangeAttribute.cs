using System;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (obj is Int32)
            {
                int value = (int)obj;

                if (value < minValue || value > maxValue)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
