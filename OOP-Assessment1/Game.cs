using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Game
    {
        // creates the variables
        private int _DiceFace;// this variable is created to hold the dice values
        private int _result; //this creates the result
        private Dice _Dice = new Dice();/// this creates the dice objects
        public void SevensOut() // this method is just used to run the dice game
        {
            Console.WriteLine("1: Human Player ");
            Console.WriteLine("2: Computer Player");
            var User = Console.ReadLine();
            int user = Convert.ToInt32(User);
            int Temp = 0;
            List<int> DiceRolledlist = new List<int>();
            if (user == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    _DiceFace = _Dice.Roll();
                    DiceRolledlist.Add(_DiceFace);
                }
                for (int i = 0; i < 2; i++)
                {
                    int Value = DiceRolledlist[i];
                    _result = Value + Temp;
                    Temp = _result;
                }
                //Console.WriteLine("This is the result of 3 dice rolls " + _result);
            }
            if (user == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    _DiceFace = _Dice.Roll();
                    DiceRolledlist.Add(_DiceFace);
                }
                for (int i = 0; i < 2; i++)
                {
                    int Value = DiceRolledlist[i];
                    _result = Value + Temp;
                    Temp = _result;
                }
            }
        }

        public void ThreeOrMore()
        {
            int Temp = 0;
            List<int> DiceRolledlist = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                _DiceFace = _Dice.Roll();
                //Console.WriteLine(_DiceFace);
                DiceRolledlist.Add(_DiceFace);
            }
            for (int i = 0; i < 3; i++)
            {
                int Value = DiceRolledlist[i];
                //Console.WriteLine("This is value " + Value);
                _result = Value + Temp;
                Temp = _result;
                //Console.WriteLine("This is temp " + Temp);
                //Console.WriteLine("This is result " + _result);
            }
            Console.WriteLine("This is the result of 3 dice rolls " + _result);
        }
    }
}
