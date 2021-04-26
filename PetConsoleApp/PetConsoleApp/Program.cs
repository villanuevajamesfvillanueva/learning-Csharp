using System;

namespace PetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double health = 100;
            double happiness = 100;
            string move;

            Console.WriteLine("\nHealth: " + health);
            Console.WriteLine("Happiness: " + happiness);

            while (happiness > 0 && health > 0)
            {
                Console.WriteLine("\nChoose a move: ");
                Console.WriteLine("[A] Bathe Pet");
                Console.WriteLine("[B] Play Extreme Fetch");
                Console.WriteLine("[C] Go to Vet");
                move = Console.ReadLine();

                if (move == "A" || move == "a")
                {
                    Console.WriteLine("\nYou chose [A] Bathe Pet");
                    happiness -= 25;
                    health += 10;
                    // Console.WriteLine("Health: " + health);
                    // Console.WriteLine("Happiness: " + happiness);
                }
                else if (move == "B" || move == "b")
                {
                    Console.WriteLine("\nYou chose[B] Play Extreme Fetch");
                    happiness += 15;
                    health -= 25;
                    // Console.WriteLine("Health: " + health);
                    // Console.WriteLine("Happiness: " + happiness);
                }
                else if (move == "C" || move == "c")
                {
                    Console.WriteLine("\nYou chose [C] Go to Vet");
                    happiness -= 40;
                    health += 20;
                    // Console.WriteLine("Health: " + health);
                    // Console.WriteLine("Happiness: " + happiness);
                }
                else
                {
                    Console.WriteLine("\nPlease input only A, B, or C.\n");
                }
            }


            Console.WriteLine("\nGame Over.");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Happiness: " + happiness);
        }
    }
}
