using System;
using System.Collections.Generic;
using System.Text;

namespace Figure_Calculator
{
    class Circle : Figure
    {
        private int radius;
        public Circle(int radius) // circle constructor
        {
            this.radius = radius;
        }
        public override double AreaCalculator()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public override double PerimeterCalculator()
        {
            return Convert.ToInt32(2 * Math.PI * radius);
        }
    }
}
