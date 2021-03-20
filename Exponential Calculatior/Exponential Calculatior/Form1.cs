using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exponential_Calculatior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int hesap(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;

            


        }
        private void button1_Click(object sender, EventArgs e)
        {

            int s = int.Parse(textBox1.Text);
            label1.Text = hesap(s).ToString();


        }
    }
}
