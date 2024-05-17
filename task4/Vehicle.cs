using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public int MaxVelocity { get; set; }
        public int Motor {  get; set; }
        public int FuelCapacity { get; set; }        

        public Vehicle(string name, string color , string model, int maxVelocity, int motor, int fuelCapacity)
        {
            Name = name;
            Color = color;
            Model = model;
            MaxVelocity = maxVelocity;
            Motor = motor;
            FuelCapacity = fuelCapacity;

        }

        public virtual string GetDetails()
        {
            return $"{Name}, {Color}, {Model}, {MaxVelocity}, {Motor}, {FuelCapacity}";
        }
    }
}
