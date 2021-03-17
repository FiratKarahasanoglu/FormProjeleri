using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
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

        private void button1_Click(object sender, EventArgs e)
        {
            double toplama, çarpma, bölme, a, b, c, cikarma;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            çarpma = a * b;
            toplama = a + b;
            cikarma = a - b;
            bölme = a / b;
            if (textBox3.Text == "x")
            {
                label2.Text = çarpma.ToString("0.000");
            }
            else if (textBox3.Text == "+")
            {
                label2.Text = toplama.ToString("0.000");
            }
            else if (textBox3.Text == "-")
            {
                label2.Text = cikarma.ToString("0.000");
            }
            else if (textBox3.Text == "/")
            {
                label2.Text = bölme.ToString("0.000");
            }
            else
            {
                label2.Text = "Yanlış yazdınız";
            }
        }
    }
}
