namespace Yurt_Sistemi
{
    partial class OgrSikayet
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
            this.radiobtnsikayet = new System.Windows.Forms.RadioButton();
            this.radiobtnoneri = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rchtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konu :";
            // 
            // radiobtnsikayet
            // 
            this.radiobtnsikayet.AutoSize = true;
            this.radiobtnsikayet.Location = new System.Drawing.Point(98, 26);
            this.radiobtnsikayet.Name = "radiobtnsikayet";
            this.radiobtnsikayet.Size = new System.Drawing.Size(73, 20);
            this.radiobtnsikayet.TabIndex = 1;
            this.radiobtnsikayet.TabStop = true;
            this.radiobtnsikayet.Text = "Şikayet";
            this.radiobtnsikayet.UseVisualStyleBackColor = true;
            // 
            // radiobtnoneri
            // 
            this.radiobtnoneri.AutoSize = true;
            this.radiobtnoneri.Location = new System.Drawing.Point(98, 71);
            this.radiobtnoneri.Name = "radiobtnoneri";
            this.radiobtnoneri.Size = new System.Drawing.Size(60, 20);
            this.radiobtnoneri.TabIndex = 2;
            this.radiobtnoneri.TabStop = true;
            this.radiobtnoneri.Text = "Öneri";
            this.radiobtnoneri.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama :";
            // 
            // rchtxtsikayet
            // 
            this.rchtxtsikayet.Location = new System.Drawing.Point(122, 132);
            this.rchtxtsikayet.Name = "rchtxtsikayet";
            this.rchtxtsikayet.Size = new System.Drawing.Size(380, 294);
            this.rchtxtsikayet.TabIndex = 4;
            this.rchtxtsikayet.Text = "";
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(275, 453);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(83, 27);
            this.btngonder.TabIndex = 5;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // OgrSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 520);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.rchtxtsikayet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiobtnoneri);
            this.Controls.Add(this.radiobtnsikayet);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "OgrSikayet";
            this.Text = "Şikayet ve Öneriler";
            this.Load += new System.EventHandler(this.OgrSikayet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobtnsikayet;
        private System.Windows.Forms.RadioButton radiobtnoneri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchtxtsikayet;
        private System.Windows.Forms.Button btngonder;
    }
}