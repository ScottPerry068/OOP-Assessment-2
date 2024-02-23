using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Testing
    {
        // creates the variables
        private int D1Face;private int D2Face; private int D3Face; // this creates the Dice face variables for testing
        private int result; // this creates the result variable

        // creates the objects
        private Dice D1 = new Dice();private Dice D2 = new Dice();private Dice D3 = new Dice(); // this creates the new dice objects for testing (object instantiation)

        // runs the face check 
        public void Test()
        {
            int D1Face = D1.Roll(); // This calls the roll method to give the dice a value 
            Debug.Assert(D1Face >= 1 && D1Face <= 6, "D1 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            int D2Face = D2.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(D2Face >= 1 && D2Face <= 6, "D2 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            int D3Face = D3.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(D3Face >= 1 && D3Face <= 6, "D3 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
        }   
        
        //runs the sum check
        public void Testsum()
        {
            D1Face = D1.Roll();D2Face = D2.Roll();D3Face = D3.Roll();//this rolls the three dice
            result = D1Face + D2Face + D3Face;//this does the addition for the three dice faces 
            Debug.Assert(result == D1Face+D2Face+D3Face, "The sums don't match, there is an issue!");//this checks to see if the sum of the three faces is correct
        }

        

    }
}
