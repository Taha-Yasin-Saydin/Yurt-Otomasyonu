namespace Yurt_Sistemi
{
    partial class FrmPersonel
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prsad = new System.Windows.Forms.TextBox();
            this.prssoyad = new System.Windows.Forms.TextBox();
            this.prsgorev = new System.Windows.Forms.TextBox();
            this.prsadres = new System.Windows.Forms.RichTextBox();
            this.prstel = new System.Windows.Forms.MaskedTextBox();
            this.prsdogum = new System.Windows.Forms.MaskedTextBox();
            this.prstc = new System.Windows.Forms.MaskedTextBox();
            this.prscins = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeldgmtrhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelcinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelgorevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet4 = new Yurt_Sistemi.yurt_vtDataSet4();
            this.personelTableAdapter = new Yurt_Sistemi.yurt_vtDataSet4TableAdapters.personelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC Kimlik No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Görev:";
            // 
            // prsad
            // 
            this.prsad.Location = new System.Drawing.Point(136, 21);
            this.prsad.Name = "prsad";
            this.prsad.Size = new System.Drawing.Size(164, 22);
            this.prsad.TabIndex = 8;
            // 
            // prssoyad
            // 
            this.prssoyad.Location = new System.Drawing.Point(136, 58);
            this.prssoyad.Name = "prssoyad";
            this.prssoyad.Size = new System.Drawing.Size(164, 22);
            this.prssoyad.TabIndex = 9;
            this.prssoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prsgorev
            // 
            this.prsgorev.Location = new System.Drawing.Point(136, 349);
            this.prsgorev.Name = "prsgorev";
            this.prsgorev.Size = new System.Drawing.Size(164, 22);
            this.prsgorev.TabIndex = 10;
            // 
            // prsadres
            // 
            this.prsadres.Location = new System.Drawing.Point(136, 226);
            this.prsadres.Name = "prsadres";
            this.prsadres.Size = new System.Drawing.Size(164, 93);
            this.prsadres.TabIndex = 11;
            this.prsadres.Text = "";
            // 
            // prstel
            // 
            this.prstel.Location = new System.Drawing.Point(136, 157);
            this.prstel.Mask = "(999) 000-0000";
            this.prstel.Name = "prstel";
            this.prstel.Size = new System.Drawing.Size(164, 22);
            this.prstel.TabIndex = 12;
            // 
            // prsdogum
            // 
            this.prsdogum.Location = new System.Drawing.Point(136, 91);
            this.prsdogum.Mask = "00/00/0000";
            this.prsdogum.Name = "prsdogum";
            this.prsdogum.Size = new System.Drawing.Size(164, 22);
            this.prsdogum.TabIndex = 13;
            this.prsdogum.ValidatingType = typeof(System.DateTime);
            // 
            // prstc
            // 
            this.prstc.Location = new System.Drawing.Point(136, 190);
            this.prstc.Mask = "00000000000";
            this.prstc.Name = "prstc";
            this.prstc.Size = new System.Drawing.Size(164, 22);
            this.prstc.TabIndex = 14;
            // 
            // prscins
            // 
            this.prscins.FormattingEnabled = true;
            this.prscins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.prscins.Location = new System.Drawing.Point(136, 127);
            this.prscins.Name = "prscins";
            this.prscins.Size = new System.Drawing.Size(164, 24);
            this.prscins.TabIndex = 15;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(171, 396);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(97, 27);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personeladDataGridViewTextBoxColumn,
            this.personelsoyadDataGridViewTextBoxColumn,
            this.personeldgmtrhDataGridViewTextBoxColumn,
            this.personelcinsiyetDataGridViewTextBoxColumn,
            this.personeltelefonDataGridViewTextBoxColumn,
            this.personeltcDataGridViewTextBoxColumn,
            this.personeladresDataGridViewTextBoxColumn,
            this.personelgorevDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(322, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 435);
            this.dataGridView1.TabIndex = 17;
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeladDataGridViewTextBoxColumn
            // 
            this.personeladDataGridViewTextBoxColumn.DataPropertyName = "personelad";
            this.personeladDataGridViewTextBoxColumn.HeaderText = "personelad";
            this.personeladDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeladDataGridViewTextBoxColumn.Name = "personeladDataGridViewTextBoxColumn";
            this.personeladDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsoyadDataGridViewTextBoxColumn
            // 
            this.personelsoyadDataGridViewTextBoxColumn.DataPropertyName = "personelsoyad";
            this.personelsoyadDataGridViewTextBoxColumn.HeaderText = "personelsoyad";
            this.personelsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsoyadDataGridViewTextBoxColumn.Name = "personelsoyadDataGridViewTextBoxColumn";
            this.personelsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeldgmtrhDataGridViewTextBoxColumn
            // 
            this.personeldgmtrhDataGridViewTextBoxColumn.DataPropertyName = "personeldgmtrh";
            this.personeldgmtrhDataGridViewTextBoxColumn.HeaderText = "personeldgmtrh";
            this.personeldgmtrhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeldgmtrhDataGridViewTextBoxColumn.Name = "personeldgmtrhDataGridViewTextBoxColumn";
            this.personeldgmtrhDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelcinsiyetDataGridViewTextBoxColumn
            // 
            this.personelcinsiyetDataGridViewTextBoxColumn.DataPropertyName = "personelcinsiyet";
            this.personelcinsiyetDataGridViewTextBoxColumn.HeaderText = "personelcinsiyet";
            this.personelcinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelcinsiyetDataGridViewTextBoxColumn.Name = "personelcinsiyetDataGridViewTextBoxColumn";
            this.personelcinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeltelefonDataGridViewTextBoxColumn
            // 
            this.personeltelefonDataGridViewTextBoxColumn.DataPropertyName = "personeltelefon";
            this.personeltelefonDataGridViewTextBoxColumn.HeaderText = "personeltelefon";
            this.personeltelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeltelefonDataGridViewTextBoxColumn.Name = "personeltelefonDataGridViewTextBoxColumn";
            this.personeltelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeltcDataGridViewTextBoxColumn
            // 
            this.personeltcDataGridViewTextBoxColumn.DataPropertyName = "personeltc";
            this.personeltcDataGridViewTextBoxColumn.HeaderText = "personeltc";
            this.personeltcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeltcDataGridViewTextBoxColumn.Name = "personeltcDataGridViewTextBoxColumn";
            this.personeltcDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeladresDataGridViewTextBoxColumn
            // 
            this.personeladresDataGridViewTextBoxColumn.DataPropertyName = "personeladres";
            this.personeladresDataGridViewTextBoxColumn.HeaderText = "personeladres";
            this.personeladresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeladresDataGridViewTextBoxColumn.Name = "personeladresDataGridViewTextBoxColumn";
            this.personeladresDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelgorevDataGridViewTextBoxColumn
            // 
            this.personelgorevDataGridViewTextBoxColumn.DataPropertyName = "personelgorev";
            this.personelgorevDataGridViewTextBoxColumn.HeaderText = "personelgorev";
            this.personelgorevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelgorevDataGridViewTextBoxColumn.Name = "personelgorevDataGridViewTextBoxColumn";
            this.personelgorevDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.yurt_vtDataSet4;
            // 
            // yurt_vtDataSet4
            // 
            this.yurt_vtDataSet4.DataSetName = "yurt_vtDataSet4";
            this.yurt_vtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.prscins);
            this.Controls.Add(this.prstc);
            this.Controls.Add(this.prsdogum);
            this.Controls.Add(this.prstel);
            this.Controls.Add(this.prsadres);
            this.Controls.Add(this.prsgorev);
            this.Controls.Add(this.prssoyad);
            this.Controls.Add(this.prsad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prsad;
        private System.Windows.Forms.TextBox prssoyad;
        private System.Windows.Forms.TextBox prsgorev;
        private System.Windows.Forms.RichTextBox prsadres;
        private System.Windows.Forms.MaskedTextBox prstel;
        private System.Windows.Forms.MaskedTextBox prsdogum;
        private System.Windows.Forms.MaskedTextBox prstc;
        private System.Windows.Forms.ComboBox prscins;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yurt_vtDataSet4 yurt_vtDataSet4;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private yurt_vtDataSet4TableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeldgmtrhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelcinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeltelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeltcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelgorevDataGridViewTextBoxColumn;
    }
}