using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Assessment2
{
    public class Game
    {
        // creates the variables
        private static int _DiceFace;// this variable is created to hold the dice values
        private int _result; //this creates the result
        private static Dice _Dice = new Dice();// this creates the dice objects

        //Global variables
        bool Start = true;
        int i = 0;
        int x = 1;
        int Counter = 0;
        int Temp = 0;
        int Value;
        List<int> DiceRolledlist = new List<int>();
        List<int> WinningList = new List<int>();

        // this method is just used to runs the sevens out dice game
        public void SevensOut()
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
                if (user == "1")
                {
                    while (Start == true)
                    {
                        for (i = 0 ; i < 2; i++)
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
                                _result = Value + Temp;
                                Temp = _result;
                                WinningList.Add(_result);
                                if (_result == 7)
                                {
                                    Console.WriteLine("Player " + (i + 1) + " you win!");
                                    Environment.Exit(0);
                                }
                                if (DiceRolledlist[0] == DiceRolledlist[1])
                                {
                                    _result = _result * 2;
                                }
                            }
                            Console.WriteLine(_result);
                            DiceRolledlist.Clear();
                            Value = 0;
                            Temp = 0;
                        }
                        i = 0;
                        x = 0;
                    }
                }

                if (user == "2")
                {
                    while (Start == true)
                    {
                        for (i = 0; i < 2; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                        }
                        for (i = 0; i < 2; i++)
                        {
                            Console.WriteLine("any key to roll");
                            Console.ReadKey(true);
                            Value = DiceRolledlist[i];
                            Console.WriteLine("Dice roll " + (i + 1) + ": " + Value);
                            _result = Value + Temp;
                            Temp = _result;
                            if (DiceRolledlist[0] == DiceRolledlist[1])
                            {
                                _result = _result * 2;
                            }

                            if (_result == 7)
                            {
                                Console.WriteLine("you win!");
                                Environment.Exit(0);
                            }
                        }
                        Console.WriteLine(_result);
                        WinningList.Add(_result);
                        DiceRolledlist.Clear();
                        Value = 0;
                        Temp = 0;

                        // Computer play
                        Console.WriteLine("Computers turn: ");
                        for (i = 0; i < 2; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                        }
                        for (i = 0; i < 2; i++)
                        {
                            Value = DiceRolledlist[i];
                            int Delay = 1000;
                            Thread.Sleep(Delay);
                            Console.WriteLine("Computer rolled " + (i + 1) + ": " + Value);
                            _result = Value + Temp;
                            Temp = _result;
                            if (DiceRolledlist[0] == DiceRolledlist[1])
                            {
                                _result = _result * 2;
                            }
                            if (_result == 7)
                            {
                                Console.WriteLine("Computer wins!");
                                Environment.Exit(0);
                            }
                        }
                        Console.WriteLine(_result);
                        WinningList.Add(_result);
                        DiceRolledlist.Clear();
                        Value = 0;
                        Temp = 0;
                    }
                    i = 0;
                }
                else
                {
                    SevensOut();
                }
            }
        

        public void ThreeOrMore()
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
                if (user == "1")
                {
                while (Start == true)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        Console.WriteLine("Player " + (y + 1));
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
                            }
                            else if (Counter == 3)
                            {
                                Console.WriteLine("PLayer gets 3 points");
                            }
                            else if (Counter == 2)
                            {
                                Console.WriteLine("PLayer gets 3 points");
                            }
                            else if (Counter == 1)
                            {
                                Console.WriteLine("PLayer to re-roll");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Matching numbers");
                        }
                        x = 1;
                        i = 0;
                        DiceRolledlist.Clear();
                    }
                }

                }
                        if (user == "2")
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                _DiceFace = _Dice.Roll();
                                DiceRolledlist.Add(_DiceFace);
                            }
                            for (int i = 0; i < 3; i++)
                            {
                                Value = DiceRolledlist[i];
                                _result = Value + Temp;
                                Temp = _result;
                            }
                            Console.WriteLine("This is the result of 3 dice rolls " + _result);
                        }
                else
                {
                    ThreeOrMore();
                }
            }
        }
    }
