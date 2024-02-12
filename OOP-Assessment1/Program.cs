using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    internal class Program
    {
            public static void Main(string[] args)
            {
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();
            int D1Value = D1Value.roll();
            Console.WriteLine("The value of Dice one is: "D1Value);
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey();
            int D2Value = D2Value.roll();
            Console.WriteLine("The value of Dice one is: "D2Value);
            Console.WriteLine("Press any key to roll the dice");Console.ReadKey();
            int D3Value = D3Value.roll();
            Console.WriteLine("The value of Dice one is: "D3Value);
            int result = D1Value + D2Value + D3Value;
            Console.WriteLine("The result of the three Dice is: " + result)







            //int dice1;
            //Random random = new Random();
            //Console.WriteLine("Press any key to roll the dice");
            //Console.ReadKey();
            //dice1 = random.Next(1, 7);
            //Console.WriteLine("Dice 1 Rolled a: " + dice1);
            //int dice2;
            //Console.WriteLine("Press any key to roll the dice");
            //Console.ReadKey();
            //dice2 = random.Next(1, 7);
            //Console.WriteLine("Dice 2 Rolled a: " + dice2);
            //int dice3;
            //Console.WriteLine("Press any key to roll the dice");
            //Console.ReadKey();
            //dice3 = random.Next(1, 7);
            //Console.WriteLine("Dice 3 Rolled a: " + dice3);
            //int result = dice1 + dice2 + dice3;
            //Console.WriteLine("The result of the three dice rolls is: " +  result);
        }
        }
    }

}

