using System;

namespace DotNetLab
{
    public class Lab1q7
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
