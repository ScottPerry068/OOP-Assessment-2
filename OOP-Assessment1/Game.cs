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
        private int _D1Face;private int _D2Face;private int _D3Face; // this variabl is created to hold the dice values
        private int _result; //this creates the result
        // creates the objects
        private Dice _D1 = new Dice(); private Dice _D2 = new Dice();private Dice _D3 = new Dice(); // this creates the dice objects

        // runs the game
        public void Start() // this method is just used to run the dice game
        {
            _D1Face = _D1.Roll(); //this Rolls the first dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device 
            Console.WriteLine("The value of Dice one is: " + _D1Face); // this line prints the face value for the user to see what the dice rolled
            _D2Face = _D2.Roll(); // this rolls the second dice 
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device
            Console.WriteLine("The value of Dice two is: " + _D2Face); // this line prints the face value for the user to see what the dice rolled
            _D3Face = _D3.Roll(); //this rolls the third dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device 
            Console.WriteLine("The value of Dice three is: " + _D3Face); // this line prints the face value for the user to see what the dice rolled
            _result = _D1Face + _D2Face + _D3Face; // this line does the addtiion for all the faces rolled by the three dice 
            Console.WriteLine("The result of the three Dice is: " + _result); // this tells the user the result of the three faces added togther

        }
        
    }
}
