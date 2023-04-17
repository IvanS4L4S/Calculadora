using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operacion1 = string.Empty;
        string operacion2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCero_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operacion1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            operacion2 = input;
            double num1, num2;
            double.TryParse (operacion1, out num1);
            double.TryParse (operacion2, out num2);

            if (operation == '+')
            {
            result = num1 + num2;
            textBox1.Text = result. ToString();
            }
            else if (operation == '-')
            {
            result = num1 - num2;
            textBox1.Text = result. ToString();
            }
            else if (operation == '*')
            {
            result = num1 * num2;
            textBox1.Text = result. ToString();
            }
            else if (operation == '/')
            {
            if (num2 != 0)
            {
            result = num1 / num2;
            textBox1.Text = result.ToString();
            }
            else
            {
            textBox1.Text = "DIV/Zero!";
            }

            }
                    }

       
                }
}
