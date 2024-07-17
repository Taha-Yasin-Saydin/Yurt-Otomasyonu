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
    public partial class OgrSikayet : Form
    {
        public OgrSikayet()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void OgrSikayet_Load(object sender, EventArgs e)
        {

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into sikayet (konu, sikayet) values (@a1, @a2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@a2", rchtxtsikayet.Text);
            if(radiobtnsikayet.Checked )
            {
                komut.Parameters.AddWithValue("@a1", radiobtnsikayet.Text);
                MessageBox.Show("Şikayet gönderildi.");
            }
            else if(radiobtnoneri.Checked )
            {
                komut.Parameters.AddWithValue("@a1", radiobtnoneri.Text);
                MessageBox.Show("Öneri gönderildi.");
            }
            else
            {
                MessageBox.Show("Konu başlığı seçiniz.");
            }

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
