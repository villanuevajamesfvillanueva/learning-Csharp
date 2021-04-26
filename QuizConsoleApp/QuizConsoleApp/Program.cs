using System;

namespace HOA4_QuizProgram
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            Question Game = new Question();
            int finalScore;

            // Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("QUIZ TIME!");
            Console.ResetColor();
            Console.WriteLine("Please answer the following questions");
            Console.WriteLine("Answer correctly, you get a point");
            Console.WriteLine("Answer wrong, you lose a point\n");
            Console.Write("Let us begin! (press any key to continue) ");
            Console.ReadKey();

            //displaying questions
            // Console.Clear();
            Game.Question1();

            // Console.Clear();
            Game.Question2();

            // Console.Clear();
            Game.Question3();

            // Console.Clear();
            Game.Question4();

            // Console.Clear();
            Game.Question5();

            // Console.Clear();
            Game.Question6();

            // Console.Clear();
            Game.Question7();

            // Console.Clear();
            Game.Question8();

            // Console.Clear();
            Game.Question9();

            // Console.Clear();
            Game.Question10();

            // Console.Clear();
            Game.Question11();

            // Console.Clear();
            Game.Question12();

            // Console.Clear();
            Game.Question13();

            // Console.Clear();
            Game.Question14();

            // Console.Clear();
            Game.Question15();

            Console.Write("\nGame over! Your Final ");
            finalScore = Game.DisplayScore();
            if (finalScore == 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wow! You are a legend!");
                Console.ResetColor();
            }

            else if (finalScore >= 12)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nice one lodi!");
                Console.ResetColor();
            }

            else if (finalScore >= 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good job!");
                Console.ResetColor();
            }

            else if (finalScore >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thanks for trying.");
                Console.ResetColor();
            }

            else if (finalScore >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It's okay broo. Maybe trivia quizzes aren't your type.");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No comment.");
                Console.ResetColor();
            }
        }
    }
}
