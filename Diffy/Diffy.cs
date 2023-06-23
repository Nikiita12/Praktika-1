using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double g = double.Parse(textBox1.Text);
            double p = double.Parse(textBox3.Text);
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox5.Text);
            double A = Math.Pow(g, a) % p;
            textBox2.Text += Environment.NewLine + "A = " + A.ToString();
            double B = Math.Pow(g, b) % p;
            textBox2.Text += Environment.NewLine + " " + "B = " + B.ToString();
            double K = Math.Pow(g, a * b) % p;
            textBox2.Text += Environment.NewLine + " " + "K = " + K.ToString();
        }
    }
}
