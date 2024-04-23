using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public void ThreeOrMoreTesting(int win, int high)
        {
                Debug.Assert(win >= 20, "The total did not equal 20 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
                Debug.Assert(win == high, "The addition was incorrect please check!!") ;
                Environment.Exit(0);
        }

        

    }
}
