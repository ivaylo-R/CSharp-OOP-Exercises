using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine
    {
        public void Run()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryphone = new StationaryPhone();
            MakePhoneCall(phoneNumbers, smartphone, stationaryphone);
            Browse(urls, smartphone);
        }

        private void Browse(string[] urls, Smartphone smartphone)
        {
            foreach (var url in urls)
            {
                try
                {
                    smartphone.Browse(url);
                }
                catch (ArgumentException ae )
                {
                    Console.WriteLine(ae.Message);
                }
                
            }
        }

        private static void MakePhoneCall(string[] phoneNumbers, Smartphone smartphone, StationaryPhone stationaryphone)
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                var phoneNumber = phoneNumbers[i];
                if (phoneNumber.Length == 7)
                {
                    try
                    {
                        stationaryphone.Call(phoneNumber);

                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (phoneNumber.Length == 10)
                {
                    try
                    {
                        smartphone.Call(phoneNumber);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }

            }
        }
    }
}
