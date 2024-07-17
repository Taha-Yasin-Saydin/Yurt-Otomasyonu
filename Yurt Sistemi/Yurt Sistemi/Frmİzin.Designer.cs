namespace Yurt_Sistemi
{
    partial class Frmİzin
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
            this.yurt_vtDataSet12 = new Yurt_Sistemi.yurt_vtDataSet12();
            this.ogrenciizinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciizinTableAdapter = new Yurt_Sistemi.yurt_vtDataSet12TableAdapters.ogrenciizinTableAdapter();
            this.yurt_vtDataSet13 = new Yurt_Sistemi.yurt_vtDataSet13();
            this.ogrenciizinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciizinTableAdapter1 = new Yurt_Sistemi.yurt_vtDataSet13TableAdapters.ogrenciizinTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikistarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciizinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet14 = new Yurt_Sistemi.yurt_vtDataSet14();
            this.ogrenciizinTableAdapter2 = new Yurt_Sistemi.yurt_vtDataSet14TableAdapters.ogrenciizinTableAdapter();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcikis = new System.Windows.Forms.TextBox();
            this.txtgiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnonay = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // yurt_vtDataSet12
            // 
            this.yurt_vtDataSet12.DataSetName = "yurt_vtDataSet12";
            this.yurt_vtDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciizinBindingSource
            // 
            this.ogrenciizinBindingSource.DataMember = "ogrenciizin";
            this.ogrenciizinBindingSource.DataSource = this.yurt_vtDataSet12;
            // 
            // ogrenciizinTableAdapter
            // 
            this.ogrenciizinTableAdapter.ClearBeforeFill = true;
            // 
            // yurt_vtDataSet13
            // 
            this.yurt_vtDataSet13.DataSetName = "yurt_vtDataSet13";
            this.yurt_vtDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciizinBindingSource1
            // 
            this.ogrenciizinBindingSource1.DataMember = "ogrenciizin";
            this.ogrenciizinBindingSource1.DataSource = this.yurt_vtDataSet13;
            // 
            // ogrenciizinTableAdapter1
            // 
            this.ogrenciizinTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.giristarihDataGridViewTextBoxColumn,
            this.cikistarihDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.onayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciizinBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1537, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // giristarihDataGridViewTextBoxColumn
            // 
            this.giristarihDataGridViewTextBoxColumn.DataPropertyName = "giristarih";
            this.giristarihDataGridViewTextBoxColumn.HeaderText = "giristarih";
            this.giristarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giristarihDataGridViewTextBoxColumn.Name = "giristarihDataGridViewTextBoxColumn";
            this.giristarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikistarihDataGridViewTextBoxColumn
            // 
            this.cikistarihDataGridViewTextBoxColumn.DataPropertyName = "cikistarih";
            this.cikistarihDataGridViewTextBoxColumn.HeaderText = "cikistarih";
            this.cikistarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikistarihDataGridViewTextBoxColumn.Name = "cikistarihDataGridViewTextBoxColumn";
            this.cikistarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 390;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // onayDataGridViewTextBoxColumn
            // 
            this.onayDataGridViewTextBoxColumn.DataPropertyName = "onay";
            this.onayDataGridViewTextBoxColumn.HeaderText = "onay";
            this.onayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onayDataGridViewTextBoxColumn.Name = "onayDataGridViewTextBoxColumn";
            this.onayDataGridViewTextBoxColumn.Width = 85;
            // 
            // ogrenciizinBindingSource2
            // 
            this.ogrenciizinBindingSource2.DataMember = "ogrenciizin";
            this.ogrenciizinBindingSource2.DataSource = this.yurt_vtDataSet14;
            // 
            // yurt_vtDataSet14
            // 
            this.yurt_vtDataSet14.DataSetName = "yurt_vtDataSet14";
            this.yurt_vtDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciizinTableAdapter2
            // 
            this.ogrenciizinTableAdapter2.ClearBeforeFill = true;
            // 
            // txtogrid
            // 
            this.txtogrid.Location = new System.Drawing.Point(177, 616);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(100, 22);
            this.txtogrid.TabIndex = 1;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(177, 682);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 22);
            this.txttel.TabIndex = 2;
            // 
            // txtcikis
            // 
            this.txtcikis.Location = new System.Drawing.Point(544, 616);
            this.txtcikis.Name = "txtcikis";
            this.txtcikis.Size = new System.Drawing.Size(100, 22);
            this.txtcikis.TabIndex = 3;
            // 
            // txtgiris
            // 
            this.txtgiris.Location = new System.Drawing.Point(544, 682);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Size = new System.Drawing.Size(100, 22);
            this.txtgiris.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Çıkış) İzin Başlangıç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 685);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Giriş) İzin Bitiş Tarihi:";
            // 
            // btnonay
            // 
            this.btnonay.Location = new System.Drawing.Point(885, 643);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(102, 47);
            this.btnonay.TabIndex = 9;
            this.btnonay.Text = "Onay\r\n";
            this.btnonay.UseVisualStyleBackColor = true;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // btnred
            // 
            this.btnred.Location = new System.Drawing.Point(1131, 643);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(102, 47);
            this.btnred.TabIndex = 10;
            this.btnred.Text = "Red";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // Frmİzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1537, 763);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.btnonay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgiris);
            this.Controls.Add(this.txtcikis);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtogrid);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Frmİzin";
            this.Text = "İzin";
            this.Load += new System.EventHandler(this.Frmİzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciizinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private yurt_vtDataSet12 yurt_vtDataSet12;
        private System.Windows.Forms.BindingSource ogrenciizinBindingSource;
        private yurt_vtDataSet12TableAdapters.ogrenciizinTableAdapter ogrenciizinTableAdapter;
        private yurt_vtDataSet13 yurt_vtDataSet13;
        private System.Windows.Forms.BindingSource ogrenciizinBindingSource1;
        private yurt_vtDataSet13TableAdapters.ogrenciizinTableAdapter ogrenciizinTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurt_vtDataSet14 yurt_vtDataSet14;
        private System.Windows.Forms.BindingSource ogrenciizinBindingSource2;
        private yurt_vtDataSet14TableAdapters.ogrenciizinTableAdapter ogrenciizinTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onayDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtogrid;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcikis;
        private System.Windows.Forms.TextBox txtgiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.Button btnred;
    }
}