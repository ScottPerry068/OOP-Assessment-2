﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Game
    {
        public void Start()
        {
            Dice D1 = new Dice(); Dice D2 = new Dice(); Dice D3 = new Dice(); // These create my three dice objects 
            int D1Face = D1.Roll(); //this Rolls the first dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(); // this line prompts the user to roll the dice by hitting a key on their device 
            Console.WriteLine("The value of Dice one is: " + D1Face); // this line prints the face value for the user to see what the dice rolled
            int D2Face = D2.Roll(); // this rolls the second dice 
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(); // this line prompts the user to roll the dice by hitting a key on their device
            Console.WriteLine("The value of Dice one is: " + D2Face); // this line prints the face value for the user to see what the dice rolled
            int D3Face = D3.Roll(); //this rolls the third dice
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey(); // this line prompts the user to roll the dice by hitting a key on their device
            Console.WriteLine("The value of Dice one is: " + D3Face); // this line prints the face value for the user to see what the dice rolled
            int result = D1Face + D2Face + D3Face; // this line does the addtiion for all the faces rolled by the three dice 
            Console.WriteLine("The result of the three Dice is: " + result); // this tells the user the result of the three faces added togther
        }
        
    }
}
