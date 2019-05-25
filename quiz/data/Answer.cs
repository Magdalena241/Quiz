using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.data
{
    public class Answer
    {
        public string Content { get; set; }
        public bool Correct { get; set; }


        public Answer(string content, bool correct)
        {
            Content = content;
            Correct = correct;
        }
        public Answer()
        {
            Content = "Odpowiedz";
            Correct = false;
        }
    }
}
