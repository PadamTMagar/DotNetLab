using System;

namespace DotNetLab
{
    public class Lab3q5
    {
        public static void Run()
        {
            Console.WriteLine("Exception Handling Demo:");

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution finished. Thank you!");
            }
        }
    }
}
