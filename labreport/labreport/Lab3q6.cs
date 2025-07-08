using System;

namespace DotNetLab
{
    // Define custom exception class
    public class SalaryTooLowException : Exception
    {
        public SalaryTooLowException() : base("Salary is below the minimum allowed threshold.")
        {
        }

        public SalaryTooLowException(string message) : base(message)
        {
        }
    }

    public class Lab3q6
    {
        public static void CheckSalary(double salary)
        {
            if (salary < 30000)
            {
                // Throw custom exception
                throw new SalaryTooLowException($"Salary {salary} is too low.");
            }
            else
            {
                Console.WriteLine($"Salary {salary} is acceptable.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("Custom Exception Demo:");

            try
            {
                Console.Write("Enter employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                CheckSalary(salary);
            }
            catch (SalaryTooLowException ex)
            {
                Console.WriteLine("Custom Exception caught: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
