using ConsoleApp8;
using System;
using System.Net.Mail;
namespace Lesson
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Cat mia = new Cat("mia", 2, "british", "grey");
            Dog alex = new Dog("alex", 3, "golden", "yellow");
            Console.WriteLine(mia.MakeVoice());
            Console.WriteLine(alex.MakeVoice());
        }
        

    }
}