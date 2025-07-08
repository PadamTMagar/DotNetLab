using System;

namespace DotNetLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DotNet Lab Report Menu ===");
            Console.WriteLine("Select program to run:");
            Console.WriteLine("Enter question number (1 to 34):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // Lab 1 (13 questions)
                case 1: Lab1q1.Run(); break;
                case 2: Lab1q2.Run(); break;
                case 3: Lab1q3.Run(); break;
                case 4: Lab1q4.Run(); break;
                case 5: Lab1q5.Run(); break;
                case 6: Lab1q6.Run(); break;
                case 7: Lab1q7.Run(); break;
                case 8: Lab1q8.Run(); break;
                case 9: Lab1q9.Run(); break;
                case 10: Lab1q10.Run(); break;
                case 11: Lab1q11.Run(); break;
                case 12: Lab1q12.Run(); break;
                case 13: Lab1q13.Run(); break;

                // Lab 2 (11 questions)
                case 14: Lab2q1.Run(); break;
                case 15: Lab2q2.Run(); break;
                case 16: Lab2q3.Run(); break;
                case 17: Lab2q4.Run(); break;
                case 18: Lab2q5.Run(); break;
                case 19: Lab2q6.Run(); break;
                case 20: Lab2q7.Run(); break;
                case 21: Lab2q8.Run(); break;
                case 22: Lab2q9.Run(); break;
                case 23: Lab2q10.Run(); break;
                case 24: Lab2q11<int>.Run(); break;

                //// Lab 3 (10 questions)
                case 25: Lab3q1.Run(); break;
                case 26: Lab3q2.Run(); break;
                //case 27: Lab3q3.Run(); break;
                //case 28: Lab3q4.Run(); break;
                case 29: Lab3q5.Run(); break;
                case 30: Lab3q6.Run(); break;
                //case 31: Lab3q7.Run(); break;
                //case 32: Lab3q8.Run(); break;
                //case 33: Lab3q9.Run(); break;
                //case 34: Lab3q10.Run(); break;

                default:
                    Console.WriteLine("Invalid choice. Enter number between 1 and 34.");
                    break;
            }
        }
    }
}
