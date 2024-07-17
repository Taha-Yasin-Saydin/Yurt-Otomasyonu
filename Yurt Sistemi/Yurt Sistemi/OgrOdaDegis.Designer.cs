namespace Yurt_Sistemi
{
    partial class OgrOdaDegis
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
            this.cmbodalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbodalar
            // 
            this.cmbodalar.FormattingEnabled = true;
            this.cmbodalar.Location = new System.Drawing.Point(178, 83);
            this.cmbodalar.Name = "cmbodalar";
            this.cmbodalar.Size = new System.Drawing.Size(121, 24);
            this.cmbodalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gitmek istediğiniz odayı seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gidebileceğiniz Odalar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Talep nedeni :";
            // 
            // rchaciklama
            // 
            this.rchaciklama.Location = new System.Drawing.Point(124, 150);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(270, 288);
            this.rchaciklama.TabIndex = 4;
            this.rchaciklama.Text = "";
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(209, 445);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(109, 40);
            this.btngonder.TabIndex = 5;
            this.btngonder.Text = "Talep Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // OgrOdaDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(442, 497);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.rchaciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbodalar);
            this.MaximizeBox = false;
            this.Name = "OgrOdaDegis";
            this.Text = "Oda Değiştirme Talebi";
            this.Load += new System.EventHandler(this.OgrOdaDegis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbodalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchaciklama;
        private System.Windows.Forms.Button btngonder;
    }
}