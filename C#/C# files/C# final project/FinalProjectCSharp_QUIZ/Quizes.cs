using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp_QUIZ
{
    internal class Quizes
    {
        private Random random = new Random();
        private QuestionsReadJSON CreateJson = new();
        private List<Question> ListQuestionsGlobal = new();
        private int Counter = 0;
        // History
        public void HistoryQuiz() {
            List<Question> ListQuestionsHistory = new();
            // Get list of questions
            ListQuestionsHistory = CreateJson.FillHistory();

            int RndIndex = random.Next(0, ListQuestionsHistory.Count);
            Console.WriteLine($"{ListQuestionsHistory[RndIndex].question}\n");
            int len = ListQuestionsHistory[RndIndex].answers.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{ListQuestionsHistory[RndIndex].answers[i]}");
            }
            Console.WriteLine("Choose an answer:");
            char choice = char.Parse(Console.ReadLine());
            if(choice == ListQuestionsHistory[RndIndex].TrueAnswer)
            {
                Console.WriteLine("Good!");
            }
            else Console.WriteLine("Wrong ");
            Thread.Sleep(2000);
            System.Console.Clear(); 
        }
        // Geograthy
        public void GeograthyQuiz() {
            List<Question> ListQuestionsGeograthy = new();
            // Get list of questions
            ListQuestionsGeograthy = CreateJson.FillGeograthy();

            int RndIndex = random.Next(0, ListQuestionsGeograthy.Count);
            Console.WriteLine($"{ListQuestionsGeograthy[RndIndex].question}\n");
            int len = ListQuestionsGeograthy[RndIndex].answers.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{ListQuestionsGeograthy[RndIndex].answers[i]}");
            }
            Console.WriteLine("Choose an answer:");
            char choice = char.Parse(Console.ReadLine());
            if (choice == ListQuestionsGeograthy[RndIndex].TrueAnswer)
            {
                Console.WriteLine("Good!");
            }
            else Console.WriteLine("Wrong ");
            Thread.Sleep(2000);
            System.Console.Clear();
        }
        // Biology
        public void BiologyQuiz() {
            List<Question> ListQuestionsBiology = new();
            // Get list of questions
            ListQuestionsBiology = CreateJson.FillBiology();

            int RndIndex = random.Next(0, ListQuestionsBiology.Count);
            Console.WriteLine($"{ListQuestionsBiology[RndIndex].question}\n");
            int len = ListQuestionsBiology[RndIndex].answers.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{ListQuestionsBiology[RndIndex].answers[i]}");
            }
            Console.WriteLine("Choose an answer:");
            char choice = char.Parse(Console.ReadLine());
            if (choice == ListQuestionsBiology[RndIndex].TrueAnswer)
            {
                Console.WriteLine("Good!");
            }
            else Console.WriteLine("Wrong ");
            Thread.Sleep(2000);
            System.Console.Clear();
        }
        // AllSubjects
        public void AllSubjects()
        {
            List<Question> ListQuestionsAll = new();
            // Get list of questions
            ListQuestionsAll = CreateJson.FillAll();

            int RndIndex = random.Next(0, ListQuestionsAll.Count);
            Console.WriteLine($"{ListQuestionsAll[RndIndex].question}\n");
            int len = ListQuestionsAll[RndIndex].answers.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{ListQuestionsAll[RndIndex].answers[i]}");
            }
            Console.WriteLine("Choose an answer:");
            char choice = char.Parse(Console.ReadLine());
            if (choice == ListQuestionsAll[RndIndex].TrueAnswer)
            {
                Console.WriteLine("Good!");
            }
            else Console.WriteLine("Wrong ");
            Thread.Sleep(2000);
            System.Console.Clear();
        }
    }
}
