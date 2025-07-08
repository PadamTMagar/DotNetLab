using System;

namespace DotNetLab
{
    public class Lab2q7
    {
        public int Value;

        // Constructor
        public Lab2q7(int value)
        {
            Value = value;
        }

        // Overload unary minus operator
        public static Lab2q7 operator -(Lab2q7 obj)
        {
            // Return new object with negated value
            return new Lab2q7(-obj.Value);
        }

        public void Display()
        {
            Console.WriteLine("Value: " + Value);
        }

        public static void Run()
        {
            Console.WriteLine("Unary Operator Overloading Demo:");

            Lab2q7 num = new Lab2q7(10);
            Console.WriteLine("Original Object:");
            num.Display();

            Lab2q7 negated = -num; // Use overloaded unary minus
            Console.WriteLine("After Applying Unary Minus:");
            negated.Display();
        }
    }
}
