using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Core
{
    public class Engine
    {

        public void Run()
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var citizenArgs = input.Split();
                var name = citizenArgs[0];
                var country = citizenArgs[1];
                var age = int.Parse(citizenArgs[2]);

                IPerson person = new Citizen(name, country, age);
                IResident resident1 = new Citizen(name, country, age);
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident1.GetName());

            }
        }

    }
}
