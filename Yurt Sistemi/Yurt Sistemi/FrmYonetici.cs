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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Web tasarım, Gitar ve Saz, Yazılım, Girişimcilik, Diksiyon, Hattat, Ebru, Temel Dini Bilgiler, Arapça, Rusça, İngilizce, İspanyolca, Aşçılık");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdaDoluluk fr = new FrmOdaDoluluk();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmKpk fr = new FrmKpk();
            fr.Show();
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmİzin fr = new Frmİzin();
            fr.Show();
        }
    }
}
