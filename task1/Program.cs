using System.Threading.Channels;
using task3;

public static class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Console.WriteLine(circle1.CalculateArea()); 

        Triangle triangle = new Triangle(3, 4);
        Console.WriteLine(triangle.CalculateArea());

        Square square = new Square(5);
        Console.WriteLine(square.CalculateArea());
    }
}