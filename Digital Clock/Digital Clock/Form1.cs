using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int sn, dk, saat, a;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sn = sn + 1;
            label1.Text = sn.ToString();

            if (sn == 60)
            {
                dk = dk + 1;
                label2.Text = dk.ToString();
                sn = 0;


            }
            if (dk == 60)
            {
                dk = 0;
                label2.Text = dk.ToString();
                saat = saat + 1;
                label3.Text = saat.ToString();
                

            }
            if (saat == 24)
            {
                saat = 0;
                label3.Text = saat.ToString();
                


                



            }
            
        }
    }
}
