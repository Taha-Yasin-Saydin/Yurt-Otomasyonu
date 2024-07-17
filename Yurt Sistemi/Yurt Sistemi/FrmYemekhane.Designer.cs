namespace Yurt_Sistemi
{
    partial class FrmYemekhane
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
            this.menuadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oysayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekhanemenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet15 = new Yurt_Sistemi.yurt_vtDataSet15();
            this.sıralaToolStrip = new System.Windows.Forms.ToolStrip();
            this.sıralaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yemekhanemenuTableAdapter = new Yurt_Sistemi.yurt_vtDataSet15TableAdapters.yemekhanemenuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsıfırla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhanemenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet15)).BeginInit();
            this.sıralaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuadDataGridViewTextBoxColumn,
            this.oysayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yemekhanemenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuadDataGridViewTextBoxColumn
            // 
            this.menuadDataGridViewTextBoxColumn.DataPropertyName = "menuad";
            this.menuadDataGridViewTextBoxColumn.HeaderText = "menuad";
            this.menuadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuadDataGridViewTextBoxColumn.Name = "menuadDataGridViewTextBoxColumn";
            this.menuadDataGridViewTextBoxColumn.Width = 125;
            // 
            // oysayisiDataGridViewTextBoxColumn
            // 
            this.oysayisiDataGridViewTextBoxColumn.DataPropertyName = "oysayisi";
            this.oysayisiDataGridViewTextBoxColumn.HeaderText = "oysayisi";
            this.oysayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oysayisiDataGridViewTextBoxColumn.Name = "oysayisiDataGridViewTextBoxColumn";
            this.oysayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yemekhanemenuBindingSource
            // 
            this.yemekhanemenuBindingSource.DataMember = "yemekhanemenu";
            this.yemekhanemenuBindingSource.DataSource = this.yurt_vtDataSet15;
            // 
            // yurt_vtDataSet15
            // 
            this.yurt_vtDataSet15.DataSetName = "yurt_vtDataSet15";
            this.yurt_vtDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sıralaToolStrip
            // 
            this.sıralaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sıralaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sıralaToolStripButton});
            this.sıralaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sıralaToolStrip.Name = "sıralaToolStrip";
            this.sıralaToolStrip.Size = new System.Drawing.Size(564, 27);
            this.sıralaToolStrip.TabIndex = 1;
            this.sıralaToolStrip.Text = "sıralaToolStrip";
            // 
            // sıralaToolStripButton
            // 
            this.sıralaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sıralaToolStripButton.Name = "sıralaToolStripButton";
            this.sıralaToolStripButton.Size = new System.Drawing.Size(50, 24);
            this.sıralaToolStripButton.Text = "Sırala";
            this.sıralaToolStripButton.Click += new System.EventHandler(this.sıralaToolStripButton_Click);
            // 
            // yemekhanemenuTableAdapter
            // 
            this.yemekhanemenuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "* \"Sırala\"ya basarak en yüksek oy alan\r\nmenüyü görüntüleyebilirsiniz.";
            // 
            // btnsıfırla
            // 
            this.btnsıfırla.Location = new System.Drawing.Point(12, 373);
            this.btnsıfırla.Name = "btnsıfırla";
            this.btnsıfırla.Size = new System.Drawing.Size(99, 33);
            this.btnsıfırla.TabIndex = 3;
            this.btnsıfırla.Text = "Sıfırla";
            this.btnsıfırla.UseVisualStyleBackColor = true;
            this.btnsıfırla.Click += new System.EventHandler(this.btnsıfırla_Click);
            // 
            // FrmYemekhane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 418);
            this.Controls.Add(this.btnsıfırla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sıralaToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmYemekhane";
            this.Text = "Yemekhane Anket";
            this.Load += new System.EventHandler(this.FrmYemekhane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhanemenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet15)).EndInit();
            this.sıralaToolStrip.ResumeLayout(false);
            this.sıralaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yurt_vtDataSet15 yurt_vtDataSet15;
        private System.Windows.Forms.BindingSource yemekhanemenuBindingSource;
        private yurt_vtDataSet15TableAdapters.yemekhanemenuTableAdapter yemekhanemenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oysayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip sıralaToolStrip;
        private System.Windows.Forms.ToolStripButton sıralaToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsıfırla;
    }
}