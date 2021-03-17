using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad: " + textBox1.Text + " TC: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text + " ");
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nereden = comboBox1.Text;
            string nereye = comboBox2.Text;

            comboBox1.Text = nereye;
            comboBox2.Text = nereden;


        }
    }
}
