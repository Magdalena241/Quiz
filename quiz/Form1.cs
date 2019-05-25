using quiz.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace quiz
{
    public partial class Form1 : Form
    {
        Quiz quiz;
        public Form1()
        {
            InitializeComponent();
            quiz = new Quiz();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Answer a1 = new Answer(answ1Box.Text, check1.Checked);
            Answer a2 = new Answer(answ2Box.Text, check2.Checked);
            Answer a3 = new Answer(answ3Box.Text, check3.Checked);
            Answer a4 = new Answer(answ4Box.Text, check4.Checked);
            List<Answer> a = new List<Answer>();
            a.Add(a1);
            a.Add(a2);
            a.Add(a3);
            a.Add(a4);
            Question quest = new Question(questionBox.Text, a);
            quiz.AddQuestion(quest);
            answ1Box.Clear();
            answ2Box.Clear();
            answ3Box.Clear();
            answ4Box.Clear();
            questionBox.Clear();
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
            questionBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            quiz.Title = titleBox.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml|*.xml";
            saveFileDialog1.Title = "Zapisz test";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                XmlSerializer writer = new XmlSerializer(typeof(Quiz));

                var path =  saveFileDialog1.FileName;
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, quiz);
                file.Close();

            }
        }
    }
}
