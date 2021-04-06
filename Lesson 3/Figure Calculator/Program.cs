using System;

namespace Figure_Calculator
{
    abstract class Figure
    {
        public abstract int AreaCalculator();
        public abstract int PerimeterCalculator();
    }
    class Circle: Figure
    {
        private int radius;
        private double pi = 3.14;
        public Circle(int radius) // circle constructor
        {
            this.radius = radius;
        }
        public override int AreaCalculator()
        {
            return Convert.ToInt32(pi * (int)Math.Pow(radius, 2));
        }

        public override int PerimeterCalculator()
        {
            return Convert.ToInt32(2 * pi * radius);
        }
    }
    class Rectangle: Figure
    {
        private int side1, side2;
        public Rectangle(int side1, int side2) // rectangle constructor
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override int AreaCalculator()
        {
            return side1 * side2; 
        }

        public override int PerimeterCalculator()
        {
            return 2*(side1 + side2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, radius;
            Console.WriteLine("Please enter 1st side of Rectangle: ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd side of Rectangle: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter radius for Circle: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Area of Rectangle is: {rect.AreaCalculator()}");
            Console.WriteLine($"Perimeter of Rectangle is: {rect.PerimeterCalculator()}");

            Circle circ = new Circle(radius);
            Console.WriteLine($"Area of Circle is: {circ.AreaCalculator()}");
            Console.WriteLine($"Perimeter of Circle is: {circ.PerimeterCalculator()}");
        }
    }
}
