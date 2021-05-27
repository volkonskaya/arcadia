using System;

namespace Task2_Calculator
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
        static void Main(string[] args)
        {
            int operand1, operand2;
            double result;
            Console.WriteLine("Enter 1st operand: ");
            operand1 = ValidateIfNotIntegerNumber();
            Console.WriteLine("Enter symbol. +-/*^ are allowed: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter 2nd operand: ");
            operand2 = ValidateIfNotIntegerNumber();

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
