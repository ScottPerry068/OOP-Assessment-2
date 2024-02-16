using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Program
    {
        public static void Main() // this method runs the program as an entireity 
        {
            Game game = new Game(); // this created the 
            Testing gametest = new Testing(); 
            game.Start(); // this calls the method within game to run the dice rolls
            gametest.Testsum();
            gametest.Test(); // this calls the method within testing to test the dice rolls 
        }
    }
}

