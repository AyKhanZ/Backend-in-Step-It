using FinalProjectCSharp_QUIZ;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static Program.Program;


namespace Program
{
    public static class Program
    {
       
        public static void Main()
        {
            //Menus registration = new(); 
            //registration.RegistrationOrLoginMenu();
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            Quizes a = new();
            //a.HistoryQuiz();
            //a.GeograthyQuiz();
            while (true)
            {
                a.BiologyQuiz();
            }
            //a.AllSubjects();


        }
    }
    
}


