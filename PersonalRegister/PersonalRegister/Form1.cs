using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonalRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FIRAT;Initial Catalog=PersonalVeriTabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personalVeriTabaniDataSet.TBL_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_PersonelTableAdapter1.Fill(this.personalVeriTabaniDataSet.TBL_Personel);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tBL_PersonelTableAdapter1.Fill(this.personalVeriTabaniDataSet.TBL_Personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Personelad,PersonelSoyad,PersonelSehir,PersonelMaas,PersonelDurum,PersonelMeslek) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtName.Text);
            komut.Parameters.AddWithValue("@p2", TxtSurName.Text);
            komut.Parameters.AddWithValue("@p3", CmbCity.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(TxtSalary.Text));
            komut.Parameters.AddWithValue("@p5", radioButton1.Checked);
            komut.Parameters.AddWithValue("@p6", TxtJob.Text);


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");

        }
        void temizle ()
        {
            TxtName.Text = "";
            Txtid.Text = "";
            TxtJob.Text = "";
            TxtSalary.Text = "";
            TxtSurName.Text = "";
            CmbCity.Text = "";
            TxtName.Focus();
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
