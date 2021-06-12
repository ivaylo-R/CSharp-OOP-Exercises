using System;
using System.Text;

namespace P01.BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double heigth;
        private string EXC_MSG = "{0} cannot be zero or negative.";

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidateSide(value, nameof(Length));
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                ValidateSide(value, nameof(Width));
                this.width = value;
            }
        }

        public double Height
        {
            get => this.heigth;
            private set
            {
                ValidateSide(value, nameof(Height));
                this.heigth = value;
            }
        }

        private void ValidateSide(double value, string name)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format(EXC_MSG, name));
            }
        }

        public double SurfaceArea() => 2 * (this.Length * this.Width) + LateralSurface();

        public double LateralSurface() => 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
        
        public double Volume() => this.Length * this.Height * this.Width;


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurface():F2}");
            sb.AppendLine($"Volume - {Volume():F2}");
            return sb.ToString();
        }
    }
}
