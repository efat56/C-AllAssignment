using System;

// Base class 
class Vehicle
{
    // Common properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Vehicle(string make, string model, int year, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    // Common methods
    public void Start()
    {
        Console.WriteLine("Starting the vehicle...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping the vehicle...");
    }
}

// Derived class 
class Car : Vehicle
{
    // Car properties
    public int NumberOfDoors { get; set; }
    public string FuelType { get; set; }

    public Car(string make, string model, int year, string color, int doors, string fuelType)
        : base(make, model, year, color)
    {
        NumberOfDoors = doors;
        FuelType = fuelType;
    }

    // Car Own method
    public void Drive()
    {
        Console.WriteLine("Driving the car...");
    }
}

// Derived class for Bicycles
class Bicycle : Vehicle
{
    
    public int NumberOfGears { get; set; }
    public string FrameMaterial { get; set; }

    public Bicycle(string make, string model, int year, string color, int gears, string frameMaterial)
        : base(make, model, year, color)
    {
        NumberOfGears = gears;
        FrameMaterial = frameMaterial;
    }

    
    public void Pedal()
    {
        Console.WriteLine("Pedaling the bicycle...");
    }
}


class Motorcycle : Vehicle
{

    public string EngineType { get; set; }

    public Motorcycle(string make, string model, int year, string color, string engineType)
        : base(make, model, year, color)
    {
        EngineType = engineType;
    }

  
    public void StartEngine()
    {
        Console.WriteLine("Starting the motorcycle's engine...");
    }
}

class Program
{
    static void Main()
    {
    
        Car car = new Car("Toyota", "Camry", 2023, "Red", 4, "Gasoline");
        Bicycle bicycle = new Bicycle("Trek", "Mountain Bike", 2023, "Blue", 21, "Aluminum");
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2023, "Black", "V-Twin");

        // Access properties and methods of each class
        Console.WriteLine("Car Details:");
        Console.WriteLine($"Make: {car.Make}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Year: {car.Year}");
        Console.WriteLine($"Color: {car.Color}");
        Console.WriteLine($"Number of Doors: {car.NumberOfDoors}");
        Console.WriteLine($"Fuel Type: {car.FuelType}");
        car.Start();
        car.Drive();
        car.Stop();

       

        Console.WriteLine("\nBicycle Details:");
        Console.WriteLine($"Make: {bicycle.Make}");
        Console.WriteLine($"Model: {bicycle.Model}");
        Console.WriteLine($"Year: {bicycle.Year}");
        Console.WriteLine($"Color: {bicycle.Color}");
        Console.WriteLine($"Number of Gears: {bicycle.NumberOfGears}");
        Console.WriteLine($"Frame Material: {bicycle.FrameMaterial}");
        bicycle.Start();  // Note: This is a common method inherited from the base class
        bicycle.Pedal();

        Console.WriteLine("\nMotorcycle Details:");
        Console.WriteLine($"Make: {motorcycle.Make}");
        Console.WriteLine($"Model: {motorcycle.Model}");
        Console.WriteLine($"Year: {motorcycle.Year}");
        Console.WriteLine($"Color: {motorcycle.Color}");
        Console.WriteLine($"Engine Type: {motorcycle.EngineType}");
        motorcycle.Start();
        motorcycle.StartEngine();
        motorcycle.Stop();
        Console.ReadLine();

    }
}
