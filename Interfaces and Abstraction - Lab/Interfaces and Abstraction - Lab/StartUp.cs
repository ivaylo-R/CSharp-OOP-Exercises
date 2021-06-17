using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var height = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(height, width);

            circle.Draw();
            rect.Draw();
        }
    }
}
