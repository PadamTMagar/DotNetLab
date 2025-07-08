using System;

public class Lab1q2
{
    public static void Run()
    {
        int num1, num2, num3, sum;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2 + num3;

        Console.WriteLine($"The sum of {num1}, {num2}, and {num3} is: {sum}");
    }
}
