using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class Min : Operator // afgeleide van de basis class Operator
    {
        public override double Berekenen(double invoer1, double invoer2) //de basis methode wordt ge-override, zodat er een berekening in kan. 
        {
            return invoer1 - invoer2;
        }
    }
}
