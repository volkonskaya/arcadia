using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            char symbol;
            Console.Write("Enter 1st string= ");
            s1 = Console.ReadLine();
            Console.Write("Enter 2nd string= ");
            s2 = Console.ReadLine();
            Console.Write("Enter symbol= ");
            symbol = (char)Console.Read();
            string s3 = String.Concat(s1, s2);
            int indexOfChar = s3.LastIndexOf(symbol);
            Console.WriteLine($"Index of {symbol} in {s3}: {indexOfChar}");
        }
    }
}
