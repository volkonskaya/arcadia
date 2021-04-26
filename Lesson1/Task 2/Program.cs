using System;

namespace Task_2
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
            int width, height, length;
            double diagonal;
            Console.Write("Enter the width of the rectangular parallelepiped= ");
            width = ValidateIfNotIntegerNumber();
            width = ValidateNumberByZero(width);
            Console.Write("Enter the height of the rectangular parallelepiped= ");
            height = ValidateIfNotIntegerNumber();
            height = ValidateNumberByZero(height);
            Console.Write("Enter the length of the rectangular parallelepiped= ");
            length = ValidateIfNotIntegerNumber();
            length = ValidateNumberByZero(length);
            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2));
            Console.WriteLine($"Parallelepiped diagonal length: {diagonal}");
        }
    }
}
