using System;

namespace Task_1
{
    class Program
    {
        /*static int ifNotIntegerNumber(string enterMessageForUser) //проверка на число
        {
            int result;
            do
            {
                Console.WriteLine(enterMessageForUser);
                var number = Console.ReadLine();
            }
            while (int.TryParse(number, out result));
            return result;
        }*/

        static int ifUnacceptable(int a)
        {
            while (a == 0 | a < 0) 
            {
                Console.WriteLine("Value is unacceptable. Please enter another value: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            return a;

        }

        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter x= ");
            x = Convert.ToInt32(Console.ReadLine());
            ifUnacceptable(x);
            Console.Write("Enter y= ");
            y = Convert.ToInt32(Console.ReadLine());
            ifUnacceptable(y);
            Console.Write("Enter z= ");
            z = Convert.ToInt32(Console.ReadLine());
            ifUnacceptable(z);

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
