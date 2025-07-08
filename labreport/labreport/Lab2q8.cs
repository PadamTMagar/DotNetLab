using System;

namespace DotNetLab
{
    public class Lab2q8
    {
        public int Value;

        // Constructor
        public Lab2q8(int value)
        {
            Value = value;
        }

        // Overload binary + operator
        public static Lab2q8 operator +(Lab2q8 a, Lab2q8 b)
        {
            // Add values and return new object
            return new Lab2q8(a.Value + b.Value);
        }

        public void Display()
        {
            Console.WriteLine("Value: " + Value);
        }

        public static void Run()
        {
            Console.WriteLine("Binary Operator Overloading Demo:");

            Lab2q8 obj1 = new Lab2q8(15);
            Lab2q8 obj2 = new Lab2q8(25);

            Console.WriteLine("Object 1:");
            obj1.Display();

            Console.WriteLine("Object 2:");
            obj2.Display();

            Lab2q8 result = obj1 + obj2; // Uses overloaded +
            Console.WriteLine("After Adding:");
            result.Display();
        }
    }
}
