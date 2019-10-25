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
        Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttontext = button.Text;
            textBox1.Text = textBox1.Text + buttontext;
            calculator.NummersToevoegen(buttontext);
        }
                
         public void plus_Click(object sender, EventArgs e)
         {
            Button button = (Button)sender;
            string buttontext = button.Text;
            textBox1.Text = textBox1.Text + buttontext;
            calculator.SymbolenToevoegen(buttontext);
            //int result = Convert.ToInt32(textBox1);
         }

        private void Result_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.BerekeningMaken();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.Leegmaken();
        }
    }


}

