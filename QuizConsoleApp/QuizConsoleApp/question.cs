using System;

public class Question {
    int score = 0;
    public void Question1() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 1. How may sides are on a standard #2 pencil?");
        Console.ResetColor();
        
        Console.Write("[A] 4");
        Console.WriteLine("\t\t[B] 5");
        Console.Write("[C] 6");
        Console.WriteLine("\t\t[D] 7");
        CheckInput("c"); 
    }
    public void Question2() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 2. What did Babe Ruth wear underneath his baseball cap to help keep his head cool during games?");
        Console.ResetColor();

        Console.Write("[A] Damp cloth");
        Console.WriteLine("\t\t\t[B] Cabbage leaf");
        Console.Write("[C] Homemade sweat band");
        Console.WriteLine("\t\t[D] Cucumber slices");
        CheckInput("b");
    }

    public void Question3() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 3. Like your fingerprints, you also have a unique");
        Console.ResetColor();

        Console.Write("[A] Tongue print");
        Console.WriteLine("\t\t[B] Toe print");
        Console.Write("[C] Hair follicle");
        Console.WriteLine("\t\t[D] Fingernail texture");
        CheckInput("a");
    }

    public void Question4() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 4. Every year, over 8,800 people injure themselves with what seemingly harmless, tiny object?");
        Console.ResetColor();

        Console.Write("[A] Pencil");
        Console.WriteLine("\t\t[B] Eraser");
        Console.Write("[C] Toothpick");
        Console.WriteLine("\t\t[D] Paperclip");
        CheckInput("c");
    }

    public void Question5() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 5. 2^2^2 = ");
        Console.ResetColor();

        Console.Write("[A] 8");
        Console.WriteLine("\t\t[B] 16");
        Console.Write("[C] 32");
        Console.WriteLine("\t\t[D] 64");
        CheckInput("b");
    }

    public void Question6() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 6. How many US states begin with the letter T?");
        Console.ResetColor();

        Console.Write("[A] 1");
        Console.WriteLine("\t\t[B] 2");
        Console.Write("[C] 3");
        Console.WriteLine("\t\t[D] 4");
        CheckInput("b");
    }

    public void Question7() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 7. Water has a density of");
        Console.ResetColor();

        Console.Write("[A] 1 g/cm^3");
        Console.WriteLine("\t\t[B] 1 kg/L");
        Console.Write("[C] 1 lb/L");
        Console.WriteLine("\t\t[D] 1 g/L");
        CheckInput("a");;
    }

    public void Question8() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 8. The 5th planet from the sun is");
        Console.ResetColor();

        Console.Write("[A] Earth");
        Console.WriteLine("\t\t[B] Saturn");
        Console.Write("[C] Neptune");
        Console.WriteLine("\t\t[D] Jupiter");
        CheckInput("d");
    }

    public void Question9() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 9. Which fast food chain uses the slogan \"I'm lovin' it\"?");
        Console.ResetColor();

        Console.Write("[A] Jollibee");
        Console.WriteLine("\t\t[B] Wendy's");
        Console.Write("[C] Mcdonald's");
        Console.WriteLine("\t\t[D] Taco Bell");
        CheckInput("c");
    }

    public void Question10() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 10. What color are the Smurfs?");
        Console.ResetColor();

        Console.Write("[A] Green");
        Console.WriteLine("\t\t[B] Purple");
        Console.Write("[C] Blue");
        Console.WriteLine("\t\t[D] Red");
        CheckInput("c");
    }

    public void Question11() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 11. What do you call a baby goat?");
        Console.ResetColor();

        Console.Write("[A] a baby goat");
        Console.WriteLine("\t\t[B] a kid");
        Console.Write("[C] a joey");
        Console.WriteLine("\t\t[D] a calf");
        CheckInput("b");;
    }

    public void Question12() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 12.  What kind of dog is Snoopy from the comic Peanuts?");
        Console.ResetColor();

        Console.Write("[A] Golden Retriever");
        Console.WriteLine("\t\t[B] Weiner Dog");
        Console.Write("[C] Beagle");
        Console.WriteLine("\t\t\t[D] Poodle");
        CheckInput("c");
    }

    public void Question13() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 13.  Which two countries do not sell Coca-cola?");
        Console.ResetColor();

        Console.Write("[A] Russia and China");
        Console.WriteLine("\t\t[B] China and North Korea");
        Console.Write("[C] Russia and North Korea");
        Console.WriteLine("\t[D] North Korea and Cuba");
        CheckInput("d");
    }

    public void Question14() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 14.  Which are the three primary colors?");
        Console.ResetColor();

        Console.Write("[A] red, green, and blue");
        Console.WriteLine("\t\t[B] red, yellow, and blue");
        Console.Write("[C] yellow, green and red");
        Console.WriteLine("\t\t[D] orange, brown and green");
        CheckInput("b");
    }

    public void Question15() {
        DisplayScore();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Question 15.  Cruella De Vil is from what movie?");
        Console.ResetColor();

        Console.Write("[A] Beauty and the Beast");
        Console.WriteLine("\t[B] Alice in Wonderland");
        Console.Write("[C] Lion King");
        Console.WriteLine("\t\t\t[D] 101 Dalmatians");
        CheckInput("d");;
    }

    public void CheckInput (string key) {
        Boolean validInput = false;
        do {
            Console.Write("Enter Input: ");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == 'a'.ToString() || answer == 'b'.ToString() || answer == 'c'.ToString() || answer == 'd'.ToString()) {
                validInput = true;
                CheckAnswer(answer, key);
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter one of the choices.");
                Console.ResetColor();
            }
        } while (!validInput);
    }

    public void CheckAnswer (string input, string corrAnswer){
        if (input.ToLower() == corrAnswer) CorrectAnswer();
        else WrongAnswer();
    }

    public void CorrectAnswer() {
        score += 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your answer is correct! +1");
        Console.ResetColor();
    }

    public void WrongAnswer() {
        score -= 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry, your answer is incorect. -1");
        Console.ResetColor();
    }

    public int DisplayScore() {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nScore: {0}", score);
        Console.ResetColor();
        return score;
    }
}