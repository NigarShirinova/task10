using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Square: Shape
    {
        public int Side { get; set; }
    public Square(int side)
    {
            Side = side;
    }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    
}
