using System;

namespace Interfaces
{
    // Interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Additional interface to demonstrate multiple interface implementation
    public interface IFuelable
    {
        void Refuel();
        double FuelLevel { get; set; }
    }

    // Class Car that implements IMovable
    public class Car : IMovable, IFuelable
    {
        private string brand;
        private double fuelLevel;

        // Constructor
        public Car(string brand, double initialFuel = 50.0)
        {
            this.brand = brand;
            this.fuelLevel = initialFuel;
        }

        // Property for brand
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Implementation of IMovable interface
        public void Move()
        {
            if (fuelLevel > 0)
            {
                Console.WriteLine($"{brand} car is moving");
                fuelLevel -= 5.0; // Consume fuel when moving
            }
            else
            {
                Console.WriteLine($"{brand} car cannot move - out of fuel!");
            }
        }

        // Implementation of IFuelable interface
        public void Refuel()
        {
            fuelLevel = 100.0;
            Console.WriteLine($"{brand} car has been refueled to {fuelLevel}%");
        }

        public double FuelLevel
        {
            get { return fuelLevel; }
            set { fuelLevel = value; }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"{brand} car - Fuel level: {fuelLevel:F1}%");
        }
    }

    // Class Bicycle that implements IMovable
    public class Bicycle : IMovable
    {
        private string type;
        private int gears;

        // Constructor
        public Bicycle(string type, int gears)
        {
            this.type = type;
            this.gears = gears;
        }

        // Properties
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }

        // Implementation of IMovable interface
        public void Move()
        {
            Console.WriteLine($"{type} bicycle is moving");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{type} bicycle with {gears} gears");
        }
    }

    // Additional class to demonstrate interface usage
    public class Boat : IMovable
    {
        private string name;

        public Boat(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Move()
        {
            Console.WriteLine($"{name} boat is sailing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===");
            Console.WriteLine();

            // Create instances of Car and Bicycle
            Car car = new Car("Toyota", 75.0);
            Bicycle bicycle = new Bicycle("Mountain", 21);

            // Call Move() method on each instance
            Console.WriteLine("Basic Movement:");
            car.Move();
            bicycle.Move();

            Console.WriteLine();
            Console.WriteLine("Car Status and Refueling:");
            car.DisplayStatus();
            car.Move(); // Use some fuel
            car.DisplayStatus();
            car.Refuel();
            car.DisplayStatus();

            Console.WriteLine();
            Console.WriteLine("Bicycle Information:");
            bicycle.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Demonstrating polymorphism with interfaces:");
            
            // Using interface reference for polymorphism
            IMovable[] movableObjects = { 
                new Car("Honda", 60.0), 
                new Bicycle("Road", 10),
                new Boat("Speedster"),
                new Car("BMW", 90.0)
            };

            for (int i = 0; i < movableObjects.Length; i++)
            {
                Console.Write($"Object[{i}] ({movableObjects[i].GetType().Name}): ");
                movableObjects[i].Move();
            }

            Console.WriteLine();
            Console.WriteLine("Testing fuel functionality on cars only:");
            
            foreach (var obj in movableObjects)
            {
                if (obj is IFuelable fuelableObj)
                {
                    Console.WriteLine($"Refueling {obj.GetType().Name}...");
                    fuelableObj.Refuel();
                }
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
