using System;
using task7;
public static class Program
{
    public static void Main(string[] args)

    { DateTime startDate = new DateTime(2024, 3, 30);
        DateTime finishDate = new DateTime(2024, 2, 13);
        Group group1 = new Group(401, 10, startDate,finishDate );
        group1.GetDetails(group1 );

        Student student1 = new Student("Nigar", "Shirinova");
        Student student2 = new Student("Filankes", "Filankesov");   
        group1.AddStudent(student1);
        group1.AddStudent(student2);
        group1.RemoveStudent(student1);
        group1.GetStudents();


        Teacher teacher1 = new Teacher("Kanan", "Tapdigli");
        Teacher teacher2 = new Teacher("Ali", "Ibrahimov");
        group1.AddTeacher(teacher1);
        group1.AddTeacher(teacher2);
        group1.RemoveTeacher(teacher1);
        group1.GetTeachers();


        Subject subject1 = new Subject("backend");
        Subject subject2 = new Subject("frontend");
        group1.AddSubject(subject1);
        group1.AddSubject(subject2);
        group1.RemoveSubject(subject1);
        group1.GetSubjects();

    }
}