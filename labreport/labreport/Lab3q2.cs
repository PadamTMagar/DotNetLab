using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetLab
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }

    public class Lab3q2
    {
        public static void Run()
        {
            // Sample list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "Padam", Address = "Kathmandu", Salary = 60000 },
                new Employee { Name = "Sita", Address = "Lalitpur", Salary = 55000 },
                new Employee { Name = "Ram", Address = "Kathmandu", Salary = 45000 },
                new Employee { Name = "Gita", Address = "Kathmandu", Salary = 70000 }
            };

            // LINQ query to filter employees
            var filtered = from emp in employees
                           where emp.Salary > 50000 && emp.Address == "Kathmandu"
                           select emp;

            // Display results
            Console.WriteLine("Employees with salary > 50000 and address 'Kathmandu':");
            foreach (var emp in filtered)
            {
                Console.WriteLine($"Name: {emp.Name}, Address: {emp.Address}, Salary: {emp.Salary}");
            }
        }
    }
}
