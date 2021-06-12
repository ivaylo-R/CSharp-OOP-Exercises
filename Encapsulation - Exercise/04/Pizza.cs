using System;
using System.Collections.Generic;
using System.Text;

namespace _04
{
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length > 15 && value.Length < 1)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            set => this.dough = value;
        }

        public double TotalCalories()
        {
            double result = Dough.FindDoughCalories();
            foreach (var topping in toppings)
            {
                result += topping.Calories();
            }

            return result;
        }
        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories():F2} Calories.";
        }

    }
}
