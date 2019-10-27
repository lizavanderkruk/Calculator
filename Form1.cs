using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Operators;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator(); // nieuwe instantie van de class Calculator

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //een variable button, waarbij het object sender wordt gecast naar het type Button
            string buttontext = button.Text; // van de tekst van de button wordt een variabele gemaakt
            textBox1.Text = textBox1.Text + buttontext; // zorgt ervoor dat je dubbele tekens kan hebben, dus 11 ipv 1. 
            calculator.NummersToevoegen(buttontext); // de verschillende buttontext cijfers worden toegevoegd aan de getallenreeks
        }
                
         public void plus_Click(object sender, EventArgs e)
         {
            Button button = (Button)sender;
            string buttontext = button.Text;
            textBox1.Text = textBox1.Text + buttontext;
            calculator.SymbolenToevoegen(buttontext); // de getallenreeks wordt toegevoegd aan de lijst invoerLijstSTRING en de symbolen worden toegevoegd aan de lijst operators.
         }

        private void Result_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.BerekeningMaken(); //de methode BerekeningMaken wordt aangeroepen, waarvoor result wordt weergegeven in TextBox1. 
            
        }
        private void Result_single_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.BerekeningSingleOperator(); //de methode voor single invoer wordt aangeroepen 
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.Leegmaken(); //de methode Leegmaaken wordt aangeroepen. 
        }
    }
}

