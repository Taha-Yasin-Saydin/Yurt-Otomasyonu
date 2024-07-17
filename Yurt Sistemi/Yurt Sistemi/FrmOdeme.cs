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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet2.borc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borcTableAdapter.Fill(this.yurt_vtDataSet2.borc);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtogrid.Text = id;
            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txtkalan.Text = kalan;

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtodenen.Text);
            kalan = Convert.ToInt16(txtkalan.Text);
            yeniborc = kalan - odenen;
            txtkalan.Text = yeniborc.ToString();


            //yeni borcu vt a kaydetme
            SqlCommand komut = new SqlCommand("update borc set kalanborc=@p1 where ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtogrid.Text);
            komut.Parameters.AddWithValue("@p1", txtkalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç ödendi.");
            this.borcTableAdapter.Fill(this.yurt_vtDataSet2.borc);
        }
    }
}
