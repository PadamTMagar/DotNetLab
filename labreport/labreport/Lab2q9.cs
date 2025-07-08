using System;

namespace DotNetLab
{
    public class Lab2q9
    {
        private string _name;
        private int _age;
        private string _secret;

        // 1. Standard Property (Read/Write)
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // 2. Read-Only Property
        public int Age
        {
            get { return _age; }
        }

        // 3. Write-Only Property
        public string Secret
        {
            set { _secret = value; }
        }

        // 4. Auto-Implemented Property
        public string Email { get; set; }

        // Constructor
        public Lab2q9(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Display()
        {
            Console.WriteLine("Name  : " + Name);
            Console.WriteLine("Age   : " + Age);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Secret (not directly accessible)");
        }

        public static void Run()
        {
            Console.WriteLine("Property Demo in C#");

            Lab2q9 person = new Lab2q9("Padam", 21);

            // Use standard property
            person.Name = "Padam Thapa";

            // Read-only: can only read Age
            Console.WriteLine("Accessing Read-Only Property (Age): " + person.Age);

            // Write-only: set but cannot get
            person.Secret = "This is hidden.";

            // Auto-implemented property
            person.Email = "padam@example.com";

            Console.WriteLine("\nDisplaying all accessible properties:");
            person.Display();
        }
    }
}
