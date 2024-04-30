using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    public class Threeormore : Game
    {
        /// <summary>
        /// this method is used to run the Three Or  More dice game
        /// </summary>
        public void ThreeOrMore()
        {
            // creates a testing object
            Testing threeormoretesting = new Testing();

            //this gives the user two options of if they want to play agains another player or against the computer
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");

            //this reads the users choice
            var user = Console.ReadLine();

            //this takes the users input and puts the user into the respective game mode
            //if (user == "1")
            //
            //{
            WinningList.Add(0); WinningList.Add(0); WinningList.Add(0); // this adds locations into the winning score list so i can input the data i need to
            try
            {
                while (Start == true) //this starts my while loop that allows multiple players to have a go
                {
                    for (int y = 1; y < 3; y++) // this loop allows 2 players to play
                    {
                        if (user == "1")
                        {
                            //the dice rolls
                            Console.WriteLine("Player " + (y)); // this just tells the users what plays go it is
                            for (i = 0; i < 5; i++) // this for loop allows 2 dice to be rolled by a player 
                            {
                                DiceFace = Dice.Roll(); // this rolls the dice
                                DiceRolledlist.Add(DiceFace); // this adds the dice to a collection
                                Console.WriteLine("any key to roll"); // this tells the user what to do to roll the dice
                                Console.ReadKey(true);  // this removes the key the user presses from the terminal
                                Console.WriteLine("this is dice roll : " + DiceRolledlist[i]); // this tells the user what number they rolled

                            }
                        }
                        if (user == "2")
                        {
                            if (y == 1)
                            {
                                Console.WriteLine("Player 1");
                                for (i = 0; i < 5; i++)
                                {
                                    DiceFace = Dice.Roll();
                                    DiceRolledlist.Add(DiceFace);
                                    Console.WriteLine("any key to roll");
                                    Console.ReadKey(true);
                                    Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Computers turn");
                                for (i = 0; i < 5; i++)
                                {
                                    DiceFace = Dice.Roll();
                                    DiceRolledlist.Add(DiceFace);
                                    int Delay = 1000;
                                    Thread.Sleep(Delay);
                                    Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                                }
                            }
                        }
                        DiceRolledlist.Sort(); // this sorts the collection

                        //this checks for multiple of a kind and adds a point to a counter
                        if (DiceRolledlist[0] == DiceRolledlist[1])
                        {
                            for (x = 1; x < 5; x++)
                            {
                                i = 0;
                                if (DiceRolledlist[i] == DiceRolledlist[x])
                                {
                                    Counter++;
                                }
                            }
                        }
                        else if (DiceRolledlist[1] == DiceRolledlist[2])
                        {
                            for (i = 1; i < 4; i++)
                            {
                                if (DiceRolledlist[x] == DiceRolledlist[i + 1])
                                {
                                    Counter++;
                                }
                            }
                        }
                        else if (DiceRolledlist[2] == DiceRolledlist[3])
                        {
                            for (i = 3; i < 5; i++)
                            {
                                if (DiceRolledlist[x + 1] == DiceRolledlist[i])
                                {
                                    Counter++;
                                }
                            }
                        }
                        else if (DiceRolledlist[3] == DiceRolledlist[4])
                        {
                            for (i = 3; i < 4; i++)
                            {
                                if (DiceRolledlist[i] == DiceRolledlist[i + 1])
                                {
                                    Counter++;
                                }
                            }
                        }

                        // using the counter for the points system 
                        if (Counter >= 1)
                        {
                            // 5 of a kind will give the player 12 points
                            if (Counter == 4)
                            {
                                Console.WriteLine("Player gets 12 points");
                                WinningList[y] = WinningList[y] + 12;
                            }

                            // 4 of a kind will give the player 6 points
                            else if (Counter == 3)
                            {
                                Console.WriteLine("Player gets 6 points");
                                WinningList[y] = WinningList[y] + 6;
                            }

                            // 3 of a kind will give the player 3 points
                            else if (Counter == 2)
                            {
                                Console.WriteLine("Player gets 3 points");
                                WinningList[y] = WinningList[y] + 3;
                            }

                            //if there is only a 2 of a kind it allows the player who rolled it to re roll all dice
                            else if (Counter == 1)
                            {
                                Console.WriteLine("Player to re-roll");
                                if (y == 1)
                                {
                                    y = y - 1;
                                }
                                if (y == 2)
                                {
                                    y = y - 1;
                                }
                            }
                        }

                        //if there is no matches it will pass the go
                        else
                        {
                            Console.WriteLine("No Matching numbers");
                        }

                        // the first player to get to 20 or greater will win
                        if (WinningList[y] >= 20)
                        {
                            if (i == 0)
                            {
                                highestScore.HighestScoreIncrese(WinningList[y], i);
                                Console.WriteLine("Player " + (i + 1) + " wins!");
                                Console.WriteLine("the number of turns was " + numberofplays.GetCounter());
                                Console.WriteLine("the winning score of player 1 was " + highestScore.GetHighestScore(i));
                                int[] NumberToWrite = {numberofplays.GetCounter(), highestScore.GetHighestScore(i)};
                                string TurnNumberToString = string.Join(Environment.NewLine, NumberToWrite);
                                File.WriteAllText("ThreeOrMoreStats.txt", TurnNumberToString);
                            }
                            if (i == 1)
                            {
                                highestScore2.HighestScoreIncrese(WinningList[y], i);
                                Console.WriteLine("Player " + (i + 1) + " wins!");
                                Console.WriteLine("the number of turns was " + numberofplays.GetCounter());
                                Console.WriteLine("the winning score for player 2 was " + highestScore2.GetHighestScore(i));
                                int[] StatsToWrite = { numberofplays.GetCounter(), highestScore2.GetHighestScore(i) };
                                string StringToNumberConversion = string.Join(Environment.NewLine, StatsToWrite);
                                File.WriteAllText("ThreeOrMoreStats.txt", StringToNumberConversion);

                            }
                            threeormoretesting.ThreeOrMoreTesting(WinningList[y], highestScore.GetHighestScore(i), highestScore2.GetHighestScore(i), i);

                        }
                        numberofplays.CounterIncrease(); // this increases the turn counter
                        x = 1;
                        i = 0;
                        DiceRolledlist.Clear();
                        Counter = 0;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                ThreeOrMore();
            }
        }
    }
}