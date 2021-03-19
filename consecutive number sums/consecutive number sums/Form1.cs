using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consecutive_number_sums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            double a, c, işlem;
            double b = 0;
            
            

            a = double.Parse(textBox1.Text);

            for (double i = 0; i <= a; i++)
            {
                b = b + i;
            }
            label1.Text = b.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
