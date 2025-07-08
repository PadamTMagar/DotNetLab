using System;

namespace DotNetLab
{
    public class Lab2q1
    {
        public static void Run()
        {
            Console.WriteLine("This is Lab 2 Question 12 - Employee Info");

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee email: ");
            string email = Console.ReadLine();

            Console.Write("Enter employee salary (numbers only): ");
            double salary = Convert.ToDouble(Console.ReadLine()); // Make sure to enter valid number

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Name   : {name}");
            Console.WriteLine($"Email  : {email}");
            Console.WriteLine($"Salary : {salary}");
        }
    }
}
