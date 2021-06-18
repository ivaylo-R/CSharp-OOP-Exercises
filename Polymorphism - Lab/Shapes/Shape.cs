using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        public virtual string Draw()
        {
            return "Drawing ";
        }

        public abstract double CalculatePerimeter();


        public abstract double CalculateArea();
        


    }
}
