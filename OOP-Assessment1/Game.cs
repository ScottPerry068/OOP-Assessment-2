using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Assessment2
{
    /// <summary>
    /// This class holds both games (SevensOut and ThreeOrMore)
    /// </summary>
    public class Game
    {

        //Creates Objects for Stats inheritence
        public NumberOfPlaysCounter numberofplays = new NumberOfPlaysCounter();
        public HighestScoreCounter highestScore = new HighestScoreCounter();
        public HighestScoreCounter highestScore2 = new HighestScoreCounter();

        // creates the variables for functionality
        public static int DiceFace;// this variable is created to hold the dice values
        public int result; //this creates the result
        public static Dice Dice = new Dice();// this creates the dice objects

        //Global variables Mainly for loops
        public bool Start = true;
        public int i = 0;
        public int x = 1;
        public int y = 0;
        public int Counter = 0;

        //Global Lists
        public List<int> DiceRolledlist = new List<int>();
        public List<int> WinningList = new List<int>();
    }
}
        
