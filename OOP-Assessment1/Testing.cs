using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Testing
    {
        public void Test() 
        {
            Dice D1 = new Dice(); Dice D2 = new Dice(); Dice D3 = new Dice();
            int D1Face = D1.Roll();
            Debug.Assert(D1Face >= 1 && D1Face<= 6, "D1 is not within the correct range, check the roll range!");
            int D2Face = D2.Roll();
            Debug.Assert(D2Face >= 1 && D2Face <= 6, "D2 is not within the correct range, check the roll range!");
            int D3Face = D3.Roll();
            Debug.Assert(D3Face >= 1 && D3Face <= 6, "D3 is not within the correct range, check the roll range!");
        }
    }
}
