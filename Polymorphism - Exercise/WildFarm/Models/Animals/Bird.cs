﻿

namespace WildFarm.Models.Animals
{
    public abstract class Bird:Animal
    {
        protected Bird(string name, double weight,double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        double WingSize { get; }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
