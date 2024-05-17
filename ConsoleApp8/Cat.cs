using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {
             

        }

        public override string MakeVoice()
        {
            return "miyau";
        }
    }
}
