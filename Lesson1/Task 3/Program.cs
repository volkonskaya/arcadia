using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2, s3;
            bool result1, result2;
            Console.Write("Enter 1st string= ");
            s1 = Console.ReadLine().ToUpper();
            Console.Write("Enter 2nd string= ");
            s2 = Console.ReadLine().ToUpper();
            Console.Write("Enter 3rd string= ");
            s3 = Console.ReadLine().ToUpper();
            result1 = s1.StartsWith(s2);
            result2 = s1.EndsWith(s3);
            Console.WriteLine($"String {s1} starts from string {s2}: {result1}");
            Console.WriteLine($"String {s1} ends with string {s3}: {result2}");
        }
    }
}
