using System;

namespace Task2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1, operand2;
            double result;
            Console.WriteLine("Enter 1st operand: ");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol. +-/*^ are allowed: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter 2nd operand: ");
            operand2 = Convert.ToInt32(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"Your result: {operand1} + {operand2} = {result}");
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"Your result: {operand1} - {operand2} = {result}");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"Your result: {operand1} * {operand2} = {result}");
                    break;
                case "/":
                    while (operand2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        operand2 = Convert.ToInt32(Console.ReadLine());
                    }
                    result = operand1 / operand2;
                    Console.WriteLine($"Your result: {operand1} / {operand2} = {result}");
                    break;
                case "^":
                    result = (int)Math.Pow(operand1, operand2);
                    Console.WriteLine($"Your result: {operand1} ^ {operand2} = {result}");
                    break;
                default:
                    Console.WriteLine("Sorry, incorrect input! Please try again!");
                    break;
            }

        }
    }
}
