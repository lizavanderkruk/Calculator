using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public abstract class Operator
    {
        public abstract int Berekenen(int invoer1, int invoer2);
    }
}
