using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Sales_Panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        int Case = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int Popcorn, Water, Tea, Ticket,total;
            

            Popcorn = int.Parse(textBox1.Text)*4;
            Water = int.Parse(textBox2.Text)*1;
            Tea = int.Parse(textBox3.Text)*2;
            Ticket = int.Parse(textBox4.Text)*8;

            total = Popcorn + Water + Tea + Ticket;

            label10.Text = "Total: " + total + "$";
            Case = Case + total;
            label11.Text = "Case: " + Case + "$";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Case = 0;
            label11.Text = "Case: " + Case + "$";

        }
    }
}
