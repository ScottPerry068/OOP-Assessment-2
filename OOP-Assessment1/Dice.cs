using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Dice
    {
        private static Random random = new Random(); // this creates a class called random
        private int Dvalue; 

        public int Roll() // this is the method i use to create the roll enviroment 
        {
            Dvalue = random.Next(1, 6); // this creates a random number between 1 and 6 
            return Dvalue; // this returns the random number 
        }
    }
}
