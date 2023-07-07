using FinalProjectCSharp_QUIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinalProjectCSharp_QUIZ
{
    internal class QuestionsReadJSON
    {
        #region Dict
        //public Dictionary<string,char> QuestionsDictionaryGeograthy = new Dictionary<string, char>()
        //{
        //    {"Which of the cities is the largest in terms of population ? " +
        //    "\na. Karachi" +
        //    "\nb. Lagos" +
        //    "\nc. Tokyo" +
        //    "\nd. Stanbulu",'c' },

        //    {"How many continents cross the equator ? " +
        //    "\na. 2" +
        //    "\nb. 3" +
        //    "\nc. 4" +
        //    "\nd. 6",'a' },

        //    {"How many continents ? " +
        //    "\na. 4" +
        //    "\nb. 5" +
        //    "\nc. 6" +
        //    "\nd. 8",'c' }
        //};
        //public Dictionary<string,char> QuestionsDictionaryHistory = new Dictionary<string, char>()
        //{
        //    {"When did the Great Patriotic War end ? " +
        //    "\na. 1954" +
        //    "\nb. 1945" ,'b' },

        //    {"The year of the collapse of the USSR ? " +
        //    "\na. 1991" +
        //    "\nb. 2008" ,'a' },

        //    {"When the accident at the Chernobyl nuclear power plant occurred ? " +
        //    "\na. 1980" +
        //    "\nb. 1986" +
        //    "\nc. 1999" ,'b' }
        //};
        #endregion

        // Создал список из типа данных вопросы(стринг вопрос , чар пправильный ответ, список стринг всех ответов)
        private List<Question> QuestionsGlobal = new List<Question>();

        // Geograthy
        public List<Question> FillGeograthy() {
            List<Question> QuestionsGeograty = new List<Question>();
            // Экземпляр одного вопроса(его вопрос,тру ответ,все ответы)
            //Question question = new Question();
            #region 1 question
            // --------------------------------------------------------------- Первый вопрос --------------------------------------------------------------- 
            //
            //// Вопрос заполнен
            //question.question = "Which of the cities is the largest in terms of population ? ";
            //
            //// Правильный ответ заполнен
            //question.TrueAnswer = 'a';
            //
            //// Создал список чтобы его заполнить в обьект
            //List<string> list = new() { "a. Karachi", "b.Lagos", "c.Tokyo", "d.Stanbulu" };
            //
            //// Ответы заполнены в список строк в обьект
            //question.answers = list;
            //
            //
            //// Добавил обьект в список обьектов
            //QuestionsGlobal.Add(question);
            //QuestionsGeograty.Add(question); 
            #endregion
            #region 2 question
            // --------------------------------------------------------------- Второй вопрос --------------------------------------------------------------- 
            //uestion question2 = new Question();
            //uestion2.question = "How many continents cross the equator ? ";
            //uestion2.TrueAnswer = 'a';
            //ist<string> list2 = new() { "a. 2", "b. 3", "c. 4", "d. 6" };
            //uestion2.answers = list2;
            //
            /// Добавил обьект в список обьектов
            //uestionsGlobal.Add(question2);
            //uestionsGeograty.Add(question2);
            #endregion
            #region 3 question
            // --------------------------------------------------------------- Третий вопрос --------------------------------------------------------------- 
            //Question question3 = new Question();
            //question3.question = "How many continents ? ";
            //question3.TrueAnswer = 'с';
            //List<string> list3 = new() { "a. 4", "b. 5", "c. 6", "d. 8" };
            //question3.answers = list3;
            //
            //// Добавил обьект в список обьектов
            //QuestionsGlobal.Add(question3);
            //QuestionsGeograty.Add(question3);
            #endregion
            // -------------------------------------------------------- JSON ------------------------------------------------------
            #region Write Json
            // var json = JsonSerializer.Serialize(QuestionsGeograty);
            // bool check = File.Exists("Geograthy.json");
            // if (!check)
            // {
            //     var i = File.Create("Geograthy.json");
            //     i.Close();
            // }
            // FileStream f = new FileStream("Geograthy.json", FileMode.Truncate);
            // StreamWriter s = new StreamWriter(f);
            // s.WriteLine(json);
            // s.Close();
            // f.Close();
            #endregion
            FileStream fs = new("Geograthy.json", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string jsonline = sr.ReadToEnd();
            if (jsonline != null)
            {
                QuestionsGeograty = JsonSerializer.Deserialize<List<Question>>(jsonline);
            }
            //Console.WriteLine(jsonline);
            sr.Close();
            fs.Close();

            return QuestionsGeograty;
        }
        // History
        public List<Question> FillHistory()
        {
            List<Question> QuestionsHistory = new List<Question>();
            // Экземпляр одного вопроса(его вопрос,тру ответ,все ответы)
            //Question question = new Question();
            #region 1 Question
            // --------------------------------------------------------------- Первый вопрос --------------------------------------------------------------- 

            // Вопрос заполнен
            //question.question = "When did the Great Patriotic War end ? ";

            // Правильный ответ заполнен
            //question.TrueAnswer = 'b';

            // Создал список чтобы его заполнить в обьект
            //List<string> list = new() { "a. 1954", "b. 1945" };
            // Ответы заполнены в список строк в обьект
            //question.answers = list;


            // Добавил обьект в список обьектов
            //QuestionsGlobal.Add(question);
            //QuestionsHistory.Add(question);
            #endregion 
            #region 2 Question
            // --------------------------------------------------------------- Второй вопрос --------------------------------------------------------------- 
            //Question question2 = new Question();
            //question2.question = "The year of the collapse of the USSR ? ";
            //question2.TrueAnswer = 'a';
            //List<string> list2 = new() { "a. 1991", "b. 2008" };
            //question.answers = list2;

            // Добавил обьект в список обьектов
            //QuestionsHistory.Add(question2);
            #endregion 
            #region 3 Question
            // --------------------------------------------------------------- Третий вопрос --------------------------------------------------------------- 
            //Question question3 = new Question();
            //question3.question = "When the accident at the Chernobyl nuclear power plant occurred ? ";
            //question3.TrueAnswer = 'b';
            //List<string> list3 = new() { "a. 1980", "b. 1986", "c. 1999" };
            //question.answers = list3;

            // Добавил обьект в список обьектов
            //QuestionsGlobal.Add(question3);
            //QuestionsHistory.Add(question3);

            //foreach (Question i in QuestionsGlobal)
            //{
            //Console.WriteLine(i.question);
            //}
            //Console.WriteLine("\n\n\n\n");
            #endregion
            // -------------------------------------------------------- JSON ------------------------------------------------------
            #region Write Json
            // -------------------------------------------------------- JSON ------------------------------------------------------
            // Write Json
            //var json = JsonSerializer.Serialize(QuestionsHistory);
            //bool check = File.Exists("History.json");
            //if (!check)
            //{
            //var i = File.Create("History.json");
            //i.Close();
            //}
            //FileStream f = new FileStream("History.json", FileMode.Truncate);
            //StreamWriter s = new StreamWriter(f);
            //s.WriteLine(json);
            //s.Close();
            //f.Close();
            #endregion
            // Read Json
            FileStream fs = new("History.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string jsonline = sr.ReadToEnd();
            if (jsonline != null)
            {
                QuestionsHistory = JsonSerializer.Deserialize<List<Question>>(jsonline);
            }
            //Console.WriteLine(jsonline);
            sr.Close();
            fs.Close();

            return QuestionsHistory;
        }
        // Biology
        public List<Question> FillBiology()
        {
            List<Question> QuestionsHistory = new List<Question>();
            // Read Json
            FileStream fs = new("Biology.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string jsonline = sr.ReadToEnd();
            if (jsonline != null)
            {
                QuestionsHistory = JsonSerializer.Deserialize<List<Question>>(jsonline);
            }
            //Console.WriteLine(jsonline);
            sr.Close();
            fs.Close();

            return QuestionsHistory;

        }
        // AllSubjects
        public List<Question> FillAll()
        {
            // -------------------------------------------------------- JSON ------------------------------------------------------

            #region Write Json
            // Write Json

            //var json = JsonSerializer.Serialize(QuestionsGlobal);
            //bool check = File.Exists("AllLessons.json");
            //if (!check)
            //{
            //    var i = File.Create("AllLessons.json");
            //    i.Close();
            //}
            //FileStream f = new FileStream("AllLessons.json", FileMode.Truncate);
            //StreamWriter s = new StreamWriter(f);
            //s.WriteLine(json);
            //s.Close();
            //f.Close();
            #endregion
            // Read Json
            FileStream fs = new("AllLessons.json", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string jsonline = sr.ReadToEnd();
            if (jsonline != null)
            {
                QuestionsGlobal = JsonSerializer.Deserialize<List<Question>>(jsonline);
            }
            //Console.WriteLine(jsonline);
            sr.Close();
            fs.Close();

            return QuestionsGlobal;
        }

    }
}




#region JSON
//// Создал список из типа данных вопросы(стринг вопрос , чар пправильный отве, список стринг всех ответов)
//List<Question> questions = new List<Question>();
//// Экземпляр одного вопроса(его вопрос,тру ответ,все ответы)
//Question question = new Question();


//// Вопрос заполнен
//question.question = "Which of the cities is the largest in terms of population ? ";

//// Правильный ответ заполнен
//question.TrueAnswer = 'a';

//// Создал список чтобы его заполнить в обьект
//List<string> list = new() { "a. Karachi", "b.Lagos", "c.Tokyo", "d.Stanbulu" };

//// Ответы заполнены в список строк в обьект
//question.answers = list;


//// Добавил обьект в список обьектов
//questions.Add(question);



//// ------------------ JSON ----------------
//var json = JsonSerializer.Serialize(questions);
//bool check = File.Exists("myfile.json");
//if (!check)
//{
//    var i = File.Create("myfile.json");
//    i.Close();
//}
//FileStream f = new FileStream("myfile.json", FileMode.Truncate);
//StreamWriter s = new StreamWriter(f);
//s.WriteLine(json);
//s.Close();
//f.Close();

//FileStream fs = new("myfile.json", FileMode.OpenOrCreate);
//StreamReader sr = new StreamReader(fs);
//string jsonline = sr.ReadToEnd();
//if (jsonline != null)
//{
//    questions = JsonSerializer.Deserialize<List<Question>>(jsonline);
//}
//Console.WriteLine(jsonline);
//sr.Close();
//fs.Close();


//// --------------------------------------------------------------- Второй вопрос --------------------------------------------------------------- 
//// Вопрос заполнен
//question.question = "How many continents cross the equator ? ";

//// Правильный ответ заполнен
//question.TrueAnswer = 'a';

//// Создал список чтобы его заполнить в обьект
//List<string> list1 = new() { "a. 2", "b. 3", "c. 4", "d. 6" };

//// Ответы заполнены в список строк в обьект
//question.answers = list;


//// Добавил обьект в список обьектов
//questions.Add(question);



//json = JsonSerializer.Serialize(questions);

//FileStream f1 = new FileStream("myfile.json", FileMode.Truncate);
//StreamWriter s1 = new StreamWriter(f1);
//s1.WriteLine(json);
//s1.Close();
//f1.Close();


//FileStream fs1 = new("myfile.json", FileMode.OpenOrCreate);
//StreamReader sr1 = new StreamReader(fs1);
//string jsonline1 = sr1.ReadToEnd();
//if (jsonline != null)
//{
//    questions = JsonSerializer.Deserialize<List<Question>>(jsonline1);
//}
//Console.WriteLine(jsonline1);
//sr1.Close();
//fs1.Close();
#endregion