﻿using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models
{
    public abstract class Food:IFood
    {
        
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; }

        
    }
}
