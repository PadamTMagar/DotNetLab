using System;
using System.CodeDom;

namespace DotNetLab
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating..");

        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking..");
        }
    }



    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping..");
        }
    }


    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing..");
        }
    }

    public class Lab2q4
    {

        public static void Run()
        {
            Console.WriteLine("Single Inheritance:");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine("\nMultlevel Inheritance:");
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();


            Console.WriteLine("\nHierarchical Inheritance:");
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
