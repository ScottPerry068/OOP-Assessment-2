﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Assessment2
{
    public class Game
    {
        // creates the variables for functionality
        private static int _DiceFace;// this variable is created to hold the dice values
        private int _result; //this creates the result
        private static Dice _Dice = new Dice();// this creates the dice objects

        //Creates Objects for inheritence
        NumberOfPlaysCounter numberofplays = new NumberOfPlaysCounter();
        HighestScoreCounter highestScore = new HighestScoreCounter();

        //Global variables Mainly for loops
        bool Start = true;
        int i = 0;
        int x = 1;
        int Counter = 0;
        int Temp = 0;
        int Value;
        int y = 0;

        //Global Lists
        List<int> DiceRolledlist = new List<int>();
        List<int> WinningList = new List<int>();

        // this method is just used to runs the sevens out dice game
        public void SevensOut()
        {
            //creates a Testing object
            Testing sevensouttest = new Testing();

            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
            if (user == "1")
            {
                while (Start == true)
                {
                    for (i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Player " + (i + 1));
                        for (x = 0; x < 2; x++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                        }
                        for (x = 0; x < 2; x++)
                        {
                            Console.WriteLine("any key to roll");
                            Console.ReadKey(true);
                            Value = DiceRolledlist[x];
                            Console.WriteLine("This is roll: " + (x + 1) + " " + Value);
                            _result = DiceRolledlist[0] + DiceRolledlist[1];
                        }
                        if (_result == 7)
                        {
                            Console.WriteLine("Player " + (i + 1) + " you win!");
                            numberofplays.NumberOfPlays();
                            Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                            highestScore.GetHighestScore();
                            Console.WriteLine("the highest score was: " + highestScore.GetHighestScore());
                            sevensouttest.SevensOutTesting(_result, DiceRolledlist[0], DiceRolledlist[1]);
                        }
                        if (DiceRolledlist[0] == DiceRolledlist[1])
                        {
                            _result = _result * 2;
                        }
                    }

                    Console.WriteLine(_result);
                    highestScore.HighestScoreIncrese(_result);
                    DiceRolledlist.Clear();
                    numberofplays.CounterIncrease();
                    Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                }
            }
        

                if (user == "2")
                {
                while (Start == true)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        if (y == 0)
                        {
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
                            Console.WriteLine("Computers turn");
                            for (i = 0; i < 2; i++)
                            {
                                _DiceFace = _Dice.Roll();
                                DiceRolledlist.Add(_DiceFace);
                                int Delay = 1000;
                                Thread.Sleep(Delay);
                                Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                            }
                        }

                        for (int z = 0; z < 2; z++)
                        {
                            Value = DiceRolledlist[z];
                            _result = DiceRolledlist[0]+DiceRolledlist[1];
                            if (DiceRolledlist[0] == DiceRolledlist[1])
                            {
                                _result = _result * 2;
                            }
                            if (_result == 7)
                            {
                                if (y == 0)
                                {
                                    Console.WriteLine("You win!");
                                }
                                if (y == 1)
                                {
                                    Console.WriteLine("Computer wins!");
                                }
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                highestScore.GetHighestScore();
                                Console.WriteLine("the highest score was: " + highestScore.GetHighestScore());
                                sevensouttest.SevensOutTesting(_result, DiceRolledlist[0],DiceRolledlist[1]);
                            }
                        }
                        numberofplays.CounterIncrease();
                        Console.WriteLine("this is turn:  " + numberofplays.GetCounter());
                        Console.WriteLine(_result);
                        DiceRolledlist.Clear();
                        highestScore.HighestScoreIncrese(_result);
                    }
                }
                }
                else
                {
                    SevensOut();
                }
            }
        public void ThreeOrMore()
        {
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
                        Console.WriteLine("Player " + (y));
                        for (i = 0; i < 5; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                            Console.WriteLine("any key to roll");
                            Console.ReadKey(true);
                            Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                        }
                        DiceRolledlist.Sort();
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
                        if (Counter >= 1)
                        {
                            if (Counter == 4)
                            {
                                Console.WriteLine("Player gets 12 points");
                                WinningList[y] = WinningList[y] + 12;
                            }
                            else if (Counter == 3)
                            {
                                Console.WriteLine("Player gets 6 points");
                                WinningList[y] = WinningList[y] + 6;
                            }
                            else if (Counter == 2)
                            {
                                Console.WriteLine("Player gets 3 points");
                                WinningList[y] = WinningList[y] + 3;
                            }
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
                        else
                        {
                            Console.WriteLine("No Matching numbers");
                        }
                        if (WinningList[y] >= 20)
                        {
                            highestScore.HighestScoreIncrese(WinningList[y]);
                            Console.WriteLine("Player "+(i+1)+" wins!");
                            Console.WriteLine("the number of turns was "+numberofplays.GetCounter());
                            Console.WriteLine("the total score of both players was "+ highestScore.GetHighestScore());
                            threeormoretesting.ThreeOrMoreTesting(WinningList[y], highestScore.GetHighestScore());

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
                            DiceRolledlist.Sort();
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
                                Console.WriteLine("Counter is working");
                                if (Counter == 4)
                                {
                                    Console.WriteLine("Player gets 12 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 12;

                            }
                                else if (Counter == 3)
                                {
                                    Console.WriteLine("Player gets 6 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 6;
                            }
                                else if (Counter == 2)
                                {
                                    Console.WriteLine("Player gets 3 points");
                                    Console.WriteLine(y);
                                    WinningList[y] = WinningList[y] + 3;
                            }
                                else if (Counter == 1)
                                {
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
                        if (WinningList[y]>=20)
                        {
                            highestScore.HighestScoreIncrese(WinningList[y]);
                            if (y == 0)
                            {
                                Console.WriteLine("You win!!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                highestScore.GetHighestScore();
                                Console.WriteLine("the highest score was: " + highestScore.GetHighestScore());
                                Environment.Exit(0);
                            }
                            if (y == 1)
                            {
                                Console.WriteLine("Computer Wins!!");
                                Console.WriteLine("the number of turns: " + numberofplays.GetCounter());
                                highestScore.GetHighestScore();
                                Console.WriteLine("the highest score was: " + highestScore.GetHighestScore());
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
            
                else
                {
                    ThreeOrMore();
                }
            }
        }
    }
