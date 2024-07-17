namespace Yurt_Sistemi
{
    partial class FrmOgrSil
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
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurt_vtDataSet = new Yurt_Sistemi.yurt_vtDataSet();
            this.ogrenciTableAdapter = new Yurt_Sistemi.yurt_vtDataSetTableAdapters.ogrenciTableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.mskvelitel = new System.Windows.Forms.MaskedTextBox();
            this.cmbodano = new System.Windows.Forms.ComboBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.mskdogum = new System.Windows.Forms.MaskedTextBox();
            this.mskogrtel = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.veliadsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtogrsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtograd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurt_vtDataSet;
            // 
            // yurt_vtDataSet
            // 
            this.yurt_vtDataSet.DataSetName = "yurt_vtDataSet";
            this.yurt_vtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(407, 343);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 45);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Kayıt Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(407, 280);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(83, 45);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // mskvelitel
            // 
            this.mskvelitel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskvelitel.Location = new System.Drawing.Point(153, 464);
            this.mskvelitel.Mask = "(999) 000-0000";
            this.mskvelitel.Name = "mskvelitel";
            this.mskvelitel.Size = new System.Drawing.Size(144, 26);
            this.mskvelitel.TabIndex = 49;
            // 
            // cmbodano
            // 
            this.cmbodano.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbodano.FormattingEnabled = true;
            this.cmbodano.Location = new System.Drawing.Point(153, 374);
            this.cmbodano.Name = "cmbodano";
            this.cmbodano.Size = new System.Drawing.Size(210, 26);
            this.cmbodano.TabIndex = 48;
            // 
            // cmbbolum
            // 
            this.cmbbolum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(153, 286);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(210, 26);
            this.cmbbolum.TabIndex = 47;
            // 
            // mskdogum
            // 
            this.mskdogum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdogum.Location = new System.Drawing.Point(153, 237);
            this.mskdogum.Mask = "00/00/0000";
            this.mskdogum.Name = "mskdogum";
            this.mskdogum.Size = new System.Drawing.Size(144, 26);
            this.mskdogum.TabIndex = 46;
            this.mskdogum.ValidatingType = typeof(System.DateTime);
            // 
            // mskogrtel
            // 
            this.mskogrtel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskogrtel.Location = new System.Drawing.Point(153, 192);
            this.mskogrtel.Mask = "(999) 000-0000";
            this.mskogrtel.Name = "mskogrtel";
            this.mskogrtel.Size = new System.Drawing.Size(144, 26);
            this.mskogrtel.TabIndex = 45;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(153, 142);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(144, 26);
            this.msktc.TabIndex = 44;
            this.msktc.ValidatingType = typeof(int);
            // 
            // rchadres
            // 
            this.rchadres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchadres.Location = new System.Drawing.Point(153, 509);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(252, 86);
            this.rchadres.TabIndex = 43;
            this.rchadres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(39, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "Adres :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Veli Telefon :";
            // 
            // veliadsoyad
            // 
            this.veliadsoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliadsoyad.Location = new System.Drawing.Point(153, 422);
            this.veliadsoyad.Name = "veliadsoyad";
            this.veliadsoyad.Size = new System.Drawing.Size(210, 26);
            this.veliadsoyad.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(2, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Veli Ad Soyad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Oda Numarası : ";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(153, 328);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(210, 26);
            this.txtmail.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mail : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bölüm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Doğum Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "TC : ";
            // 
            // txtogrsoyad
            // 
            this.txtogrsoyad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrsoyad.Location = new System.Drawing.Point(153, 96);
            this.txtogrsoyad.Name = "txtogrsoyad";
            this.txtogrsoyad.Size = new System.Drawing.Size(210, 26);
            this.txtogrsoyad.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Öğrenci Soyad : ";
            // 
            // txtograd
            // 
            this.txtograd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtograd.Location = new System.Drawing.Point(153, 52);
            this.txtograd.Name = "txtograd";
            this.txtograd.Size = new System.Drawing.Size(210, 26);
            this.txtograd.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Öğrenci Ad : ";
            // 
            // txtogrid
            // 
            this.txtogrid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrid.Location = new System.Drawing.Point(153, 12);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(210, 26);
            this.txtogrid.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(18, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "Öğrenci İd : ";
            // 
            // FrmOgrSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 598);
            this.Controls.Add(this.txtogrid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mskvelitel);
            this.Controls.Add(this.cmbodano);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.mskdogum);
            this.Controls.Add(this.mskogrtel);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.rchadres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.veliadsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtogrsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtograd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.MaximizeBox = false;
            this.Name = "FrmOgrSil";
            this.Text = "Öğrenci Silme ve Düzenleme";
            this.Load += new System.EventHandler(this.FrmOgrSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurt_vtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private yurt_vtDataSet yurt_vtDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private yurt_vtDataSetTableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.MaskedTextBox mskvelitel;
        private System.Windows.Forms.ComboBox cmbodano;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.MaskedTextBox mskdogum;
        private System.Windows.Forms.MaskedTextBox mskogrtel;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox veliadsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtogrsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtograd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogrid;
        private System.Windows.Forms.Label label12;
    }
}