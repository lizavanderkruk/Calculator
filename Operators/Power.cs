using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class Power : Operator
    {
        public override double Berekenen(double invoer1, double invoer2)
        {
            return Math.Pow(invoer1, invoer2);
        }
    }
}
