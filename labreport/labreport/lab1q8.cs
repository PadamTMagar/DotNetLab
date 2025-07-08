using System;

namespace DotNetLab
{
    public class Lab1q8
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert string to char array, reverse it, then convert back to string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
}
