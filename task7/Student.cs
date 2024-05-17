using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

        public void GetStudent(Student student)
        {
            Console.WriteLine($"{Name}, {SurName}");
        }
        
    }
}
