using System;

namespace DotNetLab
{
    public class Lab1q3
    {
        public static void Run()
        {
            // Input from user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            // Output on separate lines
            Console.WriteLine("\nYour Details:");
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("Email   : " + email);
        }
    }
}

