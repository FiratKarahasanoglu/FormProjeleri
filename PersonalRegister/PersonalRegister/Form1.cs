using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
