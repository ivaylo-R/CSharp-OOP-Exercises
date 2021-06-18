using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea() => Math.PI * this.Radius*this.Radius;


        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
           
        }

        public override string Draw()
        {
            return $"{base.Draw()}{this.GetType().Name}";
        }
    }
}
