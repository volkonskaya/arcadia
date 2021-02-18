using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height, length;
            double diagonal;
            Console.Write("Enter the width of the rectangular parallelepiped= ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of the rectangular parallelepiped= ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the rectangular parallelepiped= ");
            length = Convert.ToInt32(Console.ReadLine());
            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2));
            Console.WriteLine("Parallelepiped diagonal length:" + diagonal);
        }
    }
}
