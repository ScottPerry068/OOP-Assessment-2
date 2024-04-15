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
        // creates the variables
        private static int _DiceFace;// this variable is created to hold the dice values
        private int _result; //this creates the result
        private static Dice _Dice = new Dice();/// this creates the dice objects
        bool Start = true;
        int i = 0;
        int x = 1;
        int Counter = 0;
        public void SevensOut() // this method is just used to run the dice game
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
            int Temp = 0;
            int Value;
            List<int> DiceRolledlist = new List<int>();
            List<int> WinningList = new List<int>();
            try
            {
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
            }
            catch(Exception)
            {
                Console.WriteLine("incorrect format try again");
                SevensOut();
            }
        }
        

        public void ThreeOrMore()
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
            int Temp = 0;
            int Value;
            List<int> DiceRolledlist = new List<int>();
            List<int> WinningList = new List<int>();
            try
            {

                if (user == "1")
                {
                    while (Start == true)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(5);
                            Console.WriteLine("this is dice roll : " + DiceRolledlist[i]);

                        }
                        DiceRolledlist.Sort();
                        for (x = 1; x < 5; x++)
                        {
                            i = 0;
                            //Console.WriteLine(DiceRolledlist[0]);
                            //Console.WriteLine(DiceRolledlist[1]);
                            //Console.WriteLine(DiceRolledlist[2]);
                            //Console.WriteLine(DiceRolledlist[3]);
                            //Console.WriteLine(DiceRolledlist[4]);
                            Console.WriteLine("Loop 1");
                            if (DiceRolledlist[i] == DiceRolledlist[x])
                            {
                                Console.WriteLine(i);
                                Console.WriteLine(x);
                                Counter++;
                                
                            }

                        }
                        x = 1;
                        for (i = 1; i < 4; i++)
                        {
                            //Console.WriteLine(DiceRolledlist[0]);
                            //Console.WriteLine(DiceRolledlist[1]);
                            //Console.WriteLine(DiceRolledlist[2]);
                            //Console.WriteLine(DiceRolledlist[3]);
                            //Console.WriteLine(DiceRolledlist[4]);
                            Console.WriteLine("Loop 2");
                            if (DiceRolledlist[x] == DiceRolledlist[i + 1])
                            {
                                Console.WriteLine(i);
                                Console.WriteLine(x);
                                Counter++;
                            }
                        }
                        for (i = 3; i < 5; i++)
                        {
                            //Console.WriteLine(DiceRolledlist[0]);
                            //Console.WriteLine(DiceRolledlist[1]);
                            //Console.WriteLine(DiceRolledlist[2]);
                            //Console.WriteLine(DiceRolledlist[3]);
                            //Console.WriteLine(DiceRolledlist[4]);
                            Console.WriteLine("Loop 3");
                            if (DiceRolledlist[x + 1] == DiceRolledlist[i])
                            {
                                Console.WriteLine(i);
                                Console.WriteLine(x);
                                Counter++;
                            }
                        }
                        for (i = 3; i < 4; i++)
                        {
                            //Console.WriteLine(DiceRolledlist[0]);
                            //Console.WriteLine(DiceRolledlist[1]);
                            //Console.WriteLine(DiceRolledlist[2]);
                            //Console.WriteLine(DiceRolledlist[3]);
                            //Console.WriteLine(DiceRolledlist[4]);
                            //Console.WriteLine("Loop 4");
                            if (DiceRolledlist[x] == DiceRolledlist[i+1])
                            {
                                Console.WriteLine(i);
                                Counter++;
                            }
                        }
                        if (Counter >= 1)
                        {
                            Console.WriteLine("Counter is working");
                            if (Counter == 4)
                            {
                                Console.WriteLine("Player gets 12 points");
                                Environment.Exit(0);
                            }
                            else if(Counter == 3)
                            {
                                Console.WriteLine("PLayer gets 3 points");
                                Environment.Exit(0);
                            }
                            else if(Counter == 2)
                            {
                                Console.WriteLine("PLayer gets 3 points");
                                Environment.Exit(0);
                            }
                            else if (Counter == 1)
                            {
                                Console.WriteLine("PLayer to re-roll");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Matching numbers");
                            Environment.Exit(0);
                        }
                        x = 1;
                        i = 0;
                        DiceRolledlist.Clear();
                        Environment.Exit(0);
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
                    }
                
            
            catch (FormatException)
            {
                Console.WriteLine("incorrect format or invalid number!!");
                ThreeOrMore();
            }
        }
    }
}
