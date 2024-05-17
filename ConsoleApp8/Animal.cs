using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal abstract class Animal
    { 
       
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public string Color { get; set; }

        public Animal(string name, int age, string breed, string color )
        {
           Name = name;
            Breed = breed;
            Color = color;
            Age = age;
        }

        public abstract string MakeVoice();
        


    }

        
    
}
