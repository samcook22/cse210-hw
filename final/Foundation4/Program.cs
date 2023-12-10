using System;

// Abstract base class representing a vehicle
public abstract class Vehicle
{
    private string brand;
    private string model;

    public Vehicle(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {brand}, Model: {model}");
    }

    // Abstract method to be overridden by derived classes
    public abstract void Start();
}

// Derived class 1: Car
public class Car : Vehicle
{
    private int numberOfDoors;

    public Car(string brand, string model, int numberOfDoors) : base(brand, model)
    {
        this.numberOfDoors = numberOfDoors;
    }

    // Override the Start method for cars
    public override void Start()
    {
        Console.WriteLine($"Starting the car with {numberOfDoors} doors.");
    }

    // Unique method for cars
    public void Drive()
    {
        Console.WriteLine("Driving the car.");
    }
}

// Derived class 2: Motorcycle
public class Motorcycle : Vehicle
{
    private bool hasSidecar;

    public Motorcycle(string brand, string model, bool hasSidecar) : base(brand, model)
    {
        this.hasSidecar = hasSidecar;
    }

    // Override the Start method for motorcycles
    public override void Start()
    {
        Console.WriteLine($"Starting the motorcycle{(hasSidecar ? " with a sidecar" : "")}.");
    }

    // Unique method for motorcycles
    public void Ride()
    {
        Console.WriteLine("Riding the motorcycle.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of the derived classes
        Car myCar = new Car("Toyota", "Camry", 4);
        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Sportster", false);

        // Demonstrate abstraction, encapsulation, inheritance, and polymorphism
        myCar.DisplayInfo();
        myCar.Start();
        myCar.Drive();

        Console.WriteLine();

        myMotorcycle.DisplayInfo();
        myMotorcycle.Start();
        myMotorcycle.Ride();
    }
}
