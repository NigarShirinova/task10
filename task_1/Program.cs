
using System;
using task_1;

namespace Lesson
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            KeyInput:  Console.WriteLine("Write key");
            string key = Console.ReadLine();
            switch ( key )
            {
                case "basic":
                    DocumentProgram basic = new DocumentProgram();
                    basic.OpenDocument();
                    basic.EditDocument();
                    basic.SaveDocument();
                    break;
                case "pro":
                    ProDocumentProgram pro = new ProDocumentProgram();
                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();
                    break;
                case "expert":
                   ExpertDocumentProgram expert = new ExpertDocumentProgram();
                    expert.OpenDocument();                        
                    expert.EditDocument();
                    expert.SaveDocument();
                    break;

                default:
                    goto KeyInput;
                    
            }

            



        }


    }
}