using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task4
{
    internal class Truck : Vehicle
    {
        public int Volume { get; set; }
        public Truck(string name, string color, string model, int maxVelocity, int motor, int fuelCapacity, int volume) : base(name, color, model, maxVelocity, motor, fuelCapacity) 
        {

            Volume = volume;
        }
        public override string GetDetails()
        {
            return $"{Name}, {Color}, {Model}, {MaxVelocity}, {Motor}, {FuelCapacity}, {Volume}";
        }
    }
}
