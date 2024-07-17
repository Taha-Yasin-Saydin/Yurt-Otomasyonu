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
    public partial class FrmOgrSil : Form
    {
        public FrmOgrSil()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, tc, telefon, dogum, bolum, mail, odano, txtveliadsoyad, velitel, adres;

      

        Sqlbaglanti bgl = new Sqlbaglanti();



        private void FrmOgrSil_Load(object sender, EventArgs e)
        {
            txtogrid.Text = id;
            txtograd.Text = ad;
            txtogrsoyad.Text = soyad;
            msktc.Text = tc;
            mskogrtel.Text = telefon;
            mskdogum.Text = dogum;
            cmbbolum.Text = bolum;
            txtmail.Text = mail;
            cmbodano.Text = odano;
            veliadsoyad.Text = txtveliadsoyad;
            mskvelitel.Text = velitel;
            rchadres.Text = adres;

            
            // TODO: Bu kod satırı 'yurt_vtDataSet.ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurt_vtDataSet.ogrenci);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("update ogrenci set ad = @p2, soyad = @p3, tc = @p4, telefon = @p5, dogum = @p6, bolum = @p7, mail = @p8, odano = @p9, veliadsoyad = @p10, veliadres = @p11, velitelefon = @p12 where ogrid =@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtogrid.Text);
                komut.Parameters.AddWithValue("@p2", txtograd.Text);
                komut.Parameters.AddWithValue("@p3", txtogrsoyad.Text);
                komut.Parameters.AddWithValue("@p4", msktc.Text);
                komut.Parameters.AddWithValue("@p5", mskogrtel.Text);
                komut.Parameters.AddWithValue("@p6", mskdogum.Text);
                komut.Parameters.AddWithValue("@p7", cmbbolum.Text);
                komut.Parameters.AddWithValue("@p8", txtmail.Text);
                komut.Parameters.AddWithValue("@p9", cmbodano.Text);
                komut.Parameters.AddWithValue("@p10", veliadsoyad.Text);
                komut.Parameters.AddWithValue("@p11", rchadres.Text);
                komut.Parameters.AddWithValue("@p12", mskvelitel.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt güncellendi.");
                this.ogrenciTableAdapter.Fill(this.yurt_vtDataSet.ogrenci);
            }
            catch {
                MessageBox.Show("Hata");
                this.ogrenciTableAdapter.Fill(this.yurt_vtDataSet.ogrenci);
            }
           


        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from ogrenci where ogrid =@s1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@s1", txtogrid.Text);
                komut2.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi.");
                bgl.baglanti().Close();

                SqlCommand sil = new SqlCommand("delete from borc where ogrid = @s2", bgl.baglanti());
                sil.Parameters.AddWithValue("@s2", txtogrid.Text);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();    
            }
            catch
            {
                MessageBox.Show("Hata");
            }

            //Oda kontenjanı azaltma
            SqlCommand komutoda2 = new SqlCommand("update oda set odadoluluk = odadoluluk-1 where odano=@oda", bgl.baglanti());
            komutoda2.Parameters.AddWithValue("@oda",cmbodano.Text);
            komutoda2.ExecuteNonQuery();
            bgl.baglanti() .Close();   
        }

    }
}
