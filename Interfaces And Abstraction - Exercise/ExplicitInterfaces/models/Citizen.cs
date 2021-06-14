using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces.models
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            Age = age;
            Name = name;
            Country = country;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public string Country { get; private set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
