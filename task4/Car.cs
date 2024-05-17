using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4;

    internal class Car : Vehicle
    {
    
    public int Passenger {  get; set; }

    public Car(string name, string color, string model, int maxVelocity, int motor, int fuelCapacity, int passenger): base(name, color, model, maxVelocity, motor, fuelCapacity)
    {

        Passenger = passenger;
    }
  public override string GetDetails()
    {
        return $"{ Name}, { Color}, { Model}, { MaxVelocity}, { Motor}, {FuelCapacity}";
    }

            
        }
  




