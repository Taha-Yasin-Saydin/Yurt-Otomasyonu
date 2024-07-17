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
    public partial class OgrAnamenu : Form
    {
        public OgrAnamenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Taha Yasin SAYDIN tarafından YBS bitirme projesi olarak tasarlanmıştır.");
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            OgrOdeme fr = new OgrOdeme();
            fr.Show();
        }

        private void btnodadegis_Click(object sender, EventArgs e)
        {
            OgrOdaDegis fr = new OgrOdaDegis();
            fr.Show();
        }

        private void btnsikayet_Click(object sender, EventArgs e)
        {
            OgrSikayet fr = new OgrSikayet();
            fr.Show();
        }

        private void btnizin_Click(object sender, EventArgs e)
        {
            Ogrİzin fr = new Ogrİzin();
            fr.Show();
        }

        private void btnyemek_Click(object sender, EventArgs e)
        {
            OgrYemekhane fr = new OgrYemekhane();
            fr.Show();
        }

        private void OgrAnamenu_Load(object sender, EventArgs e)
        {

        }
    }
}
