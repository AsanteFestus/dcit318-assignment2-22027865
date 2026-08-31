using System;

namespace AbstractShapesDemo
{
    /// <summary>
    /// Abstract base class. Cannot be instantiated directly.
    /// GetArea() has no body here - every derived class MUST provide its own implementation.
    /// </summary>
    abstract class Shape
    {
        public abstract double GetArea();

        // Abstract classes can still have regular (non-abstract) members.
        public virtual void Describe()
        {
            Console.WriteLine($"This shape has an area of {GetArea():0.00}");
        }
    }

    /// <summary>
    /// Circle implements GetArea() using the formula: pi * r^2
    /// </summary>
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    /// <summary>
    /// Rectangle implements GetArea() using the formula: width * height
    /// </summary>
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===\n");

            Circle circle = new Circle(radius: 5);
            Rectangle rectangle = new Rectangle(width: 4, height: 6);

            Console.WriteLine($"Circle (radius = 5) area: {circle.GetArea():0.00}");
            Console.WriteLine($"Rectangle (4 x 6) area: {rectangle.GetArea():0.00}");

            // Bonus: demonstrate polymorphism through the abstract Shape type.
            Console.WriteLine("\n--- Polymorphism in action ---");
            Shape[] shapes = { circle, rectangle };
            foreach (Shape shape in shapes)
            {
                shape.Describe();
            }

            // Note: Uncommenting the next line would cause a compile error,
            // since Shape is abstract and cannot be instantiated directly.
            // Shape s = new Shape();
        }
    }
}

