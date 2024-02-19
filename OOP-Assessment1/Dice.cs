using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Dice
    {
        private static Random random = new Random(); // this creates the random
        private int Dvalue; // this creates the die value 

        public int Roll() // this is the method i use to create the roll enviroment 
        {
            Dvalue = random.Next(1, 6); // this creates a random number between 1 and 6 
            return Dvalue; // this returns the random number 
        }
    }
}
