using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, int price, string size) : base(name, price) 
        {
            Size = size;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name}, {Price},{Size}");
        }
    }
}
