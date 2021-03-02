using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter x= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y= ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z= ");
            z = Convert.ToInt32(Console.ReadLine());

            // первый пункт
            double powZ = Math.Pow(z, 2);
            double rezult1 = (x + y) * ++powZ;

            // второй пункт
            double divideXZ = x / z;
            double rezult2 = -- (divideXZ) * Math.Sqrt(y);

            // третий пункт
            double rezult3 = ((x * y) + (y * z)) / (int)Math.Pow(z, 3);

            Console.WriteLine($"First expression result: {rezult1}");
            Console.WriteLine($"Second expression result: {rezult2}");
            Console.WriteLine($"Third expression result: {rezult3}");
        }
    }
}
