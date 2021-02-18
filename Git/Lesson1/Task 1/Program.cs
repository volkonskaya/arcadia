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
            int powZ = (int)Math.Pow(z, 2);
            powZ++;
            double rezult1 = (x + y) * powZ;

            // второй пункт
            double sqrtY = (int)Math.Sqrt(y);
            double divideXZ = x / z;
            divideXZ--;
            double rezult2 = divideXZ * sqrtY;

            // третий пункт
            int cubeZ = (int)Math.Pow(z, 3);
            int multi1 = x * y;
            int multi2 = y * z;
            double rezult3 = (multi1 + multi2) / cubeZ;

            Console.WriteLine("First expression result:" + rezult1);
            Console.WriteLine("Second expression result:" + rezult2);
            Console.WriteLine("Third expression result:" + rezult3);
        }
    }
}
