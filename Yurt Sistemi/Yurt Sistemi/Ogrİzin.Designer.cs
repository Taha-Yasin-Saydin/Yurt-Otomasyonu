namespace Yurt_Sistemi
{
    partial class Ogrİzin
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
            this.label1 = new System.Windows.Forms.Label();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.btntalep = new System.Windows.Forms.Button();
            this.mskizinbit = new System.Windows.Forms.MaskedTextBox();
            this.mskizinbaş = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin alma nedeni:";
            // 
            // rchaciklama
            // 
            this.rchaciklama.Location = new System.Drawing.Point(135, 25);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(207, 96);
            this.rchaciklama.TabIndex = 1;
            this.rchaciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İzin başlangıç tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "İzin bitiş tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "İzin adresi:";
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(504, 101);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(207, 96);
            this.rchadres.TabIndex = 7;
            this.rchadres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon numarası:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(551, 274);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(127, 22);
            this.msktel.TabIndex = 9;
            // 
            // btntalep
            // 
            this.btntalep.Location = new System.Drawing.Point(366, 383);
            this.btntalep.Name = "btntalep";
            this.btntalep.Size = new System.Drawing.Size(108, 32);
            this.btntalep.TabIndex = 10;
            this.btntalep.Text = "Talep Gönder";
            this.btntalep.UseVisualStyleBackColor = true;
            this.btntalep.Click += new System.EventHandler(this.btntalep_Click);
            // 
            // mskizinbit
            // 
            this.mskizinbit.Location = new System.Drawing.Point(152, 305);
            this.mskizinbit.Mask = "00/00/0000";
            this.mskizinbit.Name = "mskizinbit";
            this.mskizinbit.Size = new System.Drawing.Size(124, 22);
            this.mskizinbit.TabIndex = 12;
            this.mskizinbit.ValidatingType = typeof(System.DateTime);
            // 
            // mskizinbaş
            // 
            this.mskizinbaş.Location = new System.Drawing.Point(152, 224);
            this.mskizinbaş.Mask = "00/00/0000";
            this.mskizinbaş.Name = "mskizinbaş";
            this.mskizinbaş.Size = new System.Drawing.Size(124, 22);
            this.mskizinbaş.TabIndex = 13;
            this.mskizinbaş.ValidatingType = typeof(System.DateTime);
            // 
            // Ogrİzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskizinbaş);
            this.Controls.Add(this.mskizinbit);
            this.Controls.Add(this.btntalep);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rchadres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchaciklama);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Ogrİzin";
            this.Text = "İzin Alma";
            this.Load += new System.EventHandler(this.Ogrİzin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Button btntalep;
        private System.Windows.Forms.MaskedTextBox mskizinbit;
        private System.Windows.Forms.MaskedTextBox mskizinbaş;
    }
}