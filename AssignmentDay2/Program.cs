namespace AssignmentDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each derived class
            Car myCar = new Car("Toyota", "Camry", 2023, "Red", 4, "Gasoline");
            Bicycle myBicycle = new Bicycle("Trek", "Mountain Bike", 2023, "Blue", 21, "Aluminum");
            

           
            IVehicleOperations[] vehicles = { myCar, myBicycle};

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Operating a {vehicle.GetType().Name}");
                vehicle.StartEngine();
                double fuelEfficiency = vehicle.CalculateFuelEfficiency();
                Console.WriteLine($"Fuel Efficiency: {fuelEfficiency} mpg\n");
            }
        }
    }

    // Interface.....
    interface IVehicleOperations
    {
        public abstract double CalculateFuelEfficiency();
        public abstract void StartEngine();
    }

    //Base Class....
    class Vehicle
    {
       
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
    }

    // Derived class for Cars
    class Car : Vehicle, IVehicleOperations
    {
        // Car-specific properties
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }

        public Car(string make, string model, int year, string color, int doors, string fuelType)
            : base(make, model, year, color)
        {
            NumberOfDoors = doors;
            FuelType = fuelType;
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the car's engine...");
        }

        public double CalculateFuelEfficiency()
        {
            
            return 25.00; 
        }
    }

    // Derived class for Bicycles
    class Bicycle : Vehicle, IVehicleOperations
    {
       
        public int NumberOfGears { get; set; }
        public string FrameMaterial { get; set; }

        public Bicycle(string make, string model, int year, string color, int gears, string frameMaterial)
            : base(make, model, year, color)
        {
            NumberOfGears = gears;
            FrameMaterial = frameMaterial;
        }

        public void StartEngine()
        {
            Console.WriteLine("Bicycles don't have engines!");
        }

        public double CalculateFuelEfficiency()
        {
           
            return double.PositiveInfinity;
        }
    }


}