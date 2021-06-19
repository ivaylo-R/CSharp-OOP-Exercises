using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Common;
using WildFarm.Models;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food CreateFood(string [] foodArgs)
        {
            var type = foodArgs[0];
            var quantity = int.Parse(foodArgs[1]);
            Food food = null;
            switch (type)
            {
                case "Fruit":
                    food = new Fruit(quantity);
                    break;
                case "Vegetable":
                    food = new Vegetable(quantity);
                    break;
                case "Meat":
                    food = new Meat(quantity);
                    break;
                case "Seeds":
                    food = new Seeds(quantity);
                    break;
            }
            if (food==null)
            {
                throw new ArgumentException(ExceptionMessages.INVALID_FOOD);
            }
            return food;
        }
    }
}
