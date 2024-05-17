using System;
using System.Security.Cryptography.X509Certificates;
using task4;
public static class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("hyundai", "grey", "santafe", 200, 2, 80, 5);
        Truck truck1 = new Truck("yuk masini", "white","salam", 100, 5, 100, 50);
        Console.WriteLine( car1.GetDetails());
        Console.WriteLine(truck1.GetDetails()); 

    }
    
}
