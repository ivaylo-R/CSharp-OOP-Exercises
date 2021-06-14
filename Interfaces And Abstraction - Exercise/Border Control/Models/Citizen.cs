using System;

namespace BorderControl
{
    public class Citizen : ICheckable,IBirthdaytable,IBuyer
    {
        public const int START_FOOD_VALUE = 0;
        public Citizen(string name, int age, string id,DateTime birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthDate;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public DateTime Birthdate { get; }

        public int Food { get; set; } = START_FOOD_VALUE;

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
