using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Exam_Statues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, sonuc, a, b;

            sınav1 = int.Parse(textBox1.Text);
            sınav2 = int.Parse(textBox4.Text);
            sınav3 = int.Parse(textBox3.Text);

            sonuc = (sınav1 + sınav2 + sınav3) / 3;
            if (sonuc <50 && sonuc >= 0 )
            {
                label5.Text = ("sonuc = " + sonuc + " Kaldın"  );

            }
            else if (sonuc >= 50 && sonuc <= 100)
            {
                label5.Text = ("sonuc = " + sonuc + " Geçtin" );
            }
            else
            {
                label5.Text = ("Bu imkansız");
            }
           

            


        }
    }
}
