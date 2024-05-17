using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Electronic : Product
    {
        public string Material { get; set; }

        public Electronic(string name, decimal price, string material) : base(name, price)
        {
            Material = material;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name},{Price}, {Material} ");
        }
    }
}
