using System;

namespace DotNetLab
{
    // Generic class
    public class Lab2q11<T>
    {
        public T Value;

        public Lab2q11(T val)
        {
            Value = val;
        }

        public void Display()
        {
            Console.WriteLine("Value: " + Value);
        }

        // Generic method inside generic class
        public static void Swap<TSwap>(ref TSwap a, ref TSwap b)
        {
            TSwap temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            Console.WriteLine("=== Generic Class and Method Demo ===");

            // Create object with int
            Lab2q11<int> intObj = new Lab2q11<int>(100);
            intObj.Display();

            // Create object with string
            Lab2q11<string> strObj = new Lab2q11<string>("Padam");
            strObj.Display();

            // Use generic method to swap ints
            int a = 10, b = 20;
            Console.WriteLine($"\nBefore Swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            // Use generic method to swap strings
            string x = "Hello", y = "World";
            Console.WriteLine($"\nBefore Swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");
        }
    }
}
