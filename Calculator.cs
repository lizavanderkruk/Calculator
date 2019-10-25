using Calculator.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        static List<Operator> operators = new List<Operator>();
        static List<string> invoerLijstSTRING = new List<string>();
        static List<int> invoerLijstINT = new List<int>();
        string reeks = "";

        Sum optellen = new Sum();


        public void NummersToevoegen(string getal)
        {
            reeks += getal; 
            //invoerLijstSTRING.Add(getal);
        }
        public void SymbolenToevoegen(string symbool)
        {
            invoerLijstSTRING.Add(reeks);
            reeks = "";

            switch (symbool)
            {
                case "+":
                    operators.Add(new Sum());
                    //int symbool1 = Convert.ToInt32(symbool);
                    break;
                case "-":
                    operators.Add(new Min());
                    break;
                case "*":
                    operators.Add(new Multiply());
                    break;
                case "/":
                    operators.Add(new Divide());
                    break;
            }
        }

        public string BerekeningMaken()
        {
            invoerLijstSTRING.Add(reeks);
            reeks = "";
            int result = 0;

            for (int i = 0; i < invoerLijstSTRING.Count; i++)
            {
                int.TryParse(invoerLijstSTRING[i], out int number);
                invoerLijstINT.Add(number);
            }
            for (int i = 0; i < operators.Count; i++)
            {
                var invoer1 = invoerLijstINT[i];
                var invoer2 = invoerLijstINT[i + 1];
                invoerLijstINT[i + 1] = operators[i].Berekenen(invoer1, invoer2);
                result = invoerLijstINT[i + 1]; 
            }
            invoerLijstSTRING.Clear();
            invoerLijstINT.Clear();
            operators.Clear();
            reeks = result.ToString();
            return result.ToString();
        }
        public string Leegmaken()
        {
            invoerLijstSTRING.Clear();
            invoerLijstINT.Clear();
            operators.Clear();
            reeks = "";
            return reeks;
        }
        
    }
}





    

 


