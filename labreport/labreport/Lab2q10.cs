using System;

namespace DotNetLab
{
    // Base class Shape
    public class Shape
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
            Console.WriteLine("Default constructor of Shape called.");
        }

        // Parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
            Console.WriteLine("Parameterized constructor of Shape called.");
        }
    }

    // Derived class Rectangle from Shape
    public class Rectangle : Shape
    {
        // Constructor that uses base class constructor
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        public double CalculateArea()
        {
            return Length * Breadth;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Breadth: {Breadth}");
            Console.WriteLine($"Area of Rectangle: {CalculateArea()}");
        }
    }

    public class Lab2q10
    {
        public static void Run()
        {
            Console.WriteLine("Enter length of rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter breadth of rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            // Create Rectangle object using parameterized constructor
            Rectangle rect = new Rectangle(length, breadth);

            // Display area
            rect.DisplayArea();
        }
    }
}
