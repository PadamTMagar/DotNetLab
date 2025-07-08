using System;

namespace DotNetLab
{
    public class Lab1q4
    {
        public static void Run()
        {
            Console.WriteLine("Simple Interest Calculator");

            // Input from user
            Console.Write("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            // Calculate Simple Interest
            double simpleInterest = (principal * time * rate) / 100;

            // Output result
            Console.WriteLine($"Simple Interest = {simpleInterest}");
        }
    }
}
