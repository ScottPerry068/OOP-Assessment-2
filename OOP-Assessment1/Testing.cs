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
        private int _D1Face;private int _D2Face; private int _D3Face; // this creates the Dice face variables for testing
        private int _result; // this creates the result variable

        // creates the objects
        private Dice _D1 = new Dice();private Dice _D2 = new Dice();private Dice _D3 = new Dice(); // this creates the new dice objects for testing (object instantiation)

        // runs the face check 
        public void Test()
        {
            _D1Face = _D1.Roll(); // This calls the roll method to give the dice a value 
            Debug.Assert(_D1Face >= 1 && _D1Face <= 6, "D1 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            _D2Face = _D2.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(_D2Face >= 1 && _D2Face <= 6, "D2 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            _D3Face = _D3.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(_D3Face >= 1 && _D3Face <= 6, "D3 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
        }   
        
        //runs the sum check
        public void Testsum()
        {
            _D1Face = _D1.Roll();_D2Face = _D2.Roll();_D2Face = _D2.Roll();//this rolls the three dice
            _result = _D1Face + _D2Face + _D3Face;//this does the addition for the three dice faces 
            Debug.Assert(_result == _D1Face +_D2Face+_D3Face, "The sums don't match, there is an issue!");//this checks to see if the sum of the three faces is correct
        }

        

    }
}
