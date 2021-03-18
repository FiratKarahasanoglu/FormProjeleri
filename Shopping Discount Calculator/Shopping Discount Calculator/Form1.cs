using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Discount_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = int.Parse(textBox1.Text);

            if (a >= 0 && a <= 20)
            {
                a = a * 8*8 / 10;
                label3.Text = a.ToString();

            }
            else if (a > 20 && a <= 40)
            {

                a = a * 6 *8/ 10;
                label3.Text = a.ToString();
            }
            else if (a > 40)
            {
                a = a * 5 *8  / 10;
                label3.Text = a.ToString();
            }
            else
            {
                label3.Text = "Bu olamaz";
            }

            









            }

            
        }
    }

