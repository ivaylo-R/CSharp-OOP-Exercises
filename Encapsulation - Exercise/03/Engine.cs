using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    public class Engine
    {
        private List<Person> persons = new List<Person>();
        private List<Product> products = new List<Product>();
        public void Run()
        {

            var personsArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var personArgs in personsArgs)
            {
                var personInfo = personArgs.Split("=");
                var name = personInfo[0];
                var money = decimal.Parse(personInfo[1]);
                try
                {

                    Person person = new Person(name, money);
                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }

            var productsArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productArgs in productsArgs)
            {
                var productInfo = productArgs.Split("=");
                var name = productInfo[0];
                var price = decimal.Parse(productInfo[1]);
                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "END")
                {
                    break;
                }
                var cmdArgs = cmd.Split();
                string personName = cmdArgs[0];
                string productName = cmdArgs[1];
                Person person = persons.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);
                try
                {
                    string result = person.Buy(product);
                    Console.WriteLine(result);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            foreach (var person in persons)
            {
                if (person.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought ");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Bag)}");
                }
            }
        }


    }
}
