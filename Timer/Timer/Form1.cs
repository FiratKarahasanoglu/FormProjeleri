using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            a = a + 1;
            if (a == 1)
            {
                this.BackColor = Color.Blue;
                label1.Text = "Mavi";
            }
            if (a == 2)
            {
                this.BackColor = Color.Red;
                label1.Text = "Bordo";
            }
            if (a == 7)
            {
                this.BackColor = Color.Blue;
                label1.Text = "Mavi";
            }
            if (a == 8)
            {
                this.BackColor = Color.Red;
                label1.Text = "Bordo";
                a = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {





        }
    }
}
