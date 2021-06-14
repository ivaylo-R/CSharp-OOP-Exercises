using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet:IBirthdaytable
    {
        public Pet(DateTime birthdate, string name)
        {
            Birthdate = birthdate;
            Name = name;
        }

        public DateTime Birthdate { get; }

        public string Name { get; }
    }
}
