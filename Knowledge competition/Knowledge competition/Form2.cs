using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_competition
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlış = 0;

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            if (btna.Text == cevap)
            {
                doğru = doğru + 1;
                labeldoru.Text = doğru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlış = yanlış + 1;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            if (btnb.Text == cevap)
            {
                doğru = doğru + 1;
                labeldoru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış = yanlış + 1;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            if (btnc.Text == cevap)
            {
                doğru = doğru + 1;
                labeldoru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış = yanlış + 1;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            if (btnd.Text == cevap)
            {
                doğru = doğru + 1;
                labeldoru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış = yanlış + 1;
                labelyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Yenidenoyna_Click(object sender, EventArgs e)
        {
            soruno = 0;
            doğru = 0;
            yanlış = 0;
            labeldoru.Text = "0";
            labelsoruno.Text = "0";
            labelyanlış.Text = "0";
            Yenidenoyna.Visible = false;
            btnsonraki.Enabled = true;
            btnsonraki.Text = "Başla";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string cevap;
        

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            labelsoruno.Text = soruno.ToString();
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;
            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin Başkenti Neresidir ?";
                btna.Text = "Trabzon";
                btnb.Text = "Ankara";
                btnc.Text = "Yozgat";
                btnd.Text = "İstanbul";
                cevap = "Ankara";
                btnsonraki.Text = "Sonraki Soru";
                

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiyenin En Güzel Şehri Neresinir ?";
                btna.Text = "Trabzon";
                btnb.Text = "Ankara";
                btnc.Text = "Yozgat";
                btnd.Text = "İstanbul";
                cevap = "Trabzon";
                btnsonraki.Text = "Sonraki Soru";
               
            }
            if (soruno ==3)
            {

                richTextBox1.Text = "Türkiyenin En Büyük Gölü Neresidir ?";
                btna.Text = "Van Gölü";
                btnb.Text = "Tuz Gölü";
                btnc.Text = "Beyşehir Gölü";
                btnd.Text = "Burdur Gölü";
                cevap = "Van Gölü";
                btnsonraki.Text = "Sonuçlar";
                



            }
            if (soruno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show(" doğru sayınız " + doğru + "\n  yanlış sayınız " + yanlış);
                Yenidenoyna.Visible = true;


            }

            

        }
    }
}
