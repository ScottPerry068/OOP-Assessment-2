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
        private static Dice _Dice = new Dice();/// this creates the dice objects
        bool Start = true;
        public void SevensOut() // this method is just used to run the dice game
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var user = Console.ReadLine();
            int Temp = 0;
            int Value;
            List<int> DiceRolledlist = new List<int>();
            List<int> WinningList = new List<int>();
            int i = 0;
            int x = 0;
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
                while (Start == true){
                    if (user == "1")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            _DiceFace = _Dice.Roll();
                            DiceRolledlist.Add(_DiceFace);
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            int x = 1;
                            if (DiceRolledlist[i] == DiceRolledlist[(x + i)]) {
                                Console.WriteLine(x + " : " + i + " yeahhhhhhhhhhhhhh babyyyyyyyyyy!!!!");
                                WinningList.Add(x);
                                Console.WriteLine(WinningList[0]); //+ WinningList[1] + WinningList[2]) ;
                                if (WinningList[0] == 3)
                                {
                                    Console.WriteLine("Player [BLANK] has got 3 points!!");
                                }
                            }
                        }
                        Console.WriteLine("This is the result of 3 dice rolls " + _result);
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
            }
            catch (FormatException)
            {
                Console.WriteLine("incorrect format or invalid number!!");
                ThreeOrMore();
            }
        }
    }
}
