using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age,string id,string birthd)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthd;
        }

        public string Name { get; }

        public int Age { get; }

        public string Birthdate { get; }

        public string Id { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine($"{this.Age}");
            return sb.ToString();
        }
    }
}
