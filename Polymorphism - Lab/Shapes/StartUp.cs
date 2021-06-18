using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            Shape circle = new Circle(5);

            Shape rectangle = new Rectangle(6, 8);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
