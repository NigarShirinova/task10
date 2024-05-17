using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, string breed, string color) : base(name, age, breed, color)
        {

        }
        
            public override string MakeVoice()
        {
            return "hav";
        }
    }
    }
    
