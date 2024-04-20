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
    public class Testing:Game
    {
        public void SevensOutTesting(int win)//, int total)
        {
            public void SevensOutWin(int win) {
                Debug.Assert(win == 7, "The total did not equal 7 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
                Environment.Exit(0);
            }
        }   

        public void ThreeOrMoreTesting(int win)
        {
            void ThreeOrMoreWin(int win)
            {
                Debug.Assert(win >= 20, "The total did not equal 20 when a win was made, So this means the Win criteria is wrong!! Please look over the win criteria!!");
                Environment.Exit(0);
            }
        }

        

    }
}
