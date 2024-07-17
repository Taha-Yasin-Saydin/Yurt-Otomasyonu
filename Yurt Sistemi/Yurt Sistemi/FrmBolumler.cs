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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet1.bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumTableAdapter.Fill(this.yurt_vtDataSet1.bolum);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbolumekle_Click(object sender, EventArgs e)
        {
            try { 
           
            SqlCommand komut1 = new SqlCommand("insert into bolum (bolumad) values (@p1)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtbolumad.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
                MessageBox.Show("Bölüm eklendi.");
                this.bolumTableAdapter.Fill(this.yurt_vtDataSet1.bolum);
            }
            catch {
                MessageBox.Show("Hata");
            }

        }

        private void btnbolumsil_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("delete from bolum where bolumid = @p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtbolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm silindi.");
                this.bolumTableAdapter.Fill(this.yurt_vtDataSet1.bolum);
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad; 
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtbolumid.Text = id;
            txtbolumad.Text = bolumad;
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            try
            {
           
                SqlCommand komut3 = new SqlCommand("update bolum set bolumad=@p2 where bolumid=@p1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", txtbolumid.Text);
                komut3.Parameters.AddWithValue("@p2", txtbolumad.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı.");
                this.bolumTableAdapter.Fill(this.yurt_vtDataSet1.bolum);
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        } 
    }
}
