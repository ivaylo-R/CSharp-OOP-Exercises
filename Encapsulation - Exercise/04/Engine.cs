using _04.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04
{
    public class Engine
    {
        private ConsoleReader reader;
        private ConsoleWriter writer;

        public Engine()
        {
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
        }

        public void Run()
        {
            try
            {
                var pizzaArgs = reader.ReadLine().Split().ToArray();

                string pizzaName = pizzaArgs[1].ToString();

                var doughArgs = reader.ReadLine().Split().ToArray();

                var doughFlourType = doughArgs[1];
                var doughBakingTechnique = doughArgs[2];
                var doughWeight = double.Parse(doughArgs[3]);
                Dough dough = null;
                Pizza pizza = null;
               
                try
                {
                    dough = new Dough(doughFlourType, doughBakingTechnique, doughWeight);

                    pizza = new Pizza(pizzaName, dough);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }


                var input = "";
                while ((input = reader.ReadLine()) != "END")
                {
                    var toppingArgs = input
                        .Split()
                        .ToArray();

                    var toppingType = toppingArgs[1];
                    var toppingWeight = double.Parse(toppingArgs[2]);
                    object topping = null;
                    try
                    {
                        topping = new Topping(toppingType, toppingWeight);
                        pizza.AddTopping((Topping)topping);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);

                    }

                    
                }

                writer.WriteLine(pizza.ToString());
            }
            catch (ArgumentException e)
            {
                writer.WriteLine(e.Message);
            }
        }


    }
}