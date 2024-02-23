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
        private int D1Face;private int D2Face;private int D3Face; // this creates the rolled dice value
        private Dice D1 = new Dice(); private Dice D2 = new Dice();private Dice D3 = new Dice(); // this creates the dice 
        private int result; //this creates the result
        public void Start() // this method is just used to run the dice game
        {
            D1Face = D1.Roll(); //this Rolls the first dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device 
            Console.WriteLine("The value of Dice one is: " + D1Face); // this line prints the face value for the user to see what the dice rolled
            D2Face = D2.Roll(); // this rolls the second dice 
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device
            Console.WriteLine("The value of Dice two is: " + D2Face); // this line prints the face value for the user to see what the dice rolled
            D3Face = D3.Roll(); //this rolls the third dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(true); // this line prompts the user to roll the dice by hitting a key on their device 
            Console.WriteLine("The value of Dice three is: " + D3Face); // this line prints the face value for the user to see what the dice rolled
            result = D1Face + D2Face + D3Face; // this line does the addtiion for all the faces rolled by the three dice 
            Console.WriteLine("The result of the three Dice is: " + result); // this tells the user the result of the three faces added togther

        }
        
    }
}
