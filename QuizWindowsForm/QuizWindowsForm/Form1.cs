using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizWindowsForm
{
    public partial class Form1 : Form
    {
        //game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                labelChecker.Text = "Correct!";
                labelChecker.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                labelChecker.Text = "Incorrect";
                labelChecker.ForeColor = System.Drawing.Color.Red;
            }

            if (questionNumber == totalQuestions)
            {
                MessageBox.Show("You got " + score + "/" + totalQuestions + Environment.NewLine +
                    "Click OK to play again");

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            Check();
        }

        private async Task Check()
        {
            await Task.Delay(1200);
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    labelQuestion.Text = "How many horns did a triceratops have?";
                    labelChecker.Text = "";
                    button1.Text = "2";
                    button2.Text = "3";
                    button3.Text = "4";
                    button4.Text = "5";
                    correctAnswer = 2;
                    break;

                case 2:
                    labelQuestion.Text = "What does the word dinosaur mean?";
                    labelChecker.Text = "";
                    button1.Text = "Mighty lizard";
                    button2.Text = "Scary lizard";
                    button3.Text = "Terrible lizard";
                    button4.Text = "Gojira";
                    correctAnswer = 3;
                    break;

                case 3:
                    labelQuestion.Text = "What is the study of fossils called?";
                    labelChecker.Text = "";
                    button1.Text = "Paleontology";
                    button2.Text = "Geology";
                    button3.Text = "Meteorology";
                    button4.Text = "Astronomy";
                    correctAnswer = 1;
                    break;

                case 4:
                    labelQuestion.Text = "When did dinosaurs go extinct?";
                    labelChecker.Text = "";
                    button1.Text = "Around 65 years ago";
                    button2.Text = "Around 65 thousand years ago";
                    button3.Text = "Around 65 million years ago";
                    button4.Text = "Around 65 billion years ago";
                    correctAnswer = 3;
                    break;

                case 5:
                    labelQuestion.Text = "Why did dinosaurs go extinct?";
                    labelChecker.Text = "";
                    button1.Text = "They left the earth aboard an alien spacecraft";
                    button2.Text = "They were killed by an asteroid";
                    button3.Text = "They were hunted to extinction";
                    button4.Text = "Because of overpopulation";
                    correctAnswer = 2;
                    break;

                case 6:
                    labelQuestion.Text = "True or false: birds evolved from dinosaurs";
                    labelChecker.Text = "";
                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "I don't know";
                    button4.Text = "I'll pass";
                    correctAnswer = 1;
                    break;

                case 7:
                    labelQuestion.Text = "Which dinosaur had a giraffe-like neck?";
                    labelChecker.Text = "";
                    button1.Text = "Stegosaurus";
                    button2.Text = "Velociraptor";
                    button3.Text = "T-rex";
                    button4.Text = "Brachiosaurus";
                    correctAnswer = 4;
                    break;

                case 8:
                    labelQuestion.Text = "Which dinosaur's name means 'fast thief'?";
                    labelChecker.Text = "";
                    button1.Text = "Stegosaurus";
                    button2.Text = "Velociraptor";
                    button3.Text = "T-rex";
                    button4.Text = "Brachiosaurus";
                    correctAnswer = 2;
                    break;

                case 9:
                    labelQuestion.Text = "HHow many years did dinosaurs roam the Earth?";
                    labelChecker.Text = "";
                    button1.Text = "160";
                    button2.Text = "160 thousand";
                    button3.Text = "160 million";
                    button4.Text = "160 billion";
                    correctAnswer = 2;
                    break;

                case 10:
                    labelQuestion.Text = "During which period did the T-Rex live?";
                    labelChecker.Text = "";
                    button1.Text = "Cretaceous";
                    button2.Text = "Jurassic";
                    button3.Text = "Triassic";
                    button4.Text = "1990s";
                    correctAnswer = 1;
                    break;


            }
        }
    }
}
