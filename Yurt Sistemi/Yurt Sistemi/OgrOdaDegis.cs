using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yurt_Sistemi
{
    public partial class OgrOdaDegis : Form
    {
        public OgrOdaDegis()
        {
            InitializeComponent();
        }
            Sqlbaglanti bgl = new Sqlbaglanti();
        private void OgrOdaDegis_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select odano from oda where odakapasite != odadoluluk", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbodalar.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void btngonder_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut2 = new SqlCommand("insert into odadegis (oda, acıklama) values(@f1, @f2)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@f1", cmbodalar.Text);
                komut2.Parameters.AddWithValue("@f2", rchaciklama.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Talep alındı.");
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
