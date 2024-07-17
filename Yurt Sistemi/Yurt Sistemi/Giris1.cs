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
    public partial class Giris1 : Form
    {
        public Giris1()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand giris = new SqlCommand("Select * from admin where kullanıcıadi = @g1 and sifre = @g2",bgl.baglanti());
            giris.Parameters.AddWithValue("@g1", txtkullaniciadi.Text);
            giris.Parameters.AddWithValue("@g2", txtsifre.Text);
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                FrmAnamenu frm = new FrmAnamenu();
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                txtkullaniciadi.Clear();
                txtsifre.Clear();
                txtkullaniciadi.Focus();
            }
            bgl.baglanti().Close();
        }

        private void Giris1_Load(object sender, EventArgs e)
        {

        }
    }
}
