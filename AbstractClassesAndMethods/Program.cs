using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class Shape
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double GetArea();
        
        // Regular method that can be used by all derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This is a {GetType().Name} with area: {GetArea():F2}");
        }
    }

    // Derived class Circle that inherits from Shape
    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Property for radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Implementation of abstract method GetArea()
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Override DisplayInfo to provide more specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius:F2} has area: {GetArea():F2}");
        }
    }

    // Derived class Rectangle that inherits from Shape
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Properties for width and height
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Implementation of abstract method GetArea()
        public override double GetArea()
        {
            return width * height;
        }

        // Override DisplayInfo to provide more specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with width {width:F2} and height {height:F2} has area: {GetArea():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas using the GetArea() method
            Console.WriteLine("Shape Areas:");
            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");

            Console.WriteLine();
            Console.WriteLine("Using DisplayInfo method:");
            circle.DisplayInfo();
            rectangle.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Demonstrating polymorphism with abstract classes:");
            
            // Using polymorphism - abstract class reference to derived objects
            Shape[] shapes = { 
                new Circle(3.5), 
                new Rectangle(2.5, 8.0),
                new Circle(7.2),
                new Rectangle(5.5, 3.3)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape[{i}]: {shapes[i].GetType().Name} - Area: {shapes[i].GetArea():F2}");
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
