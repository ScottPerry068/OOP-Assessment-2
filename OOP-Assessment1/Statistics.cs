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
        private static int _totalcounter = 0;
        public static int highestscore = 0;
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

        public void CounterReset()
        {
            _totalcounter = 0;
        }
        public void CounterIncrease()
        {
            _totalcounter++;
        }
        public int GetCounter()
        {
            return _totalcounter;
        }

        public int GetHighestScore()
        {
            return highestscore;
        }
    }


        public class HighestScoreCounter:Statistics
        {
        public HighestScoreCounter()
        {
            highestscore = 0;
        }

        public void HighestScoreIncrese(int result, int i)
        {
            highestscore = highestscore + result;
        }
        }
        public class NumberOfPlaysCounter: Statistics
        {
            public void NumberOfPlays()
            {
                CounterIncrease();
            }
        }
}


        
    


