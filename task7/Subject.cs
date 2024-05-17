using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Subject
    {
        public string Name { get; set; }
       

        public Subject(string name)
        {
            Name = name;
           
        }

        public void GetSubject(Subject subject)
        {
            Console.WriteLine($"{Name}");
        }
    }
}
