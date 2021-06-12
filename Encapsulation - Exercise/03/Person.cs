using System;
using System.Collections.Generic;
using System.Text;

namespace _03
{
    public class Person
    {
        
        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.bag = new List<Product>();
        }

        public IReadOnlyCollection<Product> Bag
        {
            get => (IReadOnlyCollection<Product>)this.bag;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.NAME_EXC_MSG);
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.MONEY_EXC_MSG);
                }
                this.money = value;
            }
            
        }

        public string Buy(Product product)
        {
            if (this.Money >= product.Cost)
            {
                bag.Add(product);
                this.Money -= product.Cost;
                return string.Format(GlobalConstants.SUCCES_BOUGHT_PRODUCT, this.Name, product.Name);
            }
            else
            {
                throw new ArgumentException(String.Format(GlobalConstants.CANT_AFFORD_EXC_MSG, this.Name, product.Name));

            }
        }
    }
}
