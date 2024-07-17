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
    public partial class FrmSikayet : Form
    {
        public FrmSikayet()
        {
            InitializeComponent();
        }

        private void FrmSikayet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurt_vtDataSet11.odadegis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odadegisTableAdapter.Fill(this.yurt_vtDataSet11.odadegis);
            // TODO: Bu kod satırı 'yurt_vtDataSet10.sikayet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sikayetTableAdapter.Fill(this.yurt_vtDataSet10.sikayet);

        }
    }
}
