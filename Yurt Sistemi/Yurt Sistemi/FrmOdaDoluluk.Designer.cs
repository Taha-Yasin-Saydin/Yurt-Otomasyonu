namespace Yurt_Sistemi
{
    partial class FrmOdaDoluluk
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
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odakapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odadolulukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet6 = new Yurt_Sistemi.yurt_vtDataSet6();
            this.odaTableAdapter = new Yurt_Sistemi.yurt_vtDataSet6TableAdapters.odaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odanoDataGridViewTextBoxColumn,
            this.odakapasiteDataGridViewTextBoxColumn,
            this.odadolulukDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "odano";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "odano";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // odakapasiteDataGridViewTextBoxColumn
            // 
            this.odakapasiteDataGridViewTextBoxColumn.DataPropertyName = "odakapasite";
            this.odakapasiteDataGridViewTextBoxColumn.HeaderText = "odakapasite";
            this.odakapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odakapasiteDataGridViewTextBoxColumn.Name = "odakapasiteDataGridViewTextBoxColumn";
            this.odakapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // odadolulukDataGridViewTextBoxColumn
            // 
            this.odadolulukDataGridViewTextBoxColumn.DataPropertyName = "odadoluluk";
            this.odadolulukDataGridViewTextBoxColumn.HeaderText = "odadoluluk";
            this.odadolulukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odadolulukDataGridViewTextBoxColumn.Name = "odadolulukDataGridViewTextBoxColumn";
            this.odadolulukDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaBindingSource
            // 
            this.odaBindingSource.DataMember = "oda";
            this.odaBindingSource.DataSource = this.yurt_vtDataSet6;
            // 
            // yurt_vtDataSet6
            // 
            this.yurt_vtDataSet6.DataSetName = "yurt_vtDataSet6";
            this.yurt_vtDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaTableAdapter
            // 
            this.odaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOdaDoluluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(595, 520);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmOdaDoluluk";
            this.Text = "Oda Doluluk";
            this.Load += new System.EventHandler(this.FrmOdaDoluluk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurt_vtDataSet6 yurt_vtDataSet6;
        private System.Windows.Forms.BindingSource odaBindingSource;
        private yurt_vtDataSet6TableAdapters.odaTableAdapter odaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odakapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odadolulukDataGridViewTextBoxColumn;
    }
}