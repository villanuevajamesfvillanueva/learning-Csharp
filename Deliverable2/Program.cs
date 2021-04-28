using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args) {
            string virusBusters = @"

 ██▒   █▓ ██▓ ██▀███   █    ██   ██████     ▄▄▄▄    █    ██   ██████ ▄▄▄█████▓▓█████  ██▀███    ██████   
▓██░   █▒▓██▒▓██ ▒ ██▒ ██  ▓██▒▒██    ▒    ▓█████▄  ██  ▓██▒▒██    ▒ ▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒▒██    ▒   ██
 ▓██  █▒░▒██▒▓██ ░▄█ ▒▓██  ▒██░░ ▓██▄      ▒██▒ ▄██▓██  ▒██░░ ▓██▄   ▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒░ ▓██▄   
  ▒██ █░░░██░▒██▀▀█▄  ▓▓█  ░██░  ▒   ██▒   ▒██░█▀  ▓▓█  ░██░  ▒   ██▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄    ▒   ██▒  ██
   ▒▀█░  ░██░░██▓ ▒██▒▒▒█████▓ ▒██████▒▒   ░▓█  ▀█▓▒▒█████▓ ▒██████▒▒  ▒██▒ ░ ░▒████▒░██▓ ▒██▒▒██████▒▒
   ░ ▐░  ░▓  ░ ▒▓ ░▒▓░░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░   ░▒▓███▀▒░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░▒ ▒▓▒ ▒ ░
   ░ ░░   ▒ ░  ░▒ ░ ▒░░░▒░ ░ ░ ░ ░▒  ░ ░   ▒░▒   ░ ░░▒░ ░ ░ ░ ░▒  ░ ░    ░     ░ ░  ░  ░▒ ░ ▒░░ ░▒  ░ ░
     ░░   ▒ ░  ░░   ░  ░░░ ░ ░ ░  ░  ░      ░    ░  ░░░ ░ ░ ░  ░  ░    ░         ░     ░░   ░ ░  ░  ░  
      ░   ░     ░        ░           ░      ░         ░           ░              ░  ░   ░           ░  
     ░                                           ░                                                     ";

            string netEscape = @"
            ███╗   ██╗███████╗████████╗    ███████╗███████╗ ██████╗ █████╗ ██████╗ ███████╗██╗
            ████╗  ██║██╔════╝╚══██╔══╝    ██╔════╝██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║
            ██╔██╗ ██║█████╗     ██║       █████╗  ███████╗██║     ███████║██████╔╝█████╗  ██║
            ██║╚██╗██║██╔══╝     ██║       ██╔══╝  ╚════██║██║     ██╔══██║██╔═══╝ ██╔══╝  ╚═╝
            ██║ ╚████║███████╗   ██║       ███████╗███████║╚██████╗██║  ██║██║     ███████╗██╗
            ╚═╝  ╚═══╝╚══════╝   ╚═╝       ╚══════╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝     ╚══════╝╚═╝";
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(virusBusters);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(netEscape + "\n\n\n");
            Console.ResetColor();

            int andyHP = 200;
            int b055HP = 200;
            int goons = 80;

            string andy = @"
                                -''--.
                                _`>   `\.-'<
                            _.'     _     '._
                          .'   _.='   '=._   '.
                          >_   / /_\ /_\ \   _<
                            / (  \o/\\o/  ) \
                            >._\ .-,_)-. /_.<
                                /__/ \__\ 
                                  '---'    GG EZ
            ";

            string b055 = @"
                                     ______                     
             _________        .---'''      '''---.              
            :______.-':      :  .--------------.  :             
            | ______  |      | :                : |             
            |:______D:|      | |      B-055     | |             
            |:______D:|      | |                | |             
            |:______D:|      | |      Dude,     | |             
            |         |      | |   I'm so pro   | |             
            |:_____:  |      | |                | |             
            |    ==   |      | :                : |             
            |       O |      :  '--------------'  :             
            |       o |      :'---...______...---'              
            |       o |-._.-i___/'             \._              
            |'-.____o_|   '-.   '-...______...-'  `-._          
            :_________:      `.____________________   `-.___.-. 
                             .'.eeeeeeeeeeeeeeeeee.'.      :___:
                           .'.eeeeeeeeeeeeeeeeeeeeee.'.         
                          :____________________________:
            ";

            string vsScreen = @"
              
                                                                                 ______                     
                                                         _________        .---'''      '''---.              
                                                        :______.-':      :  .--------------.  :             
                                                        | ______  |      | :                : |             
                    -''--.                              |:______D:|      | |     B-055      | |             
                    _`>   `\.-'<                        |:______D:|      | |                | |             
                _.'     _     '._                       |:______D:|      | |    Nastiest    | |             
              .'   _.='   '=._   '.                     |         |      | |    Computer    | |             
              >_   / /_\ /_\ \   _<          VS         |:_____:  |      | |     Virus      | |             
                / (  \o/\\o/  ) \                       |    ==   |      | :     Around     : |             
                >._\ .-,_)-. /_.<                       |       O |      :  '--------------'  :             
                    /__/ \__\                           |       o |      :'---...______...---'              
                      '---'                             |       o |-._.-i___/'             \._              
                                                        |'-.____o_|   '-.   '-...______...-'  `-._          
                                                        :_________:      `.____________________   `-.___.-. 
                                                                         .'.eeeeeeeeeeeeeeeeee.'.      :___:
                                                                       .'.eeeeeeeeeeeeeeeeeeeeee.'.         
                                                                      :____________________________:";

            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(vsScreen);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t  Andy's HP: {andyHP}\t\t\t\t\t     B-055's HP: {b055HP}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t    B-055's Goons: {goons}");
            Console.ResetColor();

            while (andyHP > 0 && b055HP > 0) {
                //Andy's turn
                bool playerTurn = false;
                while(!playerTurn) {
                    Console.WriteLine("\nAndy's Attacks: ");
                    Console.WriteLine("[A] Quarantine Chest (-30 Goons / 50 DMG if Goons <= 0)");
                    Console.WriteLine("[B] Smart Scan (+15 Goons & 30 DMG)");
                    Console.WriteLine("[C] Software Update (+10HP & Heal 75)\n");
                    Console.Write("Enter Attack: ");
                    string andyAttack = Console.ReadLine(); 

                    if (andyAttack == "A" || andyAttack == "a") {
                        if (goons <= 0) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(">>>The Quarantine Chest Traps the B-055!");
                            Console.ResetColor();
                            b055HP -= 50;
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(">>>The Quarantine Chest takes out the goons!");
                            Console.ResetColor();
                            goons -= 30;
                        }
                        playerTurn = true;
                    }

                    else if (andyAttack == "B" || andyAttack == "b") {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(">>>Andy used Smart Scan!");
                        Console.ResetColor();
                        goons += 15;
                        b055HP -= 30;
                        playerTurn = true;
                    }

                    else if (andyAttack == "C" || andyAttack == "c") {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(">>>Andy used Software Update to heal up!");
                        Console.ResetColor();
                        goons += 10;
                        andyHP += 75;
                        playerTurn = true;
                    }

                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice! Please choose between A, B or C.");
                        Console.ResetColor();
                    }

                }

                //B-055's turn
                if (goons <= 0) {
                    andyHP -= 60;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n>>>B-055 corrupts Andy!\n");
                    Console.ResetColor();
                }

                else {
                    andyHP -= goons;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n>>>B-055 sics his goons at Andy!\n");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+===================================+");
                Console.WriteLine($"          Andy's HP: {andyHP}           \n");
                Console.WriteLine($"          B-055's HP: {b055HP}          " );
                Console.WriteLine($"          B-055's Goons: {goons}        ");
                Console.WriteLine("+===================================+");
                Console.ResetColor();

            }

            //checking winner 
            Console.WriteLine("\n\n\tGAME OVER  GAME OVER   GAME OVER   GAME OVER   GAME OVER");
            if (b055HP <= 0) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\t\t\tAndy wins!");
                Console.WriteLine(andy);
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t\tB-055 wins!");
                Console.WriteLine(b055);
                Console.ResetColor();
            }
            
        }
    }
}
