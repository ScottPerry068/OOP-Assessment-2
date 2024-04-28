using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Assessment2
{
    /// <summary>
    /// This class holds both games (SevensOut and ThreeOrMore)
    /// </summary>
    public class Game
    {
        // creates the variables for functionality
        private static int _DiceFace;// this variable is created to hold the dice values
        private int _result; //this creates the result
        private static Dice _Dice = new Dice();// this creates the dice objects

        //Creates Objects for inheritence
        NumberOfPlaysCounter numberofplays = new NumberOfPlaysCounter();
        HighestScoreCounter highestScore = new HighestScoreCounter();
        HighestScoreCounter highestScore2 = new HighestScoreCounter();
        

        //Global variables Mainly for loops
        bool Start = true;
        int i = 0;
        int x = 1;
        int y = 0;
        int Counter = 0;

        //Global Lists
        List<int> DiceRolledlist = new List<int>();
        List<int> WinningList = new List<int>();

        /// <summary>
        /// this method is used to run the sevens out dice game
        /// </summary>
        public void SevensOut()
        {
            //creates a Testing object
            Testing sevensouttest = new Testing();

            //this gives the user two options of if they want to play agains another player or against the computer
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");

            //this reads the users choice
            var user = Console.ReadLine();

            //this takes the users input and puts the user into the respective game mode
            if (user == "1")
            {
                WinningList.Add(0); WinningList.Add(0); // this adds locations into the winning score list so i can input the data i need to 
                while (Start == true) //this starts my while loop that allows multiple players to have a go 
                {
                    for (i = 0; i < 2; i++) // this loop allows 2 players to play
                    {
                        Console.WriteLine("Player " + (i + 1)); // this just tells the users what plays go it is
                        for (x = 0; x < 2; x++) // this for loop allows 2 dice to be rolled by a player 
                        {
                            _DiceFace = _Dice.Roll(); // this rolls the dice
                            DiceRolledlist.Add(_DiceFace); // this adds the dice to a collection
                            Console.WriteLine("any key to roll"); // this tells the user what to do to roll the dice
                            Console.ReadKey(true); // this removes the key the user presses from the terminal
                            Console.WriteLine("This is roll: " + (x + 1) + " " + DiceRolledlist[x]); // this tells the user what number they rolled
                        }
                        _result = DiceRolledlist[0] + DiceRolledlist[1]; // this adds the 2 dice rolls together
                        if (DiceRolledlist[0] == DiceRolledlist[1]) //this check if the 2 dice rolls were the same 
                        {
                            _result = _result * 2; //this doubles the total of the 2 dice rolls
                        }
                        if (i == 0) //this checks which players turn it was and adds the score to the repective players score
                        {
                            WinningList[0] = WinningList[0] + _result; // this adds the result to the winning score location
                            highestScore.HighestScoreIncrese(WinningList[0], i); // this takes the location of the current score and the players turn into the stats class
                        }
                        if (i == 1) //this checks which players turn it was and adds the score to the repective players score
                        {
                            WinningList[1] = WinningList[1] + _result; // this adds the result to the winning score location
                            highestScore2.HighestScoreIncrese(WinningList[1], i); // this takes the location of the current score and the players turn into the stats class
                        }
                        if (_result == 7) // this checks the total of the dice rolls for a total of 7
                        {
                            if (WinningList[0] < WinningList[1]) // this checks if the whole game total against the opposite player
                            {
                                i = 0;
                                Console.WriteLine("Player " + 1 + " you win!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                Console.WriteLine("the winning score was: " + highestScore.GetHighestScore(i)); // this is the winning score for this round
                                Console.WriteLine("the highest score was: " + highestScore2.GetHighestScore((i+1))); //this is the highest score of the round
                                sevensouttest.SevensOutTesting(_result, DiceRolledlist[0], DiceRolledlist[1]); // this takes it to the testing class
                            }
                            if (WinningList[1] < WinningList[0]) // this checks if the whole game total against the opposite player
                            {
                                i = 1;
                                Console.WriteLine("Player " + 2 + " you win!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                Console.WriteLine("the winning score was: " + highestScore2.GetHighestScore(i)); // this is the winning score for this round
                                Console.WriteLine("the highest score was: " + highestScore.GetHighestScore((i-1))); //this is the highest score of the round
                                sevensouttest.SevensOutTesting(_result, DiceRolledlist[0], DiceRolledlist[1]); // this takes it to the testing class
                            }
                        }
                        Console.WriteLine(_result); // this tells the user what the total of their rolls were
                        DiceRolledlist.Clear(); //this clears the collection ready for the next loop
                        numberofplays.CounterIncrease(); // this increases the turn counter
                        //Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                    }
                }
            }
                        if (user == "2")
                        {
                            WinningList.Add(0); WinningList.Add(0);
                            while (Start == true)
                            {
                                for (y = 0; y < 2; y++)
                                {
                                    if (y == 0)
                                    {
                                        // dice roll for Player 1
                                        Console.WriteLine("Player 1");
                                        for (i = 0; i < 2; i++)
                                        {
                                            _DiceFace = _Dice.Roll();
                                            DiceRolledlist.Add(_DiceFace);
                                            Console.WriteLine("any key to roll");
                                            Console.ReadKey(true);
                                            Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                                        }
                                    }
                                    else
                                    {
                                        // dice roll for computer
                                        Console.WriteLine("Computers turn");
                                        for (i = 0; i < 2; i++)
                                        {
                                            _DiceFace = _Dice.Roll();
                                            DiceRolledlist.Add(_DiceFace);
                                            int Delay = 1000; // this is a feature i added to make it seem like the player is playing against a computer who is pressing a key like them
                                            Thread.Sleep(Delay); // this is a feature i added to make it seem like the player is playing against a computer who is pressing a key like them
                                            Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                                        }
                                    }
                                        //addition of both dice rolls
                                        _result = DiceRolledlist[0] + DiceRolledlist[1];

                                        //Doubling the total if both dice rolls are the same 
                                        if (DiceRolledlist[0] == DiceRolledlist[1])
                                        {
                                            _result = _result * 2;
                                        }

                                        // Depending on the player depends on what postion in the collection the result is added to
                                        if (y == 0)
                                        {
                                            WinningList[0] = WinningList[0] + _result;
                                            highestScore.HighestScoreIncrese(WinningList[0], y);
                                        }
                                        if (y == 1)
                                        {
                                            WinningList[1] = WinningList[1] + _result;
                                            highestScore2.HighestScoreIncrese(WinningList[1], y);
                                        }
                                        // if the result is equal to 7 depends on if there is a win or not
                                        if (_result == 7)
                                        {
                                    if (WinningList[0] < WinningList[1])
                                    {
                                        y = 0;
                                        Console.WriteLine("you win!");
                                        Console.WriteLine("the number of turns: "); numberofplays.NumberOfPlays();
                                        Console.WriteLine("the winning score was: " + highestScore.GetHighestScore(y));
                                        Console.WriteLine("the highest score was: " + highestScore2.GetHighestScore(y));
                                        sevensouttest.SevensOutTesting(_result, DiceRolledlist[0], DiceRolledlist[1]);
                                    }
                                    if (WinningList[1] < WinningList[0])
                                    {
                                        y = 1;
                                        Console.WriteLine("Computer wins ");
                                        Console.WriteLine("the number of turns: "); numberofplays.NumberOfPlays();
                                        Console.WriteLine("the winning score was: " + highestScore2.GetHighestScore(y));
                                        Console.WriteLine("the highest score was: " + highestScore.GetHighestScore(y));
                                        sevensouttest.SevensOutTesting(_result, DiceRolledlist[0], DiceRolledlist[1]);
                                    }
                                        }
                                    
                                    // this preps the next instance of the loop
                                    //Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                                    Console.WriteLine(_result);
                                    DiceRolledlist.Clear();
                                    highestScore.HighestScoreIncrese(_result,i);
                                }
                            }
                        }
                        else // this checks for a input that isn't 1 or 2 
                        {
                            SevensOut();
                        }
                    }
                
    
            
        
        
    
        /// <summary>
        /// this method is used to run the Three Or  More dice game
        /// </summary>
        public void ThreeOrMore()
        {
            // creates a testing object
            Testing threeormoretesting = new Testing();

            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
                if (user == "1")
                {
                WinningList.Add(0);WinningList.Add(0);
                WinningList.Add(0);
                while (Start == true)
                {
                    for (int y = 1; y < 3; y++)
                    {
                        //the dice rolls
                        Console.WriteLine("Player " + (y));
                        for (i = 0; i < 5; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                            Console.WriteLine("any key to roll");
                            Console.ReadKey(true);
                            Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

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
                                else
                                {
                                    y = y - 2;
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

                            }
                            if(i == 1)
                            {
                                highestScore2.HighestScoreIncrese(WinningList[y], i);

                            }
                            Console.WriteLine("Player "+(i+1)+" wins!");
                            Console.WriteLine("the number of turns was "+numberofplays.GetCounter());
                            if(i == 0)
                            {
                                Console.WriteLine("the winning score of player 1 was " + highestScore.GetHighestScore(i));
                            }
                            if(i == 1)
                            {
                                Console.WriteLine("the winning score for player 2 was " + highestScore2.GetHighestScore(i));
                            }
                            threeormoretesting.ThreeOrMoreTesting(WinningList[y], highestScore.GetHighestScore(i),highestScore2.GetHighestScore(i),i );

                        }
                        numberofplays.CounterIncrease();
                        Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                        x = 1;
                        i = 0;
                        Console.WriteLine(WinningList[y]);
                        DiceRolledlist.Clear();
                        Counter = 0;
                    }
                }

                }
                        if (user == "2")
                        {
                WinningList.Add(0); WinningList.Add(0);
                WinningList.Add(0); 
                while (Start == true)
                    {
                        for (int y = 1; y < 3; y++)
                        {
                            if (y == 1)
                            {
                                Console.WriteLine("Player 1");
                                for (i = 0; i < 5; i++)
                                {
                                    _DiceFace = _Dice.Roll();
                                    DiceRolledlist.Add(_DiceFace);
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
                                    _DiceFace = _Dice.Roll();
                                    DiceRolledlist.Add(_DiceFace);
                                    int Delay = 1000;
                                    Thread.Sleep(Delay);
                                    Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                                }
                            }
                            DiceRolledlist.Sort(); // this sorts the list

                        // using the counter for the points system 
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
                                        Console.WriteLine(i);
                                        Counter++;
                                    }
                                }
                            }
                            if (Counter >= 1)
                            {
                                if (Counter == 4)
                                {
                                // 5 of a kind will give the player 12 
                                Console.WriteLine("Player gets 12 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 12;

                            }
                                else if (Counter == 3)
                                {
                                // 4 of a kind will give the player 6 points
                                Console.WriteLine("Player gets 6 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 6;
                            }
                                else if (Counter == 2)
                                {
                                // 3 of a kind will give the player 3 points
                                Console.WriteLine("Player gets 3 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 3;
                            }
                                else if (Counter == 1)
                                {
                                // 2 of a kind will let the player re roll 
                                Console.WriteLine("Player to re-roll");
                                if (y == 1)
                                {
                                    y = y-1;
                                }
                                else
                                {
                                    y = y - 2;
                                }
                                
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Matching numbers");
                            }
                        // first to 20+ points win
                        if (WinningList[y]>=20)
                        {
                            highestScore.HighestScoreIncrese(WinningList[y], i);
                            if (y == 0)
                            {
                                highestScore.HighestScoreIncrese(WinningList[y], i);
                                Console.WriteLine("You win!!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                highestScore.GetHighestScore(i);
                                Console.WriteLine("the highest score was: " + highestScore.GetHighestScore(i));
                                Environment.Exit(0);
                            }
                            if (y == 1)
                            {
                                highestScore2.HighestScoreIncrese(WinningList[y], i);
                                Console.WriteLine("Computer Wins!!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                highestScore.GetHighestScore(i);
                                Console.WriteLine("the highest score was: " + highestScore2.GetHighestScore(i));
                                Environment.Exit(0);
                            }
                        }
                            numberofplays.CounterIncrease();
                            x = 1;
                            i = 0;
                            DiceRolledlist.Clear();
                            Counter = 0;
                        }
                    }

                }
            
                // if input isnt in correct format re call three or more
                else
                {
                    ThreeOrMore();
                }
            }
        }
    }
