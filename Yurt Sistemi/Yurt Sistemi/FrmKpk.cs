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
    public partial class FrmKpk : Form
    {
        public FrmKpk()
        {
            InitializeComponent();
        }


        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmKpk_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet9.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter2.Fill(this.yurt_vtDataSet9.ogrenci);
           

           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogrenciTableAdapter2.Fill(this.yurt_vtDataSet9.ogrenci);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogrenciTableAdapter2.Fill(this.yurt_vtDataSet9.ogrenci);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sıralaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogrenciTableAdapter2.Fill(this.yurt_vtDataSet9.ogrenci);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int deger;
            string id, ad, soyad, toplam;
            deger = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[deger].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[deger].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[deger].Cells[2].Value.ToString();
            toplam = dataGridView1.Rows[deger].Cells[3].Value.ToString();

            textogrid.Text = id;
            textad.Text = ad;
            textsoyad.Text = soyad;
            texttopbagıs.Text = toplam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bagıs, toplam, yenitoplam;
            bagıs = Convert.ToInt32(textbagıs.Text);
            toplam = Convert.ToInt32(texttopbagıs.Text);
            yenitoplam = bagıs + toplam;
            texttopbagıs.Text = yenitoplam.ToString();


            SqlCommand komut = new SqlCommand("update ogrenci set kapak=@p1 where ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textogrid.Text);
            komut.Parameters.AddWithValue("@p1", texttopbagıs.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bağış yapıldı. Teşekkür ederiz.");
            this.ogrenciTableAdapter2.Fill(this.yurt_vtDataSet9.ogrenci);
        }

        private void sıralaToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sIRALAToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ogrenciTableAdapter2.SIRALA(this.yurt_vtDataSet9.ogrenci);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
