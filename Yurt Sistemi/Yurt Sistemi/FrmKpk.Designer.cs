namespace Yurt_Sistemi
{
    partial class FrmKpk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new Yurt_Sistemi.yurt_vtDataSet7TableAdapters.ogrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet9 = new Yurt_Sistemi.yurt_vtDataSet9();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new Yurt_Sistemi.yurt_vtDataSet8TableAdapters.ogrenciTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textbagıs = new System.Windows.Forms.TextBox();
            this.texttopbagıs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textogrid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenciTableAdapter2 = new Yurt_Sistemi.yurt_vtDataSet9TableAdapters.ogrenciTableAdapter();
            this.sIRALAToolStrip = new System.Windows.Forms.ToolStrip();
            this.sIRALAToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            this.sIRALAToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci\r\nSıralaması:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kapakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(81, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 441);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // kapakDataGridViewTextBoxColumn
            // 
            this.kapakDataGridViewTextBoxColumn.DataPropertyName = "kapak";
            this.kapakDataGridViewTextBoxColumn.HeaderText = "kapak";
            this.kapakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapakDataGridViewTextBoxColumn.Name = "kapakDataGridViewTextBoxColumn";
            this.kapakDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "ogrenci";
            this.ogrenciBindingSource2.DataSource = this.yurt_vtDataSet9;
            // 
            // yurt_vtDataSet9
            // 
            this.yurt_vtDataSet9.DataSetName = "yurt_vtDataSet9";
            this.yurt_vtDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "ogrenci";
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bağış :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Toplam Kapak :";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(932, 128);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(141, 22);
            this.textad.TabIndex = 7;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(932, 169);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(141, 22);
            this.textsoyad.TabIndex = 8;
            // 
            // textbagıs
            // 
            this.textbagıs.Location = new System.Drawing.Point(932, 210);
            this.textbagıs.Name = "textbagıs";
            this.textbagıs.Size = new System.Drawing.Size(141, 22);
            this.textbagıs.TabIndex = 9;
            // 
            // texttopbagıs
            // 
            this.texttopbagıs.Location = new System.Drawing.Point(932, 251);
            this.texttopbagıs.Name = "texttopbagıs";
            this.texttopbagıs.Size = new System.Drawing.Size(141, 22);
            this.texttopbagıs.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textogrid
            // 
            this.textogrid.Location = new System.Drawing.Point(932, 91);
            this.textogrid.Name = "textogrid";
            this.textogrid.Size = new System.Drawing.Size(141, 22);
            this.textogrid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Öğrenci Id :";
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // sIRALAToolStrip
            // 
            this.sIRALAToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sIRALAToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sIRALAToolStripButton});
            this.sIRALAToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sIRALAToolStrip.Name = "sIRALAToolStrip";
            this.sIRALAToolStrip.Size = new System.Drawing.Size(1132, 27);
            this.sIRALAToolStrip.TabIndex = 14;
            this.sIRALAToolStrip.Text = "sIRALAToolStrip";
            // 
            // sIRALAToolStripButton
            // 
            this.sIRALAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sIRALAToolStripButton.Name = "sIRALAToolStripButton";
            this.sIRALAToolStripButton.Size = new System.Drawing.Size(61, 24);
            this.sIRALAToolStripButton.Text = "SIRALA";
            this.sIRALAToolStripButton.Click += new System.EventHandler(this.sIRALAToolStripButton_Click);
            // 
            // FrmKpk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1132, 491);
            this.Controls.Add(this.sIRALAToolStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textogrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texttopbagıs);
            this.Controls.Add(this.textbagıs);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmKpk";
            this.Text = "Mavi Kapak Projesi";
            this.Load += new System.EventHandler(this.FrmKpk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            this.sIRALAToolStrip.ResumeLayout(false);
            this.sIRALAToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurt_vtDataSet7TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private yurt_vtDataSet8TableAdapters.ogrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textbagıs;
        private System.Windows.Forms.TextBox texttopbagıs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textogrid;
        private System.Windows.Forms.Label label6;
        private yurt_vtDataSet9 yurt_vtDataSet9;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private yurt_vtDataSet9TableAdapters.ogrenciTableAdapter ogrenciTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapakDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip sIRALAToolStrip;
        private System.Windows.Forms.ToolStripButton sIRALAToolStripButton;
    }
}