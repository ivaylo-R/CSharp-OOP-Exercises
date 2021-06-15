using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {

            Engine engine = new Engine();
            engine.Run();

            //string input = string.Empty;
            //List<Animal> animals = new List<Animal>();

            //while ((input = Console.ReadLine()) != "Beast!")
            //{
            //    var AnimalType = input;
            //    var inputArgs = Console.ReadLine();
            //    string[] args = inputArgs.Split().ToArray();
            //    string name = args[0];
            //    int age = int.Parse(args[1]);
            //    string gender = args[2];
            //    try
            //    {
            //        Type typeOfAnimal = Assembly.GetExecutingAssembly()
            //            .GetTypes().First(t => t.Name == AnimalType);
            //       var  animal = (Animal)Activator.CreateInstance(typeOfAnimal, new object[] { name, age, gender });
            //        animals.Add(animal);
            //    }
            //    catch (ArgumentException ae)
            //    {
            //        Console.WriteLine(ae.Message);
            //    }

            //}

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
        }
    }
}
