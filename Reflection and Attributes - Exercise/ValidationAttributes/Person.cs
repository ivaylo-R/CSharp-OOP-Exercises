using System;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullname, int age)
        {
            this.FullName = fullname;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get; private set; }


        [MyRange(12, 90)]
        public int Age { get; private set; }

    }
}