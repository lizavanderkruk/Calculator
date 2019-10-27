using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class Sqrt : OperatorSingle
    {        
        public override double Berekenen(double invoer1)
        {
            return Math.Sqrt(invoer1);
        }
    }
}
