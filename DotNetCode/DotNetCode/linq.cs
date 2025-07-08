//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }
//    public string Location { get; set; }
//}
//class Program
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>
//        {
//            new Employee { Name = "Ram", Salary = 60000, Location = "New Baneshwor"
//},
//            new Employee { Name = "Sita", Salary = 45000, Location = "Lalitpur" },
//            new Employee { Name = "Hari", Salary = 55000, Location = "New Baneshwor"
//},
//            new Employee { Name = "Gita", Salary = 70000, Location = "New Baneshwor"
//},
//            new Employee { Name = "Shyam", Salary = 52000, Location = "Bhaktapur" }
//        };

//        var result = from e in employees
//                     where e.Salary > 50000 && e.Location == "New Baneshwor"
//                     orderby e.Salary
//                     select e;
//        Console.WriteLine("Employees in New Baneshwor with salary > 50000 (sorted by 
//salary):"); 
//        foreach (var emp in result)
//        {
//            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Location: 
//{ emp.Location}
//            "); 
//        }
//    }
//}