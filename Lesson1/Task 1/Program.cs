using System;

namespace Task_1
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
            int x, y, z;
            Console.Write("Enter x= ");
            x = ValidateIfNotIntegerNumber(); 
            x = ValidateNumberByZero(x);
            Console.Write("Enter y= ");
            y = ValidateIfNotIntegerNumber();
            y = ValidateNumberByZero(y);
            Console.Write("Enter z= ");
            z = ValidateIfNotIntegerNumber();
            z = ValidateNumberByZero(z);

            // первый пункт
            double powZ = Math.Pow(z, 2);
            double rezult1 = (x + y) * ++powZ;

            // второй пункт
            double divideXZ = x / z;
            double rezult2 = --(divideXZ) * Math.Sqrt(y);

            // третий пункт
            double rezult3 = ((x * y) + (y * z)) / (int)Math.Pow(z, 3);

            Console.WriteLine($"First expression result: {rezult1}");
            Console.WriteLine($"Second expression result: {rezult2}");
            Console.WriteLine($"Third expression result: {rezult3}");
        }
    }
}
