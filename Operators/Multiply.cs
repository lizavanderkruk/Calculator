using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class Multiply : Operator
    {
        public override double Berekenen(double invoer1, double invoer2)
        {
            return invoer1 * invoer2;
        }
    }
}
