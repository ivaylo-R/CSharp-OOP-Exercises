using System;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator 
    {
        public static bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute[] attributes =
                    property.GetCustomAttributes()
                    .Where(ca => ca is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
