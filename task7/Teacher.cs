using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public Teacher(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

        public void GetTeacher(Teacher teacher)
        {
            Console.WriteLine($"{Name}, {SurName}");
        }
    }
}
