using System;

namespace DotNetLab
{
    // Declare a delegate
    public delegate void MathOperation(int a, int b);

    public class Lab3q1
    {
        // Method 1
        public static void Add(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }

        // Method 2
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }

        // Method 3
        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication: {a * b}");
        }

        public static void Run()
        {
            Console.WriteLine("Multicast Delegate Demo:");

            // Create delegate instance and add methods
            MathOperation operation = Add;
            operation += Subtract;
            operation += Multiply;

            // Take input from user
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call all methods in the delegate
            Console.WriteLine("\nInvoking multicast delegate:");
            operation(num1, num2);
        }
    }
}
