using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje, a, b, c, d,ortalama;
            string AD, SOYAD;
           
            
            vize = double.Parse(textBox1.Text);
            final = double.Parse(textBox2.Text);
            proje = double.Parse(textBox3.Text);

            AD = textBox4.Text;
            SOYAD = textBox5.Text;

            ortalama = ((vize * 3) / 10 + (final / 2) + (proje / 5));

            if ( ortalama > 100 || 0 > ortalama) { 
                listBox1.Items.Add(AD + " " + SOYAD + " Ortalama bu değer olamaz"); 
            }
            else
            {
                listBox1.Items.Add(AD + " " + SOYAD + " Ortalama: " + ortalama);
            }
            


        }
    }
}
