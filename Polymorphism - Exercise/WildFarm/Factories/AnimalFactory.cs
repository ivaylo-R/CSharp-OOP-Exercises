using System;
using WildFarm.Models;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string[] animalArgs)
        {
            var type = animalArgs[0];

            Animal animal = null;
            var name = animalArgs[1];
            var weight = double.Parse(animalArgs[2]);

            switch (type)
            {
                case "Cat":
                    var livingRegion = animalArgs[3];
                    var breed = animalArgs[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                    break;
                case "Dog":
                    livingRegion = animalArgs[3];
                    animal = new Dog(name, weight, livingRegion);
                    break;
                case "Mouse":
                    livingRegion = animalArgs[3];
                    animal = new Mouse(name, weight, livingRegion);
                    break;
                case "Tiger":
                    livingRegion = animalArgs[3];
                    breed = animalArgs[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                    break;
                case "Hen":
                    var wingSize = double.Parse(animalArgs[3]);
                    animal = new Hen(name, weight, wingSize);
                    break;
                case "Owl":
                    wingSize = double.Parse(animalArgs[3]);
                    animal = new Owl(name, weight, wingSize);
                    break;
            }

            if (animal==null)
            {
                throw new ArgumentException();
            }

            return animal;
        }
    }
}
