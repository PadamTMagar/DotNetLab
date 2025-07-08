using System;

namespace DotNetLab
{
    public class Lab2q6
    {
        public string Name;
        public int Age;
        public static string SchoolName;

        // 1. Default Constructor
        public Lab2q6()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default constructor called.");
        }

        // 2. Parameterized Constructor
        public Lab2q6(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized constructor called.");
        }

        // 3. Copy Constructor
        public Lab2q6(Lab2q6 other)
        {
            Name = other.Name;
            Age = other.Age;
            Console.WriteLine("Copy constructor called.");
        }

        // 4. Static Constructor
        static Lab2q6()
        {
            SchoolName = "ABC Academy";
            Console.WriteLine("Static constructor called. SchoolName initialized.");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, School: {SchoolName}");
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Using Default Constructor ---");
            Lab2q6 obj1 = new Lab2q6();
            obj1.Display();

            Console.WriteLine("\n--- Using Parameterized Constructor ---");
            Lab2q6 obj2 = new Lab2q6("Padam", 21);
            obj2.Display();

            Console.WriteLine("\n--- Using Copy Constructor ---");
            Lab2q6 obj3 = new Lab2q6(obj2);
            obj3.Display();
        }
    }
}
