using System;

namespace Fantasy_Brawl
{
    class Program
    {
        static void Main(string[] args)
        {

                string tab = "\t\t\t";
                string welcome = @"

██     ██ ███████ ██       ██████  ██████  ███    ███ ███████     ████████  ██████  
██     ██ ██      ██      ██      ██    ██ ████  ████ ██             ██    ██    ██ 
██  █  ██ █████   ██      ██      ██    ██ ██ ████ ██ █████          ██    ██    ██ 
██ ███ ██ ██      ██      ██      ██    ██ ██  ██  ██ ██             ██    ██    ██ 
 ███ ███  ███████ ███████  ██████  ██████  ██      ██ ███████        ██     ██████                                                             
";
                string gameTitle = @"
   ▄████████    ▄████████ ███▄▄▄▄       ███        ▄████████    ▄████████ ▄██   ▄        ▀█████████▄     ▄████████    ▄████████  ▄█     █▄   ▄█       
  ███    ███   ███    ███ ███▀▀▀██▄ ▀█████████▄   ███    ███   ███    ███ ███   ██▄        ███    ███   ███    ███   ███    ███ ███     ███ ███       
  ███    █▀    ███    ███ ███   ███    ▀███▀▀██   ███    ███   ███    █▀  ███▄▄▄███        ███    ███   ███    ███   ███    ███ ███     ███ ███       
 ▄███▄▄▄       ███    ███ ███   ███     ███   ▀   ███    ███   ███        ▀▀▀▀▀▀███       ▄███▄▄▄██▀   ▄███▄▄▄▄██▀   ███    ███ ███     ███ ███       
▀▀███▀▀▀     ▀███████████ ███   ███     ███     ▀███████████ ▀███████████ ▄██   ███      ▀▀███▀▀▀██▄  ▀▀███▀▀▀▀▀   ▀███████████ ███     ███ ███       
  ███          ███    ███ ███   ███     ███       ███    ███          ███ ███   ███        ███    ██▄ ▀███████████   ███    ███ ███     ███ ███       
  ███          ███    ███ ███   ███     ███       ███    ███    ▄█    ███ ███   ███        ███    ███   ███    ███   ███    ███ ███ ▄█▄ ███ ███▌    ▄ 
  ███          ███    █▀   ▀█   █▀     ▄████▀     ███    █▀   ▄████████▀   ▀█████▀       ▄█████████▀    ███    ███   ███    █▀   ▀███▀███▀  █████▄▄██ 
                                                                                                        ███    ███                          ▀         
                                                                                                                                                      
            ";

                string wand = @"
                                  @@@               
              %*     @@  @@@     @@@@@  
            *****#   @@ %@  (@@&    @@/ 
              #      @@    @@@      @#  
                  @@@&             @&   
                @@                  @@  
                @@@@@                *@@
                  @@@ *@@      @@@@@@@@@
               @@@    @@@    @@&        
             @@@    @@# @@,@@@     *    
          @@@    @@@                    
        @@@    @@#            **#*,     
     @@@    @@@                **       
   @@@    @@#                           
 @@    @@@                              
@@#  @@#                                
 ****
            ";

                string sword = @"
                                                 
                          @@@@@@@@@@@@@
                        @@@#         @@
                      @@@            @@
                    @@@     ***     .@@ 
                  @@@     ****      @@@ 
                @@@    ****     *@@@@   
             (@@@    ****    %@@@@      
           @@@@   ****    .@@@@         
      *%%@@@@@  ****   (@@@@            
      %%%%  *@@**   @@@@@               
       *%%%%   @@@@@@&                  
     %%%%  %%%%  @@@                    
  *%%%%  %%*  %%%%%*                    
%%    %%*                             
*%%%**                              
 
            ";
                string shield = @"
                   ..                   
               @@@****@@@@              
         @@@@**************&@@@@        
   @@@%********%@@@(@(@@@/********@@@#  
   @@****@@@@%,,,,,,%,,,,,,@@@@%****@#  
   @@***@*,,,,,,,,,,,,,,,,,,,,,@@***@#  
   @@(@*@*,,,,,,,,@@&@&,,,,,,,,@@/@*@#  
   @@***@#,,,,,(@@(((((@@,,,,,,@@***@#  
   @@***@@,,,@@((((@@@((((@@,,,@@***@#  
    @%***@%@@((((@@,,,@@((((@@@@*(*@@   
    %@(***@&((@@#,,,,,,,@@#((@@***@@    
      @%*&*@@@,,,,,,,,,,,,,@@(((*@@     
       @@****@@,,,,,@,,,,@@#***(@@      
         @@*****@@,,@,,@@****%@@        
           @@@*****@@@*****@@@          
               @@@*****(@@@              
		              @*.*@
 		   ";

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(welcome);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(gameTitle);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{tab}[A] START");
                Console.WriteLine($"{tab}[B] EXIT\n\n");


                //startgame prompt
                bool start = false;
                while (!start)
                {
                    Console.Write("Enter your choice: ");
                    string startMenuChoice = Console.ReadLine();
                    if (startMenuChoice == "A" || startMenuChoice == "a")
                    {
                        Console.WriteLine("Game initiating...");
                        start = true;
                    }
                    else if (startMenuChoice == "B" || startMenuChoice == "b")
                    {
                        Console.WriteLine("Exiting game... Goodbye!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please choose between A or B.");
                    }
                }

                Console.WriteLine("Loading Character Select Screen...");
                Console.ResetColor();
                Console.WriteLine(@"
                                  @@@                                                                                                        ..                   
                          %*     @@  @@@     @@@@@                                                                                       @@@****@@@@              
                        *****#   @@ %@  (@@&    @@/                                       @@@@@@@@@@@@@                            @@@@**************&@@@@        
                          #      @@    @@@      @#                                      @@@#         @@                      @@@%********%@@@(@(@@@/********@@@#  
                              @@@&             @&                                     @@@            @@                      @@****@@@@%,,,,,,%,,,,,,@@@@%****@#  
                            @@                  @@                                  @@@     ***     .@@                      @@***@*,,,,,,,,,,,,,,,,,,,,,@@***@#  
                            @@@@@                *@@                              @@@     ****      @@@                      @@(@*@*,,,,,,,,@@&@&,,,,,,,,@@/@*@#  
                              @@@ *@@      @@@@@@@@@                            @@@    ****     *@@@@                        @@***@#,,,,,(@@(((((@@,,,,,,@@***@#  
                           @@@    @@@    @@&                                 (@@@    ****    %@@@@                           @@***@@,,,@@((((@@@((((@@,,,@@***@#  
                         @@@    @@# @@ @@@     *                           @@@@   ****    .@@@@                               @%***@%@@((((@@,,,@@((((@@@@*(*@@   
                      @@@    @@@      *                               *%%@@@@@  ****   (@@@@                                  %@(***@&((@@#,,,,,,,@@#((@@***@@    
                    @@@    @@#            **#*,                       %%%%  *@@**   @@@@@                                       @%*&*@@@,,,,,,,,,,,,,@@(((*@@     
                  @@@    @@@                **                         *%%%%   @@@@@@&                                           @@****@@,,,,,@,,,,@@#***(@@      
                @@@    @@#                                           %%%%  %%%%  @@@                                               @@*****@@,,@,,@@****%@@        
              @@    @@@                                           *%%%%  %%*  %%%%%*                                                 @@@*****@@@*****@@@          
             @@#  @@#                                          %%    %%*                                                                 @@@*****(@@@              
              ****                                             *%%%**                                                                       @*.*@
            
                        [A] MAGE                                             [B] WARRIOR                                                   [C] TANK        
              ");

                string player1Choice = "", player1Char = "", player1Symbol = "";
                string player2Choice = "", player2Char = "", player2Symbol = "";
                int player1HP = 0, player1Energy = 0, player1HPpotion = 1, player1EnergyPotion = 1;
                int player2HP = 0, player2Energy = 0, player2HPpotion = 1, player2EnergyPotion = 1;


                //---------------------- player 1 character select ---------------------------
                bool validcharacterChoice = false;
                while (!validcharacterChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Player1 character select: ");
                    Console.ResetColor();
                    player1Choice = Console.ReadLine();

                    if (player1Choice == "A" || player1Choice == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Player1 chose Mage");
                        Console.ResetColor();
                        player1Char = "Mage";
                        player1Symbol = wand;
                        player1HP = 100;
                        player1Energy = 100;
                        validcharacterChoice = true;
                    }
                    else if (player1Choice == "B" || player1Choice == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Player1 chose Warrior");
                        Console.ResetColor();
                        player1Char = "Warrior";
                        player1Symbol = sword;
                        player1HP = 110;
                        player1Energy = 110;
                        validcharacterChoice = true;
                    }
                    else if (player1Choice == "C" || player1Choice == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player1 chose Tank");
                        Console.ResetColor();
                        player1Char = "Tank";
                        player1Symbol = shield;
                        player1HP = 145;
                        player1Energy = 90;
                        validcharacterChoice = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid choice! Please choose between A, B, or C.");

                    }
                }

                //---------------------- player 2 character select ---------------------------
                validcharacterChoice = false;
                while (!validcharacterChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Player2 character select: ");
                    Console.ResetColor();
                    player2Choice = Console.ReadLine();

                    if (player2Choice == "A" || player2Choice == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Player2 chose Mage");
                        Console.ResetColor();
                        player2Char = "Mage";
                        player2Symbol = wand;
                        player2HP = 100;
                        player2Energy = 100;
                        validcharacterChoice = true;
                    }
                    else if (player2Choice == "B" || player2Choice == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Player2 chose Warrior");
                        Console.ResetColor();
                        player2Char = "Warrior";
                        player2Symbol = sword;
                        player2HP = 110;
                        player2Energy = 110;
                        validcharacterChoice = true;
                    }
                    else if (player2Choice == "C" || player2Choice == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player2 chose Tank");
                        Console.ResetColor();
                        player2Char = "Tank";
                        player2Symbol = shield;
                        player2HP = 145;
                        player2Energy = 90;
                        validcharacterChoice = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid choice! Please choose between A, B, or C.");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nLoading Battle Screen...\n");
                Console.WriteLine("===========================================================================");
                Console.WriteLine(@"PLAYER1 ({0})                   VS                     PLAYER2 ({1})
HP: {2} Energy: {3}                                     HP: {4} Energy: {5}
HP Potion: {6}                                            HP Potion: {7} 
Energy Potion: {8}                                        Energy Potion: {9}", player1Char, player2Char, player1HP, player1Energy, player2HP, player2Energy, player1HPpotion, player2HPpotion, player1EnergyPotion, player2EnergyPotion);
                Console.WriteLine("===========================================================================");
                Console.ResetColor();


                //---------------------- combat function ---------------------------
                while (player1HP > 0 && player2HP > 0)
                {
                    int[] result = new int[6];
                    if (player1Choice == "A" || player1Choice == "a")
                    {
                        result = Mage(player1HP, player1Energy, player2HP, player2Energy, "Player 1", "Player 2", player1HPpotion, player1EnergyPotion);
                    }
                    else if (player1Choice == "B" || player1Choice == "b")
                    {
                        result = Warrior(player1HP, player1Energy, player2HP, player2Energy, "Player 1", "Player 2", player1HPpotion, player1EnergyPotion);
                    }
                    else if (player1Choice == "C" || player1Choice == "c")
                    {
                        result = Tank(player1HP, player1Energy, player2HP, player2Energy, "Player 1", "Player 2", player1HPpotion, player1EnergyPotion);
                    }
                    player1HP = result[0];
                    player1Energy = result[1];
                    player2HP = result[2];
                    player2Energy = result[3];
                    player1HPpotion = result[4];
                    player1EnergyPotion = result[5];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n===========================================================================");
                    Console.WriteLine(@"PLAYER1 ({0})                   VS                     PLAYER2 ({1})
HP: {2} Energy: {3}                                     HP: {4} Energy: {5}
HP Potion: {6}                                            HP Potion: {7} 
Energy Potion: {8}                                        Energy Potion: {9}", player1Char, player2Char, player1HP, player1Energy, player2HP, player2Energy, player1HPpotion, player2HPpotion, player1EnergyPotion, player2EnergyPotion);
                    Console.WriteLine("===========================================================================");
                    Console.ResetColor();


                    if (player2Choice == "A" || player2Choice == "a")
                    {
                        result = Mage(player2HP, player2Energy, player1HP, player1Energy, "Player 2", "Player 1", player2HPpotion, player2EnergyPotion);
                    }
                    else if (player2Choice == "B" || player2Choice == "b")
                    {
                        result = Warrior(player2HP, player2Energy, player1HP, player1Energy, "Player 2", "Player 1", player2HPpotion, player2EnergyPotion);
                    }
                    else if (player2Choice == "C" || player2Choice == "c")
                    {
                        result = Tank(player2HP, player2Energy, player1HP, player1Energy, "Player 2", "Player 1", player2HPpotion, player2EnergyPotion);
                    }
                    player2HP = result[0];
                    player2Energy = result[1];
                    player1HP = result[2];
                    player1Energy = result[3];
                    player2HPpotion = result[4];
                    player2EnergyPotion = result[5];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n===========================================================================");
                    Console.WriteLine(@"PLAYER1 ({0})                   VS                     PLAYER2 ({1})
HP: {2} Energy: {3}                                     HP: {4} Energy: {5}
HP Potion: {6}                                            HP Potion: {7} 
Energy Potion: {8}                                        Energy Potion: {9}", player1Char, player2Char, player1HP, player1Energy, player2HP, player2Energy, player1HPpotion, player2HPpotion, player1EnergyPotion, player2EnergyPotion);
                    Console.WriteLine("===========================================================================");
                    Console.ResetColor();
                }

                //---------------------- game winner check ---------------------------
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\nGAME OVER\tGAME OVER\tGAME OVER\tGAME OVER\tGAME OVER");
                if (player1HP > 0)
                {
                    Console.Write($"\n\n\t\t\tPlayer 1 {player1Char} wins!");
                    Console.Write(player1Symbol);
                }

                else
                {
                    Console.Write($"\n\n\t\t\tPlayer 2 {player2Char} wins!");
                    Console.Write(player2Symbol);
                }
                Console.ResetColor();



                //--------------------------------- mage function ----------------------------------
                static int[] Mage(int casterHP, int casterEnergy, int targetHP, int targetEnergy, string player, string opponent, int playerHPpotion, int playerEnergypotion)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    bool attack = false;
                    while (!attack)
                    {
                        Console.WriteLine($"\n {player} Mage Attacks: ");
                        Console.WriteLine(@"[A] Heavenly Fireball:
                                          Damage: 10-12
                                          Energy cost: 15");

                        Console.WriteLine(@"[B] Freezing Field:
                                          Damage: 12-15
                                          Energy cost: 20");

                        Console.WriteLine(@"[C] Storm Swarm:
                                          Damage: 25
                                          Energy cost: 25");

                        Console.WriteLine(@"[D] Special skill: Blood Ode
                                          Damage: 30
                                          Energy cost: 30
                                          Effect: 30% chance to recover spent energy");

                        Console.WriteLine(@"[E] Use Health Potion
                                          Restores 25 health points");

                        Console.WriteLine(@"[F] Use Energy Potion
                                          Restores 40 energy points");
                        Console.Write("Enter Attack: ");
                        string playerAttack = Console.ReadLine();

                        Random rnd = new Random();
                        if (playerAttack == "A" || playerAttack == "a")
                        {
                            if (casterEnergy >= 15)
                            {
                                Console.WriteLine($"\n{player} (Mage) used Heavenly Fireball!");
                                casterEnergy -= 15;
                                int damage = rnd.Next(10, 13);
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Heavenly Fireball. Not enough energy."); }
                        }
                        else if (playerAttack == "B" || playerAttack == "b")
                        {
                            if (casterEnergy >= 20)
                            {
                                Console.WriteLine($"\n{player} (Mage) used Freezing Field!");
                                casterEnergy -= 20;
                                int damage = rnd.Next(12, 16);
                                targetHP -= damage;
                                targetHP -= 15;
                                Console.WriteLine($"{opponent} received {damage} damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Freezing Field. Not enough energy."); }
                        }
                        else if (playerAttack == "C" || playerAttack == "c")
                        {
                            if (casterEnergy >= 25)
                            {
                                Console.WriteLine($"\n{player} (Mage) used Storm Swarm!");
                                casterEnergy -= 25;
                                targetHP -= 20;
                                Console.WriteLine($"{opponent} received 20 damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Storm Swarm. Not enough energy."); }

                        }
                        else if (playerAttack == "D" || playerAttack == "d")
                        {
                            if (casterEnergy >= 30)
                            {
                                Console.WriteLine($"\n{player} (Mage) used Special skill: Blood Ode!");
                                casterEnergy -= 30;
                                targetHP -= 30;
                                Console.WriteLine($"{opponent} received 30 damage!");
                                int chance = rnd.Next(0, 101);
                                if (chance <= 30)
                                {
                                    casterEnergy += 30;
                                    Console.WriteLine("Blood Ode special effect: +30Energy");
                                }
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Special skill: Blood Ode. Not enough energy."); }
                        }
                        else if (playerAttack == "E" || playerAttack == "e")
                        {
                            if (playerHPpotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Mage) used health potion! +25HP");
                                casterHP += 25;
                                playerHPpotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No health potions left."); }

                        }
                        else if (playerAttack == "F" || playerAttack == "f")
                        {
                            if (playerEnergypotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Mage) used energy potion! +40Energy");
                                casterEnergy += 40;
                                playerEnergypotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No energy potions left."); }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Invalid choice! Please choose among A, B, C, D, E, or F.");
                            Console.ResetColor();
                        }
                    }
                    if (targetHP < 0) { targetHP = 0; }
                    int[] result = { casterHP, casterEnergy, targetHP, targetEnergy, playerHPpotion, playerEnergypotion };
                    Console.ResetColor();
                    return result;
                }



                //--------------------------------- warrior function ---------------------------------
                static int[] Warrior(int casterHP, int casterEnergy, int targetHP, int targetEnergy, string player, string opponent, int playerHPpotion, int playerEnergypotion)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    bool attack = false;
                    while (!attack)
                    {
                        Console.WriteLine($"\n {player} Warrior Attacks: ");
                        Console.WriteLine(@"[A] Whirling Smash
                                          Damage: 13-15
                                          Energy cost: 10
                                          Effect: 20% chance for 120% critical damage");

                        Console.WriteLine(@"[B] Phantom Execution
                                          Damage: 15-20
                                          Energy cost: 18
                                          Effect: 20% chance to do double damage");

                        Console.WriteLine(@"[C] Berserk
                                          Damage: 20-24
                                          Energy cost: 27
                                          Effect: 7% chance to do triple damage");

                        Console.WriteLine(@"[D] Special attack: Remorseless Flying Dragon
                                          Damage: 35
                                          Energy cost: 35");

                        Console.WriteLine(@"[E] Use Health Potion
                                          Restores 30 health points");

                        Console.WriteLine(@"[F] Use Energy Potion
                                          Restores 30 energy points");
                        Console.Write("Enter Attack: ");
                        string playerAttack = Console.ReadLine();

                        Random rnd = new Random();
                        if (playerAttack == "A" || playerAttack == "a")
                        {
                            if (casterEnergy >= 10)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used Whirling Smash!");
                                casterEnergy -= 10;
                                int damage = rnd.Next(13, 16);
                                int chance = rnd.Next(0, 101);
                                string critical = "";
                                if (chance <= 20)
                                {
                                    damage = (int)(damage * 1.2);
                                }
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage! {critical}");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Whirling Smash. Not enough energy."); }
                        }
                        else if (playerAttack == "B" || playerAttack == "b")
                        {
                            if (casterEnergy >= 15)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used Phantom Execution!");
                                casterEnergy -= 18;
                                int damage = rnd.Next(15, 21);
                                int chance = rnd.Next(0, 101);
                                string critical = "";
                                if (chance <= 20)
                                {
                                    damage *= 2;
                                    critical = "CRITICAL!";
                                }
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage! {critical}");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Phantom Execution. Not enough energy."); }
                        }
                        else if (playerAttack == "C" || playerAttack == "c")
                        {
                            if (casterEnergy >= 20)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used Berserk!");
                                casterEnergy -= 20;
                                int damage = rnd.Next(20, 25);
                                int chance = rnd.Next(0, 101);
                                string critical = "";
                                if (chance <= 7)
                                {
                                    damage *= 3;
                                    critical = "CRITICAL!";
                                }
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage! {critical}");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Berserk. Not enough energy."); }
                        }

                        else if (playerAttack == "D" || playerAttack == "d")
                        {
                            if (casterEnergy >= 35)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used Special attack: Remorseless Flying Dragon!");
                                casterEnergy -= 35;
                                targetHP -= 35;
                                Console.WriteLine($"{opponent} received 35 damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Special attack: Remorseless Flying Dragon. Not enough energy."); }
                        }
                        else if (playerAttack == "E" || playerAttack == "e")
                        {
                            if (playerHPpotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used health potion! +30HP");
                                casterHP += 30;
                                playerHPpotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No health potions left."); }

                        }
                        else if (playerAttack == "F" || playerAttack == "f")
                        {
                            if (playerEnergypotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Warrior) used energy potion! +30Energy");
                                casterEnergy += 30;
                                playerEnergypotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No energy potions left."); }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Invalid choice! Please choose among A, B, C, D, E, or F.");
                            Console.ResetColor();
                        }
                    }
                    if (targetHP < 0) { targetHP = 0; }
                    int[] result = { casterHP, casterEnergy, targetHP, targetEnergy, playerHPpotion, playerEnergypotion };
                    Console.ResetColor();
                    return result;
                }



                //--------------------------------- tank function ---------------------------------
                static int[] Tank(int casterHP, int casterEnergy, int targetHP, int targetEnergy, string player, string opponent, int playerHPpotion, int playerEnergypotion)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool attack = false;
                    while (!attack)
                    {
                        Console.WriteLine($"\n {player} Tank Attacks: ");
                        Console.WriteLine(@"[A] Guadian’s Bulwark
                                          Damage: 8-12
                                          Energy cost: 5");

                        Console.WriteLine(@"[B] Skull Crusher
                                          Damage: 12-20
                                          Energy cost: 7");

                        Console.WriteLine(@"[C] Dragon’s Blood
                                          Energy cost: 20
                                          Health Regen: 20-30
                                          Effect: regenerate a random amount of health");

                        Console.WriteLine(@"[D] Special attack: Double-edged sword
                                          Damage: 45
                                          Energy cost: 0
                                          Effect: damages self by the same amount (can't die by suicide)");

                        Console.WriteLine(@"[E] Use Health Potion
                                          Restores 40 health points");

                        Console.WriteLine(@"[F] Use Energy Potion
                                          Restores 25 energy points");
                        Console.Write("Enter Attack: ");
                        string playerAttack = Console.ReadLine();

                        Random rnd = new Random();
                        if (playerAttack == "A" || playerAttack == "a")
                        {
                            if (casterEnergy >= 5)
                            {
                                Console.WriteLine($"\n{player} (Tank) used Guadian’s Bulwark!");
                                casterEnergy -= 5;
                                int damage = rnd.Next(8, 13);
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Guadian’s Bulwark. Not enough energy."); }
                        }
                        else if (playerAttack == "B" || playerAttack == "b")
                        {
                            if (casterEnergy >= 7)
                            {
                                Console.WriteLine($"\n{player} (Tank) used Skull Crusher!");
                                casterEnergy -= 7;
                                int damage = rnd.Next(12, 21);
                                targetHP -= damage;
                                Console.WriteLine($"{opponent} received {damage} damage!");
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Skull Crusher. Not enough energy."); }
                        }
                        else if (playerAttack == "C" || playerAttack == "c")
                        {
                            if (casterEnergy >= 20)
                            {
                                casterEnergy -= 20;
                                int regen = rnd.Next(20, 31);
                                Console.WriteLine($"\n{player} (Tank) used Dragon’s Blood! +{regen}HP");
                                casterHP += regen;
                                attack = true;
                            }
                            else { Console.WriteLine("Can't use Dragon’s Blood. Not enough energy."); }
                        }
                        else if (playerAttack == "D" || playerAttack == "d")
                        {
                            Console.WriteLine($"\n{player} (Tank) used Special attack: Double-edged sword!");
                            casterHP -= 45;
                            if (casterHP <= 0)
                            {
                                casterHP = 1;
                            }
                            targetHP -= 45;
                            Console.WriteLine($"{player} received 45 damage!");
                            Console.WriteLine($"{opponent} received 45 damage!");
                            attack = true;
                        }
                        else if (playerAttack == "E" || playerAttack == "e")
                        {
                            if (playerHPpotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Tank) used health potion! +40HP");
                                casterHP += 40;
                                playerHPpotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No health potions left."); }

                        }
                        else if (playerAttack == "F" || playerAttack == "f")
                        {
                            if (playerEnergypotion > 0)
                            {
                                Console.WriteLine($"\n{player} (Tank) used energy potion! +25Energy");
                                casterEnergy += 25;
                                playerEnergypotion--;
                                attack = true;
                            }
                            else { Console.WriteLine("No energy potions left."); }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Invalid choice! Please choose among A, B, C, D, E, or F.");
                            Console.ResetColor();
                        }
                    }
                    if (targetHP < 0) { targetHP = 0; }
                    int[] result = { casterHP, casterEnergy, targetHP, targetEnergy, playerHPpotion, playerEnergypotion };
                    Console.ResetColor();
                    return result;
                }
            }



        
    }
}
