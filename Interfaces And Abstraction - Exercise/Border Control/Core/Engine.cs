using System;
using System.Collections.Generic;
using System.Linq;
namespace BorderControl.Core
{
    public class Engine
    {
        public void Run()
        {
            HashSet<IBuyer> persons = new HashSet<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split();
                //if (tokens.Length == 3 && tokens.Contains("Robot"))
                //{
                //    var model = tokens[1];
                //    var id = tokens[2];
                //    Robot robot = new Robot(model, id);

                //}
                //else if (tokens.Length == 3 && tokens.Contains("Pet"))
                //{
                //    var name = tokens[1];
                //    var birthdateTokens = tokens[2].Split('/').ToArray();
                //    birthdaytables.Add(new Pet(ReadDate(birthdateTokens), name));
                //}
                if (tokens.Length == 4)
                {
                    var name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    var id = tokens[2];
                    var birthdateTokens = tokens[3].Split('/').ToArray();
                    persons.Add(new Citizen(name, age, id, ReadDate(birthdateTokens)));
                }

                else if (tokens.Length == 3)
                {
                    var name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group = tokens[2];
                    persons.Add(new Rebel(name, age, group));
                }

            }
            var sumOfFood = 0;

            while (true)
            {
                string buyer = Console.ReadLine();
                if (buyer == "End")
                {
                    break;
                }

                foreach (var person in persons)
                {
                    if (person.Name == buyer)
                    {
                        person.BuyFood();
                    }
                }
            }
            foreach (var person in persons)
            {
                sumOfFood += person.Food;
            }
            Console.WriteLine(sumOfFood);


            //PrintResults(birthDate, birthdaytables);
        }

        //private void PrintResults(string birthDate, List<IBirthdaytable> birthdaytables)
        //{
        //    foreach (var item in birthdaytables)
        //    {

        //        if (item.Birthdate.Year.ToString() == birthDate)
        //        {
        //            string day = item.Birthdate.Day.ToString();
        //            string month = item.Birthdate.Month.ToString();
        //            string year = item.Birthdate.Year.ToString();
        //            string dayParsed = int.Parse(day) < 10 ? $"0{day}" : day;
        //            string monthParsed = int.Parse(month) < 10 ? $"0{month}" : month;

        //            Console.WriteLine($"{dayParsed}/{monthParsed}/{year}");

        //        }
        //    }

        //}


        public DateTime ReadDate(string[] birthdateTokens)
        {
            var year = int.Parse(birthdateTokens[2]);
            var month = int.Parse(birthdateTokens[1]);
            var day = int.Parse(birthdateTokens[0]);
            return new DateTime(year, month, day);
        }
    }
}
