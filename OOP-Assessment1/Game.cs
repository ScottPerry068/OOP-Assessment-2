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
        public void Start()
        {

            Dice D1 = new Dice();
            Dice D2 = new Dice();
            Dice D3 = new Dice();
            int D1Face = D1.Roll();
            int D2Face = D2.Roll();
            int D3Face = D3.Roll();

            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey();
            Console.WriteLine("The value of Dice one is: " + D1Face);
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey();
            Console.WriteLine("The value of Dice one is: " + D2Face);
            Console.WriteLine("Press any key to roll the dice"); Console.ReadKey();
            Console.WriteLine("The value of Dice one is: " + D3Face);
            int result = D1Face + D2Face + D3Face;
            Console.WriteLine("The result of the three Dice is: " + result);
        }
        
    }
}
