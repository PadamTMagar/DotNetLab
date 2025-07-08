using System;

namespace DotNetLab
{
    public class Lab1q10
    {
        public static void Run()
        {
            Console.Write("Enter an alphabet: ");
            char ch = Console.ReadLine().ToLower()[0];  // Convert to lowercase for simplicity

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{ch} is a Vowel.");
                    break;
                default:
                    if ((ch >= 'a' && ch <= 'z'))
                    {
                        Console.WriteLine($"{ch} is a Consonant.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter an alphabet.");
                    }
                    break;
            }
        }
    }
}
