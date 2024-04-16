using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    public class Statistics
    {
        private static int _totalplayscounter = 0;
        public static int PlaysCounter
        {
            get { return _totalplayscounter; }
            set { _totalplayscounter = value; }
        }

        private static int _totalscorecounter = 0;
        public static int HighestScoreCount
        {
            get { return _totalscorecounter; }
            set { _totalscorecounter = value; }
        }

        public class HighestScoreClass : Statistics
        {
            public int HighestScore()
            {
                Console.WriteLine("the Highest score was: " + HighestScoreCount);
                return HighestScoreCount;
            }
        }
        public class NumberOfPlaysClass : Statistics
        {
            public int NumberOfPlays()
            {
                Console.WriteLine("the number of turns was: " + PlaysCounter);
                return Game.PlaysCounter;
            }
        }
    }
}

        
    


