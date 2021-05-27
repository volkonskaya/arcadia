using System;

namespace Figure_Calculator
{

    class Program
    {
        static int ValidateIfNotIntegerNumber()
        {
            int num;
            var a = Console.ReadLine();
            while (!int.TryParse(a, out num))
            {
                Console.WriteLine("Value is unacceptable. Only numbers are available for input. Please enter another value: ");
                a = Console.ReadLine();
            }
            return num;
        }

        static int ValidateNumberByZero(int a)
        {
            while (a <= 0)
            {
                Console.WriteLine("Value is unacceptable. Please enter another value: ");
                a = ValidateIfNotIntegerNumber();
            }
            return a;

        }
        static void Main(string[] args)
        {
            int side1, side2, radius;
            Console.WriteLine("Please enter 1st side of Rectangle: ");
            side1 = ValidateIfNotIntegerNumber();
            side1 = ValidateNumberByZero(side1);
            Console.WriteLine("Please enter 2nd side of Rectangle: ");
            side2 = ValidateIfNotIntegerNumber();
            side2 = ValidateNumberByZero(side2);
            Console.WriteLine("Please enter radius for Circle: ");
            radius = ValidateIfNotIntegerNumber();
            radius = ValidateNumberByZero(radius);

            Figure rect = new Rectangle(side1, side2);
            Console.WriteLine($"Area of Rectangle is: {rect.AreaCalculator()}");
            Console.WriteLine($"Perimeter of Rectangle is: {rect.PerimeterCalculator()}");

            Figure circ = new Circle(radius);
            Console.WriteLine($"Area of Circle is: {circ.AreaCalculator()}");
            Console.WriteLine($"Perimeter of Circle is: {circ.PerimeterCalculator()}");
        }
    }
}
