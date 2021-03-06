using System;
using System.Collections.Generic;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals.Contracts
{
    public interface IFeedable
    {
        void Feed(IFood food);

        int FoodEaten { get; }

        double WeightMultiplier { get; }

        ICollection<Type> PreferredFood { get; }
    }
}
