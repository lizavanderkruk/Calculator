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
        static List<Operator> operators = new List<Operator>(); // lijst van symbolen die 2 invoers hebben
        static List<OperatorSingle> operatorSingle = new List<OperatorSingle>(); //lijst van symbolen die 1 invoer hebben
        static List<string> invoerLijstSTRING = new List<string>(); //lijst van cijfers in strings
        static List<double> invoerLijstINT = new List<double>(); // lijst van cijfers in doubles
        string reeks = ""; // variable reeks die leeg is

        public void NummersToevoegen(string getal)
        {
            reeks += getal; // het maken van een string/reeks getallen die als 1e getal/invoer doorgaat
            //invoerLijstSTRING.Add(getal);
        }
        public void SymbolenToevoegen(string symbool)
        {
            invoerLijstSTRING.Add(reeks); // bij het klikken op het symbool wordt de 1e invoer naar de lijst gepushed als getal 1.
            reeks = ""; // reeks is weer leeg

            switch (symbool) //het maken van de symbolenreeks/lijst
            {
                case "+":
                    operators.Add(new Sum());
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
                case "√": 
                    operatorSingle.Add(new Sqrt());
                    break;
                case "^": 
                    operators.Add(new Power());
                    break; 
            }
        }

        public string BerekeningMaken()
        {
            invoerLijstSTRING.Add(reeks); //bij het klikken op = wordt de 2e invoer naar de lijst gepushed als getal 2.
            reeks = ""; //daarna wordt reeks weer op 0 gezet
            double result = 0;

            for (int i = 0; i < invoerLijstSTRING.Count; i++) // voor elke string in invoerLijstSTRING 
            {
                double.TryParse(invoerLijstSTRING[i], out double number); // wordt de string omgezet naar een cijfer (double)
                invoerLijstINT.Add(number); // en wordt hij in een nieuwe lijst gezet (double)
            }
            for (int i = 0; i < operators.Count; i++) // voor elk symbool in operators
            {
                var invoer1 = invoerLijstINT[i]; // 1e invoer is i
                var invoer2 = invoerLijstINT[i + 1]; // 2e invoer is i + de volgende plek, dus 1. 
                invoerLijstINT[i + 1] = operators[i].Berekenen(invoer1, invoer2); 
                result = invoerLijstINT[i + 1]; 
            }
            invoerLijstSTRING.Clear(); // na de berekening worden de lijsten/het geheugen weer geleegd
            invoerLijstINT.Clear();
            operators.Clear();
            reeks = result.ToString(); //reeks bevat nu het result geconverteerd naar een string
            return result.ToString(); //zorgt ervoor dat result wordt geshowed
        }
        public string BerekeningSingleOperator()
        {
            invoerLijstSTRING.Add(reeks);
            reeks = "";
            double result = 0;

            for (int i = 0; i < invoerLijstSTRING.Count; i++)
            {
                double.TryParse(invoerLijstSTRING[i], out double number);
                invoerLijstINT.Add(number);
            }
            for (int i = 0; i < operatorSingle.Count; i++)
            {
                var invoer1 = invoerLijstINT[i];
                invoerLijstINT[i] = operatorSingle[i].Berekenen(invoer1);
                result = invoerLijstINT[i];
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





    

 


