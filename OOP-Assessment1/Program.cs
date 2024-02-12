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
            public static void Main()
            {
            Game game = new Game();
            Testing gametest = new Testing();
            game.Start();
            gametest.Test();
            }
    }
}

