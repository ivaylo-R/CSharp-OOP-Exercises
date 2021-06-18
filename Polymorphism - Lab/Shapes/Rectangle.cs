namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Height { get; private set; }

        public double Width { get; private set; }


        public override double CalculateArea() => this.Width * this.Height;


        public override double CalculatePerimeter()
        {
            return 2 * this.Width + 2 * this.Height;
        }

        public override string Draw()
        {
            return $"{base.Draw()}{this.GetType().Name}";
        }
    }
}
