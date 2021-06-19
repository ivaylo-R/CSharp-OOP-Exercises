using System;
using System.Collections.Generic;
using WildFarm.Interfaces;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => 0.30;

        public override ICollection<Type> PreferredFood => new List<Type>() { typeof(Vegetable)
            ,typeof(Meat)};

        public override string ProduceSound() => "Meow";
        
            
    }
}
