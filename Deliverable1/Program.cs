using System;

namespace Deliverable1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string tab = "\t\t\t\t\t";
            string asterisk = "**********";
            bool start = false;

            Console.WriteLine($"{tab}{asterisk} Welcome to {asterisk}\n");
            Console.WriteLine($"{tab}||||||||");
            Console.WriteLine($"{tab}||");
            Console.WriteLine($"{tab}||");
            Console.WriteLine($"{tab}|||||| ANTASY");
            Console.WriteLine($"{tab}||");
            Console.WriteLine($"{tab}||       |||||||");
            Console.WriteLine($"{tab}||       ||    ||");
            Console.WriteLine($"{tab}         ||    ||");
            Console.WriteLine($"{tab}         ||||||| RAWL");
            Console.WriteLine($"{tab}         ||    ||");
            Console.WriteLine($"{tab}         ||    ||");
            Console.WriteLine($"{tab}         |||||||\n");
            Console.WriteLine($"{tab}  [A] START");
            Console.WriteLine($"{tab}  [B] EXIT\n\n");

            //startgame prompt
            while (!start) {
                Console.Write("Enter your choice: ");
                string startMenuChoice = Console.ReadLine();
                if (startMenuChoice == "A" || startMenuChoice == "a") {
                    Console.WriteLine("Game initiating...");
                    start = true;
                }
                else if (startMenuChoice == "B" || startMenuChoice == "b") {
                    Console.WriteLine("Exiting game... Goodbye!");
                    Environment.Exit(0);
                }
                else {
                    Console.WriteLine("Invalid choice! Please choose between A or B.");
                }
            }

            //Console.WriteLine("Loading Character Select Screen...");
            Console.WriteLine("Loading Battle Screen...");
        
            int princessHP = 100;
            int wizardHP = 50;
            Console.WriteLine($"\n\nPrincess HP: {princessHP}");
            Console.WriteLine($"Wizard HP: {wizardHP}\n");
            Console.WriteLine("IT IS YOUR TURN PRINCESS!");

            bool attack = false;
            while (!attack) {
                Console.WriteLine("\nAttacks: ");
                Console.WriteLine("[A] Hammer Hit (15 DMG)");
                Console.WriteLine("[B] Princess Smash! (50 DMG, Use only at HP < 50)");
                Console.WriteLine("[C] Blessing (+30HP to Princess)\n");
                Console.Write("Enter Attack: ");
                string princessAttack = Console.ReadLine();
                if (princessAttack == "A" || princessAttack == "a") {
                    Console.WriteLine("Princess used Hammer Hit!");
                    wizardHP -= 15;
                    attack = true;
                }
                else if (princessAttack == "B" || princessAttack == "b") {
                    if (princessHP < 50) {
                        Console.WriteLine("Princess used Princess Smash!");
                        wizardHP -= 50;
                        attack = true;
                    }
                    else {
                        Console.WriteLine("Can't use Princess Smash! Please pick a different attack.");
                    }
                    
                }
                else if (princessAttack == "C" || princessAttack == "c") {
                    Console.WriteLine("Princess used Blessing!");
                    princessHP += 30;
                    attack = true;
                }
                else {
                    Console.WriteLine("Invalid choice! Please choose between A, B or C.");
                }
            }


            Console.WriteLine($"\n\nPrincess HP: {princessHP}");
            Console.WriteLine($"Wizard HP: {wizardHP}\n");
            Console.WriteLine("IT IS YOUR TURN WIZARD!\n");
            attack = false;
             
            while (!attack) {
                Console.WriteLine("\nAttacks: ");
                Console.WriteLine("[A] Siphon (10 DMG, +10 HP to Wizard)");
                Console.WriteLine("[B] Dark Bolt! (100 DMG, Use only at HP < 25)");
                Console.WriteLine("[C] Potion (+15HP to Wizard)\n");
                Console.Write("Enter Attack: ");
                string wizardAttack = Console.ReadLine();
                if (wizardAttack == "A" || wizardAttack == "a") {
                    Console.WriteLine("Wizard used Siphon!");
                    princessHP -= 10;
                    wizardHP += 10;
                    attack = true;
                  
                }
                else if (wizardAttack == "B" || wizardAttack == "b") {
                    if (wizardHP < 25) {
                        Console.WriteLine("Wizard used Dark Bolt!");
                        princessHP -= 100;
                        attack = true;
                     
                    }
                    else {
                        Console.WriteLine("Can't use Dark Bolt! Please pick a different attack.");
                    }
                    
                }
                else if (wizardAttack == "C" || wizardAttack == "c") {
                    Console.WriteLine("Wizard used Potion!");
                    wizardHP += 15;
                    attack = true; 
                }
                else {
                    Console.WriteLine("Invalid choice! Please choose between A, B or C.");
                }
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"\n\nPrincess HP: {princessHP}");
            Console.WriteLine($"Wizard HP: {wizardHP}\n");
            Console.WriteLine("Game Over...");
        }
    }
}
