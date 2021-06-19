using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFood => new List<Type>() { typeof(Meat),typeof(Seeds)
        ,typeof(Vegetable),typeof(Fruit)};

        public override string ProduceSound() => "Cluck";


    }
}
