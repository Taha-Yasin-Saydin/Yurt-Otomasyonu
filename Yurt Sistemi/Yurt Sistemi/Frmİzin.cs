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
    public partial class Frmİzin : Form
    {
        public Frmİzin()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void Frmİzin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet14.ogrenciizin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciizinTableAdapter2.Fill(this.yurt_vtDataSet14.ogrenciizin);
            // TODO: Bu kod satırı 'yurt_vtDataSet13.ogrenciizin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciizinTableAdapter1.Fill(this.yurt_vtDataSet13.ogrenciizin);
            // TODO: Bu kod satırı 'yurt_vtDataSet12.ogrenciizin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciizinTableAdapter.Fill(this.yurt_vtDataSet12.ogrenciizin);

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, telefon, cikis, giris;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cikis = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            giris = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtogrid.Text = id;
            txttel.Text = telefon;
            txtgiris.Text = giris;
            txtcikis.Text = cikis;
        }

        private void btnonay_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("update ogrenciizin set onay=@o1 where telefon=@o2",bgl.baglanti());
            komut.Parameters.AddWithValue("@o1", "Onaylandı");
            komut.Parameters.AddWithValue("@o2", txttel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciizinTableAdapter2.Fill(this.yurt_vtDataSet14.ogrenciizin);
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update ogrenciizin set onay=@o1 where telefon=@o2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@o1", "Reddedildi");
            komut2.Parameters.AddWithValue("@o2", txttel.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.ogrenciizinTableAdapter2.Fill(this.yurt_vtDataSet14.ogrenciizin);
        }
    }
}
