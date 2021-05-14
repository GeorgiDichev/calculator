using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value = 0;
        double valueM = 0;
        bool operandPerformed = false;
        string opr = "";
        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operandPerformed ) 
                textBox1.Clear();

            Button button = (Button)sender;
            if(button.Text == ",")
            {

                if(!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else textBox1.Text = textBox1.Text + button.Text;

            operandPerformed = false;
            
        }

        private void bNumCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bNumC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblResult.Text = "";
            value = 0;
            opr = "";
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button button = (Button)sender;
            string newOperand = button.Text;
            lblResult.Text = lblResult.Text + " " + textBox1.Text + " " + newOperand;

            switch(opr)
            {
                case "+": textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();break;
                case "-": textBox1.Text = (value - double.Parse(textBox1.Text)).ToString(); break;
                case "X": textBox1.Text = (value * double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (value / double.Parse(textBox1.Text)).ToString(); break;
                default: break;
            }

            value = double.Parse(textBox1.Text);
            opr = newOperand;
        }

        private void bNumEqual_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            operandPerformed = true;
            
            switch (opr)
            {
                case "+": textBox1.Text = (value + double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (value - double.Parse(textBox1.Text)).ToString(); break;
                case "X": textBox1.Text = (value * double.Parse(textBox1.Text)).ToString(); break;
                case "/":

                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "Няма деление на нула";
                    }

                    else textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;

                default: break;
                    
            }

            //value = double.Parse(textBox1.Text);
            //textBox1.Text = value.ToString();
            value = 0;
            opr = "";

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            valueM -= double.Parse(textBox1.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
        }

        private void OperationMemoryPlus(object sender, EventArgs e)
        {           
            valueM += double.Parse(textBox1.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
        }

        private void OperationMemoryClear(object sender, EventArgs e)
        {
            valueM = 0;
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void OperationMemoryResult(object sender, EventArgs e)
        {
            textBox1.Text = valueM.ToString();
        }

        private void OperandReverse(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains ('-'))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }

        }

        private void Root(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(value).ToString();
        }

    }
}
