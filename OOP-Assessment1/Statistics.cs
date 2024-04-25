using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    /// <summary>
    /// This holds all my counters features for turns and highest score
    /// </summary>
    public class Statistics
    {
        private static int _totalcounter = 0;

        public static int highestscore = 0;

        public static int highestscore2 = 0;

        public int P1highestscore;

        public int P2highestscore;

        public int Blank = 0;

        public static int PlaysCounter
        {
            get { return _totalcounter; }
            set { _totalcounter = value; }
        }

        public static int HighestScoreCount
        {
            get { return highestscore; }
            set { highestscore = value; }
        }

        public static int HighestScoreCount2
        {
            get { return highestscore2; }
            set { highestscore2 = value; }
        }

        public void CounterIncrease()
        {
            _totalcounter++;
        }

        public int GetCounter()
        {
            return _totalcounter;
        }

        public int GetHighestScore(int Player)
        {
            if (Player == 0)
            {
                return P1highestscore;
            }
            if (Player == 1)
            {
                return P2highestscore;

            }
            else
            {
                return Blank;
            }
        }
    }

    /// <summary>
    /// This does the highest score of each game
    /// </summary>
        public class HighestScoreCounter:Statistics
        {
        public HighestScoreCounter()
        {
            highestscore = 0;highestscore2 = 0;
        }

        public void HighestScoreIncrese(int result,int player)
        {
            if (player == 0)
            {
                P1highestscore = highestscore + result;
                Console.WriteLine("P1");

            }
            if (player == 1)
            {
                P2highestscore = highestscore2 + result;
                Console.WriteLine("P2");
            }
        }
        }
    /// <summary>
    /// This does the number of turns for each game
    /// </summary>
        public class NumberOfPlaysCounter: Statistics
        {
            public void NumberOfPlays()
            {
                GetCounter();
        }
    }
}