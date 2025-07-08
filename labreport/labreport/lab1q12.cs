using System;

namespace DotNetLab
{
    public class Lab1q12
    {
        public static void Run()
        {
            Console.Write("Enter the number of marks: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Number of marks should be greater than zero.");
                return;
            }

            int[] marks = new int[n];

            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = marks[0];
            int max = marks[0];
            int sum = 0;

            // Calculate min, max, sum
            for (int i = 0; i < n; i++)
            {
                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];

                sum += marks[i];
            }

            double average = (double)sum / n;

            Console.WriteLine($"Minimum mark: {min}");
            Console.WriteLine($"Maximum mark: {max}");
            Console.WriteLine($"Average mark: {average:F2}");
        }
    }
}
