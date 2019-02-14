using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public bool newNumber = false;
        public double result = 0;
        public char indi;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if (textBox1.Text.ToString() == "0" || newNumber == true)
            {
                textBox1.Text = btn.Text.ToString();
                newNumber = false;
            }
            else
            {
                textBox1.Text += btn.Text.ToString();
            }
        }

        public void calcul(char temp)
        {
            switch (temp)
            {
                case '+':
                    result += double.Parse(textBox1.Text);
                    break;
                case '-':
                    result -= double.Parse(textBox1.Text);
                    break;
                case '*':
                    result *= double.Parse(textBox1.Text);
                    break;
                case '/':
                    result /= double.Parse(textBox1.Text);
                    break;
            }
        }

        private void OperatorBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // indi = btn.Text.ToString();
            if (label1.Text == "")
            {
                label1.Text += textBox1.Text + "+";
                result = double.Parse(textBox1.Text);
            }
            else
            {
                label1.Text += textBox1.Text + "+";
                calcul(indi);
                textBox1.Text = result.ToString();
            }
            newNumber = true;
            indi = '+';
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {           
            if(label1.Text == "")
            {
                label1.Text += textBox1.Text + "+";                
                result = double.Parse(textBox1.Text);                
            }
            else
            { 
                label1.Text += textBox1.Text + "+";                
                calcul(indi);
                textBox1.Text = result.ToString();                
            }
            newNumber = true;
            indi = '+';
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text += textBox1.Text + "-";
                result = double.Parse(textBox1.Text);
            }
            else
            {
                label1.Text += textBox1.Text + "-";
                calcul(indi);
                textBox1.Text = result.ToString();
            }
            newNumber = true;
            indi = '-';
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text += textBox1.Text + "*";
                result = double.Parse(textBox1.Text);
            }
            else
            {
                label1.Text += textBox1.Text + "*";
                calcul(indi);
                textBox1.Text = result.ToString();
            }
            newNumber = true;
            indi = '*';
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text += textBox1.Text + "/";
                result = double.Parse(textBox1.Text);
            }
            else
            {
                label1.Text += textBox1.Text + "/";
                calcul(indi);
                textBox1.Text = result.ToString();
            }
            newNumber = true;
            indi = '/';
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            newNumber = false;
            textBox1.Text = "0";
            label1.Text = "";
            indi = '\0';
            result = 0.0;
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            calcul(indi);
            label1.Text = "";
            textBox1.Text = result.ToString();
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(".") == false)
                textBox1.Text += ".";
        }
    }
}
