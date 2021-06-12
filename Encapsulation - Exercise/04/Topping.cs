using System;
using System.Collections.Generic;
using System.Text;

namespace _04
{
    public class Topping
    {
        private const int caloriesPerGram = 2;
        private string type;
        private double weight;

        public Topping()
        {

        }

        public Topping(string type, double weight)
            :this()
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (!CheckToppingType(value))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value > 50 || value < 0)
                {
                    throw new Exception($"{this.Type} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        private double ToppingModifier()
        {
            double modifier = 0;
            switch (this.Type)
            {
                case "meat": modifier = 1.2; break;
                case "veggies": modifier = 0.8; break;
                case "cheese": modifier = 1.1; break;
                case "sauce": modifier = 0.9; break;
            }
            return modifier;
        }

        public double Calories() => this.Weight * caloriesPerGram * ToppingModifier();

        private bool CheckToppingType(string value)
        {
            switch (value.ToLower())
            {
                case "meat": return true;
                case "veggies": return true;
                case "cheese": return true;
                case "sauce": return true;
            }
            return false;
        }
    }
}
