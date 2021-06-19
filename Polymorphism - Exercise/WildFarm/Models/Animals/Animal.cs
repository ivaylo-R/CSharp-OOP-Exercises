using System;
using System.Collections.Generic;
using WildFarm.Interfaces;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal, IFeedable, ISoundProducable
    {
        private const string INV_FOOD_TYPE = "{0} does not eat {1}!";
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }
        public  double Weight { get; private set; }
        public  int FoodEaten 
        { 
            get; 
            set; 
        }

        public  abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PreferredFood { get; }

        public void Feed(IFood food)
        {
            if (!this.PreferredFood.Contains(food.GetType()))
            {
                throw new InvalidOperationException(string.Format(INV_FOOD_TYPE,this.GetType().Name,food.GetType().Name));
            }

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }

        public abstract string ProduceSound();
        
    }
}
