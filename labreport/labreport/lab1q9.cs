using System;

namespace DotNetLab
{
    public class Lab1q9
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even.");
            }
            else
            {
                Console.WriteLine($"{num} is Odd.");
            }
        }
    }
}
