using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class calcu : Form
    {
        Double ant, valor;
        String operador;
        public calcu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += boton.Text;

        }

        private void calcu_Load(object sender, EventArgs e)
        {
            int valor=0;
            ant = 0;
            textBox1.Text = valor.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            ant = Convert.ToDouble(textBox1.Text);
            operador = boton.Text;

            textBox1.Text = "0";
           
        }

       private void button12_Click_1(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(textBox1.Text);

            if (operador == "+")
            {
                textBox1.Text = (ant + valor).ToString();
                ant = Convert.ToDouble(textBox1.Text);
            }
            else if((operador == "-"))
            {
                textBox1.Text = (ant - valor).ToString();
                ant = Convert.ToDouble(textBox1.Text);
            }
            else if ((operador == "x"))
            {
                textBox1.Text = (ant * valor).ToString();
                ant = Convert.ToDouble(textBox1.Text);
            }
            else if ((operador == "/"))
            {
                textBox1.Text = (ant / valor).ToString();
                ant = Convert.ToDouble(textBox1.Text);
            }
        }

       private void button16_Click(object sender, EventArgs e)
       {
           if (textBox1.Text.Length > 1)
           {
               textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
           }
           else
           {
               textBox1.Text = "0";
           }
       }

       private void button17_Click(object sender, EventArgs e)
       {
           ant = 0;
           valor = 0;
           operador = "\0";
           textBox1.Text = "0";
       }

       private void button18_Click(object sender, EventArgs e)
       {
           textBox1.Text = "0";
       }

       private void button19_Click(object sender, EventArgs e)
       {
           if (!textBox1.Text.Contains(","))
           {
               textBox1.Text += ",";
           }
       }

    }
}
