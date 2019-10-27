using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public abstract class Operator
    {
        public abstract double Berekenen(double invoer1, double invoer2); // de basis regel, abstract dus kan niet geinstantieerd worden. Elke afgeleide moet 2 invoers hebben. 
    }
}
