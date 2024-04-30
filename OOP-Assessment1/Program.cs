using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    public class Program
    {
        public string filepath = "Stats.txt";
        /// <summary>
        /// This starts the program by the user choosing the game they want to play
        /// </summary>

        private static void Main()
        {
                Sevensout game = new Sevensout(); // this created the a new game for running 
                Threeormore Game = new Threeormore(); // this created the a new game for running 
                Testing testing = new Testing();
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░██████╗░██╗░█████╗░███████╗░░░░██████╗░░█████╗░███╗░░░███╗███████╗░██████╗░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░██╔══██╗██║██╔══██╗██╔════╝░░░██╔════╝░██╔══██╗████╗░████║██╔════╝██╔════╝░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░██║░░██║██║██║░░╚═╝█████╗░░░░░██║░░██╗░███████║██╔████╔██║█████╗░░╚█████╗░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░██║░░██║██║██║░░██╗██╔══╝░░░░░██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░░╚═══██╗░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░██████╔╝██║╚█████╔╝███████╗░░░╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██████╔╝░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░╚═════╝░╚═╝░╚════╝░╚══════╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░███╗░░██╗░██████╗███████╗██╗░░░██╗███████╗███╗░░██╗░██████╗░░░░█████╗░██╗░░░██╗████████╗░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░████║░░╚═╝██╔════╝██╔════╝██║░░░██║██╔════╝████╗░██║██╔════╝░░░██╔══██╗██║░░░██║╚══██╔══╝░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░██╔██║░░░░░╚█████╗░█████╗░░╚██╗░██╔╝█████╗░░██╔██╗██║╚█████╗░░░░██║░░██║██║░░░██║░░░██║░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░╚═╝██║░░░░░░╚═══██╗██╔══╝░░░╚████╔╝░██╔══╝░░██║╚████║░╚═══██╗░░░██║░░██║██║░░░██║░░░██║░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░███████╗██╗██████╔╝███████╗░░╚██╔╝░░███████╗██║░╚███║██████╔╝░░░╚█████╔╝╚██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░╚══════╝╚═╝╚═════╝░╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═════╝░░░░░╚════╝░░╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("██████╗░██╗████████╗██╗░░██╗██████╗░███████╗███████╗░░░░█████╗░██████╗░░░░███╗░░░███╗░█████╗░██████╗░███████╗");
                Console.WriteLine("╚════██╗╚═╝╚══██╔══╝██║░░██║██╔══██╗██╔════╝██╔════╝░░░██╔══██╗██╔══██╗░░░████╗░████║██╔══██╗██╔══██╗██╔════╝");
                Console.WriteLine("░░███╔═╝░░░░░░██║░░░███████║██████╔╝█████╗░░█████╗░░░░░██║░░██║██████╔╝░░░██╔████╔██║██║░░██║██████╔╝█████╗░░");
                Console.WriteLine("██╔══╝░░░░░░░░██║░░░██╔══██║██╔══██╗██╔══╝░░██╔══╝░░░░░██║░░██║██╔══██╗░░░██║╚██╔╝██║██║░░██║██╔══██╗██╔══╝░░");
                Console.WriteLine("███████╗██╗░░░██║░░░██║░░██║██║░░██║███████╗███████╗░░░╚█████╔╝██║░░██║░░░██║░╚═╝░██║╚█████╔╝██║░░██║███████╗");
                Console.WriteLine("╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚══════╝░░░░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚═╝╚══════╝");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░██████╗░██╗░██████╗████████╗░█████╗░████████╗░██████╗░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░╚════██╗╚═╝██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██╔════╝░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░█████╔╝░░░╚█████╗░░░░██║░░░███████║░░░██║░░░╚█████╗░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░╚═══██╗░░░░╚═══██╗░░░██║░░░██╔══██║░░░██║░░░░╚═══██╗░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░██████╔╝██╗██████╔╝░░░██║░░░██║░░██║░░░██║░░░██████╔╝░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░██╗██╗██╗████████╗███████╗░██████╗████████╗██╗███╗░░██╗░██████╗░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░██╔╝██║╚═╝╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝██║████╗░██║██╔════╝░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░██╔╝░██║░░░░░░██║░░░█████╗░░╚█████╗░░░░██║░░░██║██╔██╗██║██║░░██╗░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░███████║░░░░░░██║░░░██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚████║██║░░╚██╗░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░╚════██║██╗░░░██║░░░███████╗██████╔╝░░░██║░░░██║██║░╚███║╚██████╔╝░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░╚═╝╚═╝░░░╚═╝░░░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░╚══╝░╚═════╝░░░░░░░░░░░░░░░░░░░░░░░░░");




            try
            {
                var user = Console.ReadLine();
                int User = Convert.ToInt32(user);

                if (User == 1)
                {
                    game.SevensOutGame(); // this runs the sevens out game
                }
                if (User == 2)
                {
                    Game.ThreeOrMore(); // this runs the three or more game
                }
                if (User == 3)
                {
                    Console.WriteLine("1: Sevensout stats");
                    Console.WriteLine("2: ThreeOrMore stats");
                        var userchoice = Console.ReadLine();

                    if (userchoice == "1")
                    {
                        string NumberOfTurns = File.ReadLines("SevensOutStats.txt").First(); // this reads the first line within the text file which is the number of turns 
                        string HighestScore = File.ReadAllLines("SevensOutStats.txt").Skip(1).First(); // this reads the second line within my text file which is my highest score 
                        Console.WriteLine("the highest number of turns was: " + NumberOfTurns); // This shows the user the number of turns within the text file
                        Console.WriteLine("the highest score was: " + HighestScore); // this shows the user the highest score
                    }
                    if(userchoice == "2")
                    {
                        string NumberOfTurns2 = File.ReadLines("ThreeOrMoreStats.txt").First(); // this reads the first line within the text file which is the number of turns 
                        string HighestScore2 = File.ReadAllLines("ThreeOrMoreStats.txt").Skip(1).First(); // this reads the second line within my text file which is my highest score 
                        Console.WriteLine("the highest number of turns was: " + NumberOfTurns2); // This shows the user the number of turns within the text file
                        Console.WriteLine("the highest score was: " + HighestScore2); // this shows the user the highest score
                    }
                }
                if (User == 4)
                {
                    Console.WriteLine("1: Sevensout testing");
                    Console.WriteLine("2: ThreeOrMore testing");
                    var userchoice = Console.ReadLine();
                    int Userchoice = Convert.ToInt32(userchoice);
                    if (Userchoice == 1)
                    {
                        testing.UserTestingSevensOut();
                    }
                    if (Userchoice == 2)
                    {
                        testing.UserTestingThreeOrMore();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!!");
                    }
                }
                if (User > 5)
                {
                    throw new ArithmeticException("Number is out of range!!");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!!");
                Main();
            }
        }
    }
}