namespace Yurt_Sistemi
{
    partial class FrmSikayet
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
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet10 = new Yurt_Sistemi.yurt_vtDataSet10();
            this.sikayetTableAdapter = new Yurt_Sistemi.yurt_vtDataSet10TableAdapters.sikayetTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odadegisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet11 = new Yurt_Sistemi.yurt_vtDataSet11();
            this.odadegisTableAdapter = new Yurt_Sistemi.yurt_vtDataSet11TableAdapters.odadegisTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odadegisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sikayetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            this.sikayetDataGridViewTextBoxColumn.Width = 300;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "konu";
            this.konuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            this.konuDataGridViewTextBoxColumn.Width = 125;
            // 
            // sikayetBindingSource
            // 
            this.sikayetBindingSource.DataMember = "sikayet";
            this.sikayetBindingSource.DataSource = this.yurt_vtDataSet10;
            // 
            // yurt_vtDataSet10
            // 
            this.yurt_vtDataSet10.DataSetName = "yurt_vtDataSet10";
            this.yurt_vtDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sikayetTableAdapter
            // 
            this.sikayetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn1,
            this.odaDataGridViewTextBoxColumn,
            this.acıklamaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.odadegisBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(670, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(590, 530);
            this.dataGridView2.TabIndex = 1;
            // 
            // ogridDataGridViewTextBoxColumn1
            // 
            this.ogridDataGridViewTextBoxColumn1.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn1.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn1.Name = "ogridDataGridViewTextBoxColumn1";
            this.ogridDataGridViewTextBoxColumn1.Width = 125;
            // 
            // odaDataGridViewTextBoxColumn
            // 
            this.odaDataGridViewTextBoxColumn.DataPropertyName = "oda";
            this.odaDataGridViewTextBoxColumn.HeaderText = "oda";
            this.odaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaDataGridViewTextBoxColumn.Name = "odaDataGridViewTextBoxColumn";
            this.odaDataGridViewTextBoxColumn.Width = 125;
            // 
            // acıklamaDataGridViewTextBoxColumn
            // 
            this.acıklamaDataGridViewTextBoxColumn.DataPropertyName = "acıklama";
            this.acıklamaDataGridViewTextBoxColumn.HeaderText = "acıklama";
            this.acıklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acıklamaDataGridViewTextBoxColumn.Name = "acıklamaDataGridViewTextBoxColumn";
            this.acıklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // odadegisBindingSource
            // 
            this.odadegisBindingSource.DataMember = "odadegis";
            this.odadegisBindingSource.DataSource = this.yurt_vtDataSet11;
            // 
            // yurt_vtDataSet11
            // 
            this.yurt_vtDataSet11.DataSetName = "yurt_vtDataSet11";
            this.yurt_vtDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odadegisTableAdapter
            // 
            this.odadegisTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şikayet ve Öneriler:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(680, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Değişim Talepleri:";
            // 
            // FrmSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1258, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmSikayet";
            this.Text = "Şikayet ve Öneriler";
            this.Load += new System.EventHandler(this.FrmSikayet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odadegisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurt_vtDataSet10 yurt_vtDataSet10;
        private System.Windows.Forms.BindingSource sikayetBindingSource;
        private yurt_vtDataSet10TableAdapters.sikayetTableAdapter sikayetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private yurt_vtDataSet11 yurt_vtDataSet11;
        private System.Windows.Forms.BindingSource odadegisBindingSource;
        private yurt_vtDataSet11TableAdapters.odadegisTableAdapter odadegisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}