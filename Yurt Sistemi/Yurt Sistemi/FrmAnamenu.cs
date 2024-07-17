using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Sistemi
{
    public partial class FrmAnamenu : Form
    {
        public FrmAnamenu()
        {
            InitializeComponent();
            
        }
        private void FrmAnamenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnogrkayit_Click(object sender, EventArgs e)
        {
            FrmOgrKayit fr = new FrmOgrKayit(); 
            fr.Show();
        }

        private void btnogrsil_Click(object sender, EventArgs e)
        {
            FrmOgrSil0 fr = new FrmOgrSil0();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void btnodm_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme();
            frm.Show();
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Taha Yasin SAYDIN tarafından YBS bitirme projesi olarak tasarlanmıştır.");
        }

        private void btnyntc_Click(object sender, EventArgs e)
        {
            FrmYonetici frm = new FrmYonetici();
            frm.Show();
        }

        private void btngdr_Click(object sender, EventArgs e)
        {
            FrmGiderler frm = new FrmGiderler();
            frm.Show();
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            FrmSikayet frm = new FrmSikayet();
            frm.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYemekhane frm = new FrmYemekhane();  
            frm.Show();
        }
    }
}
