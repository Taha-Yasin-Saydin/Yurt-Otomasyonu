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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Yurt_Sistemi
{
    public partial class OgrYemekhane : Form
    {
        public OgrYemekhane()
        {
            InitializeComponent();
        }

          Sqlbaglanti bgl = new Sqlbaglanti();

        private void OgrYemekhane_Load(object sender, EventArgs e)
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
        }




        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string selectedMenu = "";

            if (radio1.Checked)
            {
                selectedMenu = "Menu1";
            }
            else if (radio2.Checked)
            {
                selectedMenu = "Menu2";
            }
            else if (radio3.Checked)
            {
                selectedMenu = "Menu3";
            }
            else if (radio4.Checked)
            {
                selectedMenu = "Menu4";
            }
            else if (radio5.Checked)
            {
                selectedMenu = "Menu5";
            }

            if (!string.IsNullOrEmpty(selectedMenu))
            {
                
                    string query = "UPDATE yemekhanemenu SET oysayisi = oysayisi + 1 WHERE menuad = @menuAd";
                    SqlCommand command = new SqlCommand(query, bgl.baglanti());
                    command.Parameters.AddWithValue("@menuad", selectedMenu);
                    bgl.baglanti().Close();

                    try
                    {
                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected >= 0)
                        {
                            MessageBox.Show("Oyunuz kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Oyunuz kaydedilemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            else
            {
                MessageBox.Show("Lütfen bir menü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ogrmenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
