using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharp_QUIZ
{
    internal class Question
    {
        public string question { get; set; }
        public List<string> answers { get; set; }  
        public char TrueAnswer { get; set; }
    }
}
