using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment2
{
    public class Dice
    {
        //creates the random 
        private static Random _random = new Random();
        // creates the variable 
        private int _Dvalue; // this creates the die value 
        //performs the roll
        public int Roll()
        {
            _Dvalue = _random.Next(1, 7); // this creates a random number between 1 and 6 
            return _Dvalue; // this returns the random number 
        }
    }
}
