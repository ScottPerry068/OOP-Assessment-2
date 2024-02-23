using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Dice
    {
        //creates the random object
        private static Random random = new Random();
        // creates the variable 
        private int Dvalue; // this creates the die value 
        //performs the roll
        public int Roll()
        {
            Dvalue = random.Next(1, 7); // this method creates a random number between 1 and 6 
            return Dvalue; // this returns the random number 
        }
    }
}
