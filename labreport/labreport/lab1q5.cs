using System;

namespace DotNetLab
{
    public class Lab1q5
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                    break;
            }
        }
    }
}
