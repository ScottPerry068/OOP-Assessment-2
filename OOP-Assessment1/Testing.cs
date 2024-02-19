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
        private int D1Face;private int D2Face; private int D3Face;private int result;
        private Dice D1 = new Dice();private Dice D2 = new Dice();private Dice D3 = new Dice();
        public void Test()
        {
            int D1Face = D1.Roll(); // This calls the roll method to give the dice a value 
            Debug.Assert(D1Face >= 1 && D1Face <= 6, "D1 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            int D2Face = D2.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(D2Face >= 1 && D2Face <= 6, "D2 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
            int D3Face = D3.Roll(); // This calls the roll method to give the dice a value
            Debug.Assert(D3Face >= 1 && D3Face <= 6, "D3 is not within the correct range, check the roll range!"); // This checks to see if the dice rolls an integer within the range 1-6
        }   
            
        public void Testsum()
        {
            D1Face = D1.Roll();
            D2Face = D2.Roll();
            D3Face = D3.Roll();
            result = D1Face + D2Face + D3Face;
            Debug.Assert(result == D1Face+D2Face+D3Face, "this is incorrect please check the Result or DFaces for errors!");

        }

        

    }
}
