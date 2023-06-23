using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = int.Parse(textBox1.Text);
            int p = int.Parse(textBox2.Text);
            int n = q * p;
            int fi = (q - 1) * (p - 1);
            textBox3.Text = "\n n = " + n + "\n fi = " + fi + "\n";
            int E = int.Parse(textBox5.Text);
            bool prost = true;
            for (int i = 2; i <= E / 2; i++)
            {
                if (E % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                textBox6.Text = E + "; " + n;
            }
            else
            {
                textBox6.Text = "Число не простое";
            }
            int d = int.Parse(textBox4.Text);
            E = int.Parse(textBox5.Text);
            for (int h = 1; h <= 2; h++)
            {
                int i = E + fi * h;
                int k = (i * E) % fi;
                if (k == 1)
                {
                    textBox7.Text = i + "; " + n;
                }
                else
                {
                    textBox7.Text = "Неверное число d";
                }
            }
        }
    }
}
