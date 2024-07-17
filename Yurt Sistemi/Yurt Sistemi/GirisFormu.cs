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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Giris1 fr = new Giris1();
            fr.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OgrAnamenu fr = new OgrAnamenu();  
            fr.Show();
            
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
