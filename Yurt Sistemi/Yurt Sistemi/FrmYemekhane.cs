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

namespace Yurt_Sistemi
{
    public partial class FrmYemekhane : Form
    {
        public FrmYemekhane()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmYemekhane_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet15.yemekhanemenu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yemekhanemenuTableAdapter.Fill(this.yurt_vtDataSet15.yemekhanemenu);

        }

        private void sıralaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yemekhanemenuTableAdapter.Sırala(this.yurt_vtDataSet15.yemekhanemenu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnsıfırla_Click(object sender, EventArgs e)
        {

            SqlCommand sifirla = new SqlCommand("update yemekhanemenu set oysayisi = 0", bgl.baglanti());
            sifirla.ExecuteNonQuery();
            this.yemekhanemenuTableAdapter.Fill(this.yurt_vtDataSet15.yemekhanemenu);
            bgl.baglanti().Close();

        }
    }
}
