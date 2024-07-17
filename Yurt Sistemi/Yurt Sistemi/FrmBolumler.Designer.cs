namespace Yurt_Sistemi
{
    partial class FrmBolumler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet1 = new Yurt_Sistemi.yurt_vtDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbolumid = new System.Windows.Forms.TextBox();
            this.txtbolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbolumekle = new System.Windows.Forms.Button();
            this.btnbolumsil = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.bolumTableAdapter = new Yurt_Sistemi.yurt_vtDataSet1TableAdapters.bolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(363, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumadDataGridViewTextBoxColumn
            // 
            this.bolumadDataGridViewTextBoxColumn.DataPropertyName = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.HeaderText = "bolumad";
            this.bolumadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumadDataGridViewTextBoxColumn.Name = "bolumadDataGridViewTextBoxColumn";
            this.bolumadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "bolum";
            this.bolumBindingSource.DataSource = this.yurt_vtDataSet1;
            // 
            // yurt_vtDataSet1
            // 
            this.yurt_vtDataSet1.DataSetName = "yurt_vtDataSet1";
            this.yurt_vtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm ID:";
            // 
            // txtbolumid
            // 
            this.txtbolumid.Location = new System.Drawing.Point(118, 127);
            this.txtbolumid.Name = "txtbolumid";
            this.txtbolumid.Size = new System.Drawing.Size(200, 22);
            this.txtbolumid.TabIndex = 2;
            // 
            // txtbolumad
            // 
            this.txtbolumad.Location = new System.Drawing.Point(118, 172);
            this.txtbolumad.Name = "txtbolumad";
            this.txtbolumad.Size = new System.Drawing.Size(200, 22);
            this.txtbolumad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölüm Adı:";
            // 
            // btnbolumekle
            // 
            this.btnbolumekle.Location = new System.Drawing.Point(118, 252);
            this.btnbolumekle.Name = "btnbolumekle";
            this.btnbolumekle.Size = new System.Drawing.Size(156, 40);
            this.btnbolumekle.TabIndex = 5;
            this.btnbolumekle.Text = "Bölüm Ekle";
            this.btnbolumekle.UseVisualStyleBackColor = true;
            this.btnbolumekle.Click += new System.EventHandler(this.btnbolumekle_Click);
            // 
            // btnbolumsil
            // 
            this.btnbolumsil.Location = new System.Drawing.Point(118, 330);
            this.btnbolumsil.Name = "btnbolumsil";
            this.btnbolumsil.Size = new System.Drawing.Size(156, 40);
            this.btnbolumsil.TabIndex = 6;
            this.btnbolumsil.Text = "Bölüm Sil";
            this.btnbolumsil.UseVisualStyleBackColor = true;
            this.btnbolumsil.Click += new System.EventHandler(this.btnbolumsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(118, 405);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(156, 40);
            this.btnduzenle.TabIndex = 7;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btnbolumsil);
            this.Controls.Add(this.btnbolumekle);
            this.Controls.Add(this.txtbolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolumid;
        private System.Windows.Forms.TextBox txtbolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbolumekle;
        private System.Windows.Forms.Button btnbolumsil;
        private System.Windows.Forms.Button btnduzenle;
        private yurt_vtDataSet1 yurt_vtDataSet1;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private yurt_vtDataSet1TableAdapters.bolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadDataGridViewTextBoxColumn;
    }
}