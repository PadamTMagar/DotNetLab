using System;

namespace DotNetLab
{
    public class Animals
    {
        // Virtual method
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Cow : Animals
    {
        // Override the virtual method
        public override void Sound()
        {
            Console.WriteLine("Moew barks.");
        }
    }

    public class Lab2q5

    {
        public static void Run()
        {
            Animals myAnimal = new Animals();
            Animals myCow = new Cow();

            myAnimal.Sound();  // Calls Animal's Sound
            myCow.Sound();     // Calls Dog's overridden Sound
        }
    }
}
