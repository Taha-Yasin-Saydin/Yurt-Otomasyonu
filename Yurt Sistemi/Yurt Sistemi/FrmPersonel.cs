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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet4.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurt_vtDataSet4.personel);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand kaydet = new SqlCommand("insert into personel (personelad, personelsoyad, personeldgmtrh, personelcinsiyet, personeltelefon, personeltc, personeladres, personelgorev) values (@t1, @t2, @t3, @t4, @t5, @t6, @t7, @t8)", bgl.baglanti());
                kaydet.Parameters.AddWithValue("@t1", prsad.Text);
                kaydet.Parameters.AddWithValue("@t2", prssoyad.Text);
                kaydet.Parameters.AddWithValue("@t3", prsdogum.Text);
                kaydet.Parameters.AddWithValue("@t4", prscins.Text);
                kaydet.Parameters.AddWithValue("@t5", prstel.Text);
                kaydet.Parameters.AddWithValue("@t6", prstc.Text);
                kaydet.Parameters.AddWithValue("@t7", prsadres.Text);
                kaydet.Parameters.AddWithValue("@t8", prsgorev.Text);
                kaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.personelTableAdapter.Fill(this.yurt_vtDataSet4.personel);
                MessageBox.Show("Kayıt tamamlandı.");
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
