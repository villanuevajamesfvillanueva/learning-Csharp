using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace TrexQuizRunner
{
    public partial class gameScreen : Form
    {
        //trex mechanics variables
        bool jumping = false, isGameOver = false;
        int position, jumpSpeed, force = 12, score = 0, obstacleSpeed = 9;
        Random rand = new Random();

        //quiz variables
        int correctAnswer, questionNumber = 1, totalQuestions = 10;

        public gameScreen()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0) jumping = false;

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }

            else jumpSpeed = 12;

            if (trex.Top > 335 && jumping == false)
            {
                //trex y-coord correction when jump is finished
                force = 12;
                trex.Top = 336;
                jumpSpeed = 0;
            }

            //for movement, respawn of obstacles, and collision check
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < 0)
                    {
                        //score updates once obstacles get to the left end of the screen
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score += 100;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        playErrorSound();
                        clearQuestion();
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        txtScore.Text += " \n\nPress R to restart the game";
                        isGameOver = true;
                    }
                }
            }

            //changing difficulty level
            if (score >= 1000) obstacleSpeed = 9 + score / 1000;
            if (score >= 10000) obstacleSpeed = 20;

            //showing quiz questions
            if (score % 800 == 0 && score > 0 && questionNumber <= totalQuestions)
            {
                playQuestionSound();
                gameTimer.Stop();
                askQuestion(questionNumber);
                questionNumber++;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                playJumpSound();
                jumping = true;
            } 
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && isGameOver == true) GameReset();
            if (jumping) jumping = false;
        }

        private void GameReset()
        {
            //default game values
            clearQuestion();
            questionNumber = 1;

            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 9;
            txtScore.Text = "Score " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 336;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //random value generated for the position of the obstacles at the start of the game
                    //lets the player prepare for the first couple of obstacles
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Label)sender;
            int labelTag = Convert.ToInt32(senderObject.Tag);

            if (labelTag == correctAnswer)
            {
                playCorrectSound();
                score += 1000;
                clearQuestion();
                gameTimer.Start();
            }

            else
            {
                playIncorrectSound();
                clearQuestion();
                score -= 500;
                gameTimer.Start();
            }
        }

        private void clearQuestion()
        {

            labelQuestion.Text = "";
            choice1.Text = "";
            choice2.Text = "";
            choice3.Text = "";
            choice4.Text = "";

            //hide question and choices to disable clicks when not showing
            labelQuestion.Visible = false;
            choice1.Visible = false;
            choice2.Visible = false;
            choice3.Visible = false;
            choice4.Visible = false;
        }


        private void askQuestion(int qnum)
        {
            //showing question and choices
            labelQuestion.Visible = true;
            choice1.Visible = true;
            choice2.Visible = true;
            choice3.Visible = true;
            choice4.Visible = true;

            switch (qnum)
            {
                case 1:
                    labelQuestion.Text = "How many horns did a triceratops have?";
                    choice1.Text = "2";
                    choice2.Text = "3";
                    choice3.Text = "4";
                    choice4.Text = "5";
                    correctAnswer = 2;
                    break;

                case 2:
                    labelQuestion.Text = "What does the word dinosaur mean?";
                    choice1.Text = "Mighty lizard";
                    choice2.Text = "Scary lizard";
                    choice3.Text = "Terrible lizard";
                    choice4.Text = "Gojira";
                    correctAnswer = 3;
                    break;

                case 3:
                    labelQuestion.Text = "What is the study of fossils called?";
                    choice1.Text = "Paleontology";
                    choice2.Text = "Geology";
                    choice3.Text = "Meteorology";
                    choice4.Text = "Astronomy";
                    correctAnswer = 1;
                    break;

                case 4:
                    labelQuestion.Text = "When did dinosaurs go extinct?";
                    choice1.Text = "Around 65 years ago";
                    choice2.Text = "Around 65 thousand years ago";
                    choice3.Text = "Around 65 million years ago";
                    choice4.Text = "Around 65 billion years ago";
                    correctAnswer = 3;
                    break;

                case 5:
                    labelQuestion.Text = "Why did dinosaurs go extinct?";
                    choice1.Text = "They left the earth aboard an alien spacecraft";
                    choice2.Text = "They were killed by an asteroid";
                    choice3.Text = "They were hunted to extinction";
                    choice4.Text = "Because of overpopulation";
                    correctAnswer = 2;
                    break;

                case 6:
                    labelQuestion.Text = "True or false: birds evolved from dinosaurs";
                    choice1.Text = "True";
                    choice2.Text = "False";
                    choice3.Text = "I don't know";
                    choice4.Text = "I'll pass";
                    correctAnswer = 1;
                    break;

                case 7:
                    labelQuestion.Text = "Which dinosaur had a giraffe-like neck?";
                    choice1.Text = "Stegosaurus";
                    choice2.Text = "Velociraptor";
                    choice3.Text = "T-rex";
                    choice4.Text = "Brachiosaurus";
                    correctAnswer = 4;
                    break;

                case 8:
                    labelQuestion.Text = "Which dinosaur's name means 'fast thief'?";
                    choice1.Text = "Stegosaurus";
                    choice2.Text = "Velociraptor";
                    choice3.Text = "T-rex";
                    choice4.Text = "Brachiosaurus";
                    correctAnswer = 2;
                    break;

                case 9:
                    labelQuestion.Text = "How many years did dinosaurs roam the Earth?";
                    choice1.Text = "175";
                    choice2.Text = "175 thousand";
                    choice3.Text = "175 million";
                    choice4.Text = "175 billion";
                    correctAnswer = 3;
                    break;

                case 10:
                    labelQuestion.Text = "(Final question) During which period did the T-Rex live?";
                    choice1.Text = "Cretaceous";
                    choice2.Text = "Jurassic";
                    choice3.Text = "Triassic";
                    choice4.Text = "1990s";
                    correctAnswer = 1;
                    break;
            }
        }


        //game sounds
        private void playJumpSound()
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\jump.wav");
            sound.Play();
        }

        private void playErrorSound()
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\error.wav");
            sound.Play();
        }

        private void playQuestionSound()
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\question.wav");
            sound.Play();
        }

        private void playCorrectSound()
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\correct.wav");
            sound.Play();
        }

        private void playIncorrectSound()
        {
            SoundPlayer sound = new SoundPlayer(@".\Resources\incorrect.wav");
            sound.Play();
        }

        
    }
}
