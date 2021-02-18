using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3;
            bool result;
            Console.Write("Enter 1st string= ");
            s1 = Console.ReadLine().ToUpper();
            Console.Write("Enter 2nd string= ");
            s2 = Console.ReadLine().ToUpper();
            Console.Write("Enter 3rd string= ");
            s3 = Console.ReadLine().ToUpper();
            if (s1.StartsWith(s2))
            {
                result = true;
                Console.WriteLine($"String {s1} starts from string {s2}: {result}");
            }
            else
            {
                result = false;
                Console.WriteLine($"String {s1} starts from string {s2}: {result}");
            }

            if (s1.EndsWith(s3))
            {
                result = true;
                Console.WriteLine($"String {1} ends with string {3}: {result}");
            }
            else
            {
                result = false;
                Console.WriteLine($"String {1} ends with string {3}: {result}");
            }
        }
    }
}
