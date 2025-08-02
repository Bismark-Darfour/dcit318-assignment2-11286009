using System;

namespace InheritanceAndOverriding
{
    // Base class Animal
    public class Animal
    {
        // Virtual method that can be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog that inherits from Animal
    public class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat that inherits from Animal
    public class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
            Console.WriteLine();

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            Console.WriteLine("Animal sounds:");
            Console.Write("Animal: ");
            animal.MakeSound();

            Console.Write("Dog: ");
            dog.MakeSound();

            Console.Write("Cat: ");
            cat.MakeSound();

            Console.WriteLine();
            Console.WriteLine("Demonstrating polymorphism:");
            
            // Demonstrating polymorphism - base class reference to derived objects
            Animal[] animals = { new Animal(), new Dog(), new Cat() };
            
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Animal[{i}]: ");
                animals[i].MakeSound();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            try
            {
                Console.ReadKey();
            }
            catch (InvalidOperationException)
            {
                // Handle case when console input is redirected
                Console.WriteLine("Program completed.");
            }
        }
    }
}
