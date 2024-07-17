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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }


        Sqlbaglanti bgl = new Sqlbaglanti();

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            txttop.Text = Convert.ToString(Convert.ToInt32(txtsu.Text) + Convert.ToInt32(txtgaz.Text) + Convert.ToInt32(txtelk.Text) + Convert.ToInt32(txtint.Text) + Convert.ToInt32(txtpers.Text) + Convert.ToInt32(txtdiger.Text));


            try
            {
                SqlCommand komut = new SqlCommand("insert into odeme (su, dogalgaz, elektrik, internet, personel, diger, tarih, toplam_gider) values (@g1, @g2, @g3, @g4, @g5, @g6, @g7, @g8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", txtsu.Text);
                komut.Parameters.AddWithValue("@g2", txtgaz.Text);
                komut.Parameters.AddWithValue("@g3", txtelk.Text);
                komut.Parameters.AddWithValue("@g4", txtint.Text);
                komut.Parameters.AddWithValue("@g5", txtpers.Text);
                komut.Parameters.AddWithValue("@g6", txtdiger.Text);
                komut.Parameters.AddWithValue("@g7", msktarih.Text);
                komut.Parameters.AddWithValue("@g8", txttop.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler kaydedildi.");
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "+")
                {
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
                }
                else if (comboBox1.Text == "-")
                {
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
                }

                else if (comboBox1.Text == "/")
                {
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
                }

                else if (comboBox1.Text == "*")
                {
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
                }
                else
                {
                    MessageBox.Show("Lütfen seçeneklerden birini seçiniz.");
                }
            }
            catch {
                MessageBox.Show("Lütfen sayısal değer giriniz.");
            }
        }
    }
}
