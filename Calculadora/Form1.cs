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
        string ingreso = string.Empty;   //cadena que almacena la entrada del usuario
        string operacion1 = string.Empty;  // cadena que almacena el primer operando
        string operacion2 = string.Empty;   //cadena que almacena el segundo operando
        char operacion;                //char para la operación
        double result = 0.0;  //resultado calculado
        string mensaje = "Resultado:";
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
            ingreso += "1";
            this.textBox1.Text += ingreso;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "2";
            this.textBox1.Text += ingreso;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "3";
            this.textBox1.Text += ingreso;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "4";
            this.textBox1.Text += ingreso;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "5";
            this.textBox1.Text += ingreso;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "6";
            this.textBox1.Text += ingreso;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "7";
            this.textBox1.Text += ingreso;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "8";
            this.textBox1.Text += ingreso;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ingreso += "9";
            this.textBox1.Text += ingreso;
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = '+';
            ingreso = string.Empty;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = '-';
            ingreso = string.Empty;
        }
        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = '^';
            ingreso = string.Empty;
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = '*';
            ingreso = string.Empty;
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = 'f';
            ingreso = string.Empty;
        }

        private void buttonDivicion_Click(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = '/';
            ingreso = string.Empty;
        }

        private void buttonPotencia_Click_1(object sender, EventArgs e)
        {
            operacion1 = ingreso;
            operacion = 'p';
            ingreso = string.Empty;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            operacion2 = ingreso;
            double num1, num2;
            double.TryParse (operacion1, out num1);
            double.TryParse (operacion2, out num2);

            if (operacion == '+')
            {
           
            result = num1 + num2;
            textBox1.Text = mensaje+result. ToString();
            }
            else if (operacion == '-')
            {
            result = num1 - num2;
            textBox1.Text = result. ToString();
            }
            else if (operacion == '*')
            {
            result = num1 * num2;
            textBox1.Text = result. ToString();
            }
            else if (operacion == '/')
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
            if (operacion == 'f')
            {
                double fact = 1;
                for (int i = 1; i <= num1; i++)
                {
                    fact *= i;
                }
                textBox1.Text = fact.ToString();
            }
            if (operacion == '^')
            {
                result = Math.Pow(num1,2);
                textBox1.Text = result.ToString();
            }
            if (operacion == 'p')
            {
                result = Math.Pow(num1, num2);
                textBox1.Text = result.ToString();
            }
         }


       
      }
}
