using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    public class Sevensout : Game
    {

        /// <summary>
        /// this method is used to run the sevens out dice game
        /// </summary>
        public void SevensOutGame()
        {
            //creates a Testing object
            Testing sevensouttest = new Testing();

            //this gives the user two options of if they want to play agains another player or against the computer
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");

            //this reads the users choice
            var user = Console.ReadLine();

            //this takes the users input and puts the user into the respective game mode
            try // This will catch any erronous inputs by the user
            {
                WinningList.Add(0); WinningList.Add(0); // this adds locations into the winning score list so i can input the data i need to 
                while (Start == true) //this starts my while loop that allows multiple players to have a go 
                {
                    for (i = 0; i < 2; i++) // this loop allows 2 players to play
                    {
                        if (user == "1")
                        {

                            Console.WriteLine("Player " + (i + 1)); // this just tells the users what plays go it is
                            for (x = 0; x < 2; x++) // this for loop allows 2 dice to be rolled by a player 
                            {
                                DiceFace = Dice.Roll(); // this rolls the dice
                                DiceRolledlist.Add(DiceFace); // this adds the dice to a collection
                                Console.WriteLine("any key to roll"); // this tells the user what to do to roll the dice
                                Console.ReadKey(true); // this removes the key the user presses from the terminal
                                Console.WriteLine("This is roll: " + (x + 1) + " " + DiceRolledlist[x]); // this tells the user what number they rolled
                            }
                        }

                        if (user == "2")
                        {
                            if (i == 0)
                            {
                                // dice roll for Player 1
                                Console.WriteLine("Player 1");
                                for (x = 0; x < 2; x++)
                                {
                                    DiceFace = Dice.Roll();
                                    DiceRolledlist.Add(DiceFace);
                                    Console.WriteLine("any key to roll");
                                    Console.ReadKey(true);
                                    Console.WriteLine("this is dice roll : " + DiceRolledlist[x]);
                                }
                            }
                            else
                            {
                                // dice roll for computer
                                Console.WriteLine("Computers turn");
                                for (x = 0; x < 2; x++)
                                {
                                    DiceFace = Dice.Roll();
                                    DiceRolledlist.Add(DiceFace);
                                    int Delay = 1000; // this is a feature i added to make it seem like the player is playing against a computer who is pressing a key like them
                                    Thread.Sleep(Delay); // this is a feature i added to make it seem like the player is playing against a computer who is pressing a key like them
                                    Console.WriteLine("this is dice roll : " + DiceRolledlist[x]);

                                }
                            }
                        }
                        Console.WriteLine("yes");
                        result = DiceRolledlist[0] + DiceRolledlist[1]; // this adds the 2 dice rolls together
                        if (DiceRolledlist[0] == DiceRolledlist[1]) //this check if the 2 dice rolls were the same 
                        {
                            result = result * 2; //this doubles the total of the 2 dice rolls
                        }
                        if (i == 0) //this checks which players turn it was and adds the score to the repective players score
                        {
                            WinningList[0] = WinningList[0] + result; // this adds the result to the winning score location
                            highestScore.HighestScoreIncrese(WinningList[0], i); // this takes the location of the current score and the players turn into the stats class
                        }
                        if (i == 1) //this checks which players turn it was and adds the score to the repective players score
                        {
                            WinningList[1] = WinningList[1] + result; // this adds the result to the winning score location
                            highestScore2.HighestScoreIncrese(WinningList[1], i); // this takes the location of the current score and the players turn into the stats class
                        }
                        if (WinningList[1] > 0)
                        {
                            if (WinningList[0] > 0)
                            {
                                if (result == 7) // this checks the total of the dice rolls for a total of 7
                                {
                                    if (WinningList[0] < WinningList[1]) // this checks if the whole game total against the opposite player
                                    {
                                        i = 0;
                                        Console.WriteLine("Player " + 1 + " you win!");
                                        Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                        Console.WriteLine("the winning score was: " + highestScore.GetHighestScore(i)); // this is the winning score for this round
                                        Console.WriteLine("the highest score was: " + highestScore2.GetHighestScore((i + 1))); //this is the highest score of the round
                                        sevensouttest.SevensOutTesting(result, DiceRolledlist[0], DiceRolledlist[1]); // this takes it to the testing class
                                    }
                                    if (WinningList[1] < WinningList[0]) // this checks if the whole game total against the opposite player
                                    {
                                        i = 1;
                                        Console.WriteLine("Player " + 2 + " you win!");
                                        Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                        Console.WriteLine("the winning score was: " + highestScore2.GetHighestScore(i)); // this is the winning score for this round
                                        Console.WriteLine("the highest score was: " + highestScore.GetHighestScore((i - 1))); //this is the highest score of the round
                                        sevensouttest.SevensOutTesting(result, DiceRolledlist[0], DiceRolledlist[1]); // this takes it to the testing class
                                    }
                                }
                            }
                        }
                        Console.WriteLine(result); // this tells the user what the total of their rolls were
                        DiceRolledlist.Clear(); //this clears the collection ready for the next loop
                        numberofplays.CounterIncrease(); // this increases the turn counter
                                                         //Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                    }
                }
            }
            catch // this will catch any erroronous input
            {
                Console.WriteLine("invalid input!!");
                SevensOutGame();
            }
        }
    }
}