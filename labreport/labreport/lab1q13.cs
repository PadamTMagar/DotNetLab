using System;

namespace DotNetLab
{
    public class Lab1q13
    {
        public static void Run()
        {
            Console.Write("Enter number of strings: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];

            Console.WriteLine("Enter the strings:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            // Option 1: Concatenate without separator
            string result = string.Concat(arr);

            // Option 2: Concatenate with space separator
            // string result = string.Join(" ", arr);

            Console.WriteLine("Concatenated string:");
            Console.WriteLine(result);
        }
    }
}
