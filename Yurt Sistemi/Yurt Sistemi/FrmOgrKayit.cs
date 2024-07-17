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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {

            //Bölümleri listeledik.
           
            SqlCommand komut = new SqlCommand("Select bolumad from bolum", bgl.baglanti()); //verileri komut nesnesine ekliyoruz
            SqlDataReader oku = komut.ExecuteReader();   //komut nesnesinden oku nesnesine aktarıyoruz
            while (oku.Read())                                   
            {
                cmbbolum.Items.Add(oku[0].ToString()); //oku nesnesinin içindeki verileri combobox a ekliyoruz.
            }
            bgl.baglanti().Close();

            //Boş odaları listeledik.
          
            SqlCommand komut2 = new SqlCommand("Select odano from oda where odakapasite != odadoluluk", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbodano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand kaydet = new SqlCommand("insert into ogrenci (ad, soyad, tc, telefon, dogum, bolum, mail, odano, veliadsoyad, velitelefon, veliadres) values (@t1, @t2, @t3, @t4, @t5, @t6, @t7, @t8, @t9, @t10, @t11)", bgl.baglanti());
                kaydet.Parameters.AddWithValue("@t1", txtograd.Text);
                kaydet.Parameters.AddWithValue("@t2", txtogrsoyad.Text);
                kaydet.Parameters.AddWithValue("@t3", msktc.Text);
                kaydet.Parameters.AddWithValue("@t4", mskogrtel.Text);
                kaydet.Parameters.AddWithValue("@t5", mskdogum.Text);
                kaydet.Parameters.AddWithValue("@t6", cmbbolum.Text);
                kaydet.Parameters.AddWithValue("@t7", txtmail.Text);
                kaydet.Parameters.AddWithValue("@t8", cmbodano.Text);
                kaydet.Parameters.AddWithValue("@t9", veliadsoyad.Text);
                kaydet.Parameters.AddWithValue("@t10", mskvelitel.Text);
                kaydet.Parameters.AddWithValue("@t11", rchadres.Text);
                kaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt tamamlandı.");


                //öğrenci id' i label12ye çekme
                SqlCommand komut = new SqlCommand("select ogrid from ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                
                SqlCommand kaydet2 = new SqlCommand("insert into borc (ogrid, ad, soyad) values (@b1, @b2, @b3)", bgl.baglanti());
                kaydet2.Parameters.AddWithValue("@b1", label12.Text);
                kaydet2.Parameters.AddWithValue("@b2", txtograd.Text);
                kaydet2.Parameters.AddWithValue("@b3", txtogrsoyad.Text);
                kaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();



            }
            catch 
            {
                MessageBox.Show("Lütfen tekrar deneyin.");
            }


            //Oda kontenjanını 1 arttırma
            SqlCommand komutoda = new SqlCommand("update oda set odadoluluk=odadoluluk+1 where odano=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbodano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

            
        }
    }
}
//Data Source=DESKTOP-RS9MSH0;Initial Catalog=yurt_vt;Integrated Security=True