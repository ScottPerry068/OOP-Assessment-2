using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Dice
    {
        public int Roll()
        {
            Random random = new Random();
            int Dvalue = random.Next(1, 6);
            return Dvalue;
        }
    }
}
