using System;
using School; // 👈 Import the other namespace

namespace DotNetLab
{
    public class Lab2q2
    {
        public static void Run()
        {
            // Create object of Student class from School namespace
            Lab2q2student student = new Lab2q2student();

            // Access fields and method
            Console.WriteLine("Accessing class from another namespace:");
            student.ShowInfo();
        }
    }
}
