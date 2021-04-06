using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter size of matrix: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random rnd = new Random();
            int sum = 0;
            int i, j;
            Console.WriteLine("Your matrix: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                    Console.Write(array[i, j] + " ");
                    if (i == j)
                    {
                        sum += array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Matrix trace is: {sum}");
            Console.ReadLine();
        }
    }
}
