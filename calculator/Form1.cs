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

        private void NumBtn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "0";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void NumBtn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "1";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void NumBtn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "2";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void NumBtn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "3";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void NumBtn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "4";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void NumBtn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "5";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void NumBtn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "6";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void NumBtn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "7";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void NumBtn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "8";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void NumBtn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || newNumber == true)
            {
                textBox1.Text = "9";
                newNumber = false;
            }
            else
            {
                textBox1.Text += "9";
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
