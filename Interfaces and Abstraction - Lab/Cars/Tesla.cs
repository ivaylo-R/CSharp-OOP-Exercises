using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car,IElectricCar
    {
        public Tesla(string model, string color,int battery)
            :base(model,color)
        {
            Battery = battery;
        }

        public int Battery { get; }

        public override string Start() =>
           "Engine start";


        public override string Stop() =>
            "Breaaak!";


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
