using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Triangle : Shape
    {
         public int Side { get; set; }
        public int Height { get; set; }
        public Triangle (int side, int height)
        {
            Side = side;
            Height = height;
        }
      
        public override double CalculateArea()
        {
            return Side*Height;
        }

    }

    
}
