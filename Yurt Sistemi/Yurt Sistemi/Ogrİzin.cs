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
    public partial class Ogrİzin : Form
    {

        Sqlbaglanti bgl = new Sqlbaglanti();

        public Ogrİzin()
        {
            InitializeComponent();
        }

        private void btntalep_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into ogrenciizin (giristarih, cikistarih, aciklama, adres, telefon) values (@i1, @i2, @i3, @i4, @i5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@i1", mskizinbaş.Text);
                komut.Parameters.AddWithValue("@i2", mskizinbit.Text);
                komut.Parameters.AddWithValue("@i3", rchaciklama.Text);
                komut.Parameters.AddWithValue("@i4", rchadres.Text);
                komut.Parameters.AddWithValue("@i5", msktel.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Talep alındı.");
            }
            catch 
            {
                MessageBox.Show("Hata");
            }
           

        }

        private void Ogrİzin_Load(object sender, EventArgs e)
        {

        }
    }
}
