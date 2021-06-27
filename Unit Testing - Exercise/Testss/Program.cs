using System;
using System.Reflection;
using ExtendedDatabase15;
namespace Testss
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ï");
            Person person2 = new Person(1, "V");

            ExtendedDatabase data = new ExtendedDatabase(person1);
            ConstructorInfo[] constructors = data.GetType().GetConstructors();
            ParameterInfo[] parameters = constructors[0].GetParameters();
            var parameter = parameters[0].ParameterType.Name;

            Console.WriteLine(parameter);

        }

    }
}
