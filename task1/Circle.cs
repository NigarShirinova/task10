using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius) 
        { 
            Radius = radius;

        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
