using System;

namespace InheritanceDemo
{
    /// <summary>
    /// Base class. The 'virtual' keyword allows derived classes to override this method.
    /// </summary>
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    /// <summary>
    /// Dog overrides MakeSound() to provide its own behavior.
    /// </summary>
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    /// <summary>
    /// Cat overrides MakeSound() to provide its own behavior.
    /// </summary>
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===\n");

            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.Write("Animal instance says: ");
            genericAnimal.MakeSound();

            Console.Write("Dog instance says: ");
            dog.MakeSound();

            Console.Write("Cat instance says: ");
            cat.MakeSound();

            // Bonus: demonstrate polymorphism - calling MakeSound()
            // through an Animal reference still runs the derived class's version.
            Console.WriteLine("\n--- Polymorphism in action ---");
            Animal[] animals = { new Animal(), new Dog(), new Cat() };
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
