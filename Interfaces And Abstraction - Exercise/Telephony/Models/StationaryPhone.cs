using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public void Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
