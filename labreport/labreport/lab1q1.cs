//Write a c#a program to take input from a user to print yourname and print "welcome Yourname, to dotnet technology"


using System;

namespace DotNetLab
{
    public class Lab1q1
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}, to DotNet Technologies!");
        }
    }
}