using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCsharpppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c;
        string op;

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            op = "%";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            op = "*";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            op = "/";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            op = "+";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            op = "-";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            b = double.Parse(pantalla.Text);
            switch (op)
            {
                case "+":
                    c = a + b;
                    pantalla.Text = c.ToString();
                    break;
                case "-":
                    c = a - b;
                    pantalla.Text = c.ToString();
                    break;
                case "*":
                    c = a * b;
                    pantalla.Text = c.ToString();
                    break;
                case "/":
                    c = a / b;
                    pantalla.Text = c.ToString();
                    break;
                case "%":
                    c = (a/100)*b;
                    pantalla.Text = c.ToString();
                    break;
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Count() - 1);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (this.pantalla.Text.Contains('.') == false)
            {
                this.pantalla.Text = this.pantalla.Text + ".";
            }
        }
    }
}
