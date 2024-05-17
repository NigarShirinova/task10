using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Group
    {
        private Student[] students;
        public Student[] Students { get => students; }

        private Teacher[] teachers;
        public Teacher[] Teachers { get => teachers; }

        private Subject[] subjects;
        public Subject[] Subjects { get => subjects; }

        public int GroupNo { get; set; }
        public int Limit { get; set; }

        public DateTime startDate { get; set; }
        public DateTime finishDate {  get; set; }


        public Group(int groupno, int limit, DateTime startDate, DateTime finishDate) 
        { 
            
            GroupNo = groupno;
            Limit = limit;
            this.startDate = startDate;
            this.finishDate = finishDate;
            students = new Student[0];
            teachers = new Teacher[0];
            subjects = new Subject[0];

        }

        public void AddStudent(Student student)
        {
            if( students.Length < Limit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[Students.Length - 1] = student;
                
            }
            else
            {
                Console.WriteLine("Limiti asirsiniz");
            }
                
        }

        public void GetStudents()
        {
            foreach (Student s in students)
            {
                s.GetStudent(s);
            }
        }

        public void RemoveStudent(Student student)
        {
            int index = Array.IndexOf(students, student);
            for (int i = index; i < students.Length - 1; i++)
            {
                students[i] = students[i + 1];
            }
            Array.Resize(ref students, students.Length - 1);
        }


        public void AddTeacher(Teacher teacher)
        {
            
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[Teachers.Length - 1] = teacher;

            

        }

        public void GetTeachers()
        {
            foreach (Teacher t in teachers)
            {
                t.GetTeacher(t);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            int index = Array.IndexOf(teachers, teacher);
            for (int i = index; i < teachers.Length - 1; i++)
            {
                teachers[i] = teachers[i + 1];
            }
            Array.Resize(ref teachers, teachers.Length - 1);
        }




        public void AddSubject(Subject subject)
        {

            Array.Resize(ref subjects, subjects.Length + 1);
            subjects[Subjects.Length - 1] = subject;



        }

        public void GetSubjects()
        {
            foreach (Subject s in subjects)
            {
                s.GetSubject(s);
            }
        }

        public void RemoveSubject(Subject subject)
        {
            int index = Array.IndexOf(subjects, subject);
            for (int i = index; i < subjects.Length - 1; i++)
            {
                subjects[i] = subjects[i + 1];
            }
            Array.Resize(ref subjects, subjects.Length - 1);
        }

        public void GetDetails(Group group)
        {
            
            Console.WriteLine($"{group.Limit}, {group.GroupNo}, start date :{group.startDate.ToShortDateString()}, finish date : {group.finishDate.ToShortDateString()}");
        }

    }
}
