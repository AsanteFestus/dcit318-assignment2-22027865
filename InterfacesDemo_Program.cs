using System;

namespace InterfacesDemo
{
    /// <summary>
    /// Interface: defines a contract. Any class that implements IMovable
    /// MUST provide its own implementation of Move().
    /// </summary>
    interface IMovable
    {
        void Move();
    }

    /// <summary>
    /// Car implements the IMovable interface.
    /// </summary>
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    /// <summary>
    /// Bicycle implements the IMovable interface.
    /// </summary>
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===\n");

            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            // Bonus: demonstrate polymorphism through the IMovable interface type.
            Console.WriteLine("\n--- Polymorphism in action ---");
            IMovable[] movables = { car, bicycle };
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}
