using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Dice
    {
        public int roll()
        {
            Random random = new Random();
            int Dicevalue = random.(1, 7);
            return Dicevalue;
        }
    }
}
