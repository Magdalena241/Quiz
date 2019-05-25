using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.data
{
    public class Question
    {
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string content, List<Answer> answers)
        {
            Content = content;
            Answers = answers;
        }

        public Question()
        {
            Content = "Pytanie";
            Answers = new List<Answer>();
        }
    }
}
