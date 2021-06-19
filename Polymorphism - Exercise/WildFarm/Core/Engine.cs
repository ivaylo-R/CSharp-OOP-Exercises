using Raiding.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        private readonly IReadable reader;
        private IWritable writer;
        private readonly AnimalFactory animalFactory;
        private readonly FoodFactory foodFactory;
        private readonly ICollection<Animal> animals;
        public Engine(IReadable reader, IWritable writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = new AnimalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            ReadInput();
            PrintResult();
        }

        private void PrintResult()
        {
            foreach (var a in this.animals)
            {
                
                writer.WriteLine(a.ToString());
            }
        }

        private void ReadInput()
        {
            while (true)
            {
                var line = reader.ReadLine();
                if (line=="End")
                {
                    break;
                }
                var animalArgs =line.Split();
                var foodArgs =reader.ReadLine().Split();
                try
                {
                    Animal animal =CreateAnimal(animalArgs);
                    if (animal!=null) animals.Add(animal);
                    Food food = CreateFood(foodArgs);
                    writer.WriteLine(animal.ProduceSound());
                    FeedAnimal(animal, food);
                }
                catch (InvalidOperationException ioe)
                {
                    writer.WriteLine(ioe.Message);
                }
            }
        }

        private void FeedAnimal(Animal animal, Food food)
        {
            animal.Feed(food);
        }

        private Food CreateFood(string[] foodArgs)
            => foodFactory.CreateFood(foodArgs);

        private Animal CreateAnimal(string[] animalArgs)
            =>  animalFactory.CreateAnimal(animalArgs);
        
    }
}
