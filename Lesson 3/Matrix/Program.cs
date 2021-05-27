using System;

namespace Matrix
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
            int n;
            Console.WriteLine("Please enter size of matrix: ");
            n = ValidateIfNotIntegerNumber();
            n = ValidateNumberByZero(n);
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
