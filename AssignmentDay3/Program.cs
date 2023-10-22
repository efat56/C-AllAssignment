

// Define the delegate.....
delegate int MathNaticalOperation(int num);
class Program
{
    static int Square(int x)
    {
        return x * x;
    }


    static int Cube(int x)
    {
        return x * x * x;
    }

    static void Main(string[] args)
    {
        // Assign methods to the delegate
        MathNaticalOperation square = Square;

        MathNaticalOperation cube = Cube;

        Console.Write("Enter an Integer.....");
        if(int.TryParse(Console.ReadLine(),out int num))
        {
            int squareResult = Square(num);
            int cubeResult = Cube(num);

            Console.WriteLine($"Square of {num} is {squareResult} ");
            Console.WriteLine($"Cube of {num} is {cubeResult} ");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

    }


}
