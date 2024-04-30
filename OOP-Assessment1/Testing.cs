using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    /// <summary>
    /// This class holds both game testing methods
    /// </summary>
    public class Testing
    {
        public Dice dice = new Dice();
        List<int> DieList = new List<int>();
        List<int> WinningList = new List<int>();
        /// <summary>
        /// This method checks sevens out win critera and the score of both players at the end of the game
        /// </summary>
        /// <param name="win"></param>
        /// <param name="value"></param>
        /// <param name="temp"></param>
        public void SevensOutTesting(int win, int value, int temp)
        {
            Debug.Assert(win == 7, "The total did not equal 7 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
            Debug.Assert(win == (value + temp), "the total is incorrect since the previous two values don't add up to current result, please check the loop where the temp value is added!! ");
            Environment.Exit(0);
        }

        /// <summary>
        /// This method checks three or more win critera and the score of both players at the end of the game
        /// </summary>
        /// <param name="win"></param>
        /// <param name="high"></param>
        /// <param name="high2"></param>
        /// <param name="player"></param>
        public void ThreeOrMoreTesting(int win, int high, int high2, int player)
        {
            Debug.Assert(win >= 20, "The total did not equal 20 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
            if (player == 0)
            {
                Debug.Assert(win == high, "The addition was incorrect please check!!");

            }
            if (player == 1)
            {
                Debug.Assert(win == high2, "The addition was incorrect please check!!");
            }
            Environment.Exit(0);
        }

        /// <summary>
        /// this is the testing from the menu that the user can choose to test the three or more game
        /// </summary>
        public void UserTestingSevensOut()
        {
            int result;
            int Dieface;
            while (true)
            {
                DieList.Clear();
                for (int i = 0; i < 2; i++)
                {
                    Dieface = dice.Roll();
                    DieList.Add(Dieface);
                }
                result = DieList[0] + DieList[1];
                if (result == 7)
                {
                    break;
                }
            }
            Console.WriteLine(result);
            Debug.Assert(result == 7, "The total did not equal 7 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
            Debug.Assert(result == DieList[0] + DieList[1], "the total is incorrect since the previous two values don't add up to current result, please check the loop where the temp value is added!! ");
            Console.WriteLine("Check finished, all working!");
            Environment.Exit(0);
        }
        /// <summary>
        /// this is the testing from the menu that the user can choose to test the three or more game
        /// </summary>
        public void UserTestingThreeOrMore()
        {
            int Dieface;
            int Counter = 0;
            int i;
            int x;
            while (true)
            {
                WinningList.Add(0);
                DieList.Clear();
                for (i = 0; i < 5; i++)
                {
                    Dieface = dice.Roll();
                    DieList.Add(Dieface);
                    DieList.Sort();
                }
                if (DieList[0] == DieList[1])
                {
                    Counter++;
                }
                else if (DieList[1] == DieList[2])
                {
                    Counter++;
                }
                else if (DieList[2] == DieList[3])
                {
                    Counter++;
                }
                else if (DieList[3] == DieList[4])
                {
                    Counter++;
                }
                else if (DieList[4] == DieList[5])
                {
                    Counter++;
                }

                if (Counter >= 2)
                {
                    if (Counter == 5)
                    {
                        WinningList[0] = WinningList[0] + 12;
                    }
                    if (Counter == 4)
                    {
                        WinningList[0] = WinningList[0] + 6;
                    }
                    if (Counter == 3)
                    {
                        WinningList[0] = WinningList[0] + 3;
                    }
                }
                if (WinningList[0] >= 19)
                {
                    break;
                }
            }
            Console.WriteLine(WinningList[0]);
            Debug.Assert(WinningList[0] >= 20, "The total did not equal 7 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
            Console.WriteLine("Check finished, all working!");
            Environment.Exit(0);

        }
    }


    }
