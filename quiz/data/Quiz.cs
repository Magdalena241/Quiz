using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.data
{
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public Quiz()
        {
            Title = "test";
            Questions = new List<Question>();
        }
        public Quiz(string title)
        {
            Title = title;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
