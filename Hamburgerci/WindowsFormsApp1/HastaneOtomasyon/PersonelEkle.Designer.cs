namespace HastaneOtomasyon
{
    partial class PersonelEkle
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
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.rdbTemizlikci = new System.Windows.Forms.RadioButton();
            this.rdbSekreter = new System.Windows.Forms.RadioButton();
            this.rdbEbe = new System.Windows.Forms.RadioButton();
            this.rdbHemsire = new System.Windows.Forms.RadioButton();
            this.rdbDoktor = new System.Windows.Forms.RadioButton();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.cmbAlan = new System.Windows.Forms.ComboBox();
            this.lblAlan = new System.Windows.Forms.Label();
            this.cmbBina = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rdbTemizlikci);
            this.gbRadio.Controls.Add(this.rdbSekreter);
            this.gbRadio.Controls.Add(this.rdbEbe);
            this.gbRadio.Controls.Add(this.rdbHemsire);
            this.gbRadio.Controls.Add(this.rdbDoktor);
            this.gbRadio.Location = new System.Drawing.Point(285, 25);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(200, 84);
            this.gbRadio.TabIndex = 37;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Eklenecek Personel";
            // 
            // rdbTemizlikci
            // 
            this.rdbTemizlikci.AutoSize = true;
            this.rdbTemizlikci.Location = new System.Drawing.Point(125, 27);
            this.rdbTemizlikci.Name = "rdbTemizlikci";
            this.rdbTemizlikci.Size = new System.Drawing.Size(71, 17);
            this.rdbTemizlikci.TabIndex = 29;
            this.rdbTemizlikci.TabStop = true;
            this.rdbTemizlikci.Text = "Temizlikci";
            this.rdbTemizlikci.UseVisualStyleBackColor = true;
            this.rdbTemizlikci.CheckedChanged += new System.EventHandler(this.rdbTemizlikci_CheckedChanged);
            // 
            // rdbSekreter
            // 
            this.rdbSekreter.AutoSize = true;
            this.rdbSekreter.Location = new System.Drawing.Point(75, 57);
            this.rdbSekreter.Name = "rdbSekreter";
            this.rdbSekreter.Size = new System.Drawing.Size(65, 17);
            this.rdbSekreter.TabIndex = 28;
            this.rdbSekreter.TabStop = true;
            this.rdbSekreter.Text = "Sekreter";
            this.rdbSekreter.UseVisualStyleBackColor = true;
            this.rdbSekreter.CheckedChanged += new System.EventHandler(this.rdbSekreter_CheckedChanged);
            // 
            // rdbEbe
            // 
            this.rdbEbe.AutoSize = true;
            this.rdbEbe.Location = new System.Drawing.Point(75, 27);
            this.rdbEbe.Name = "rdbEbe";
            this.rdbEbe.Size = new System.Drawing.Size(44, 17);
            this.rdbEbe.TabIndex = 27;
            this.rdbEbe.TabStop = true;
            this.rdbEbe.Text = "Ebe";
            this.rdbEbe.UseVisualStyleBackColor = true;
            this.rdbEbe.CheckedChanged += new System.EventHandler(this.rdbEbe_CheckedChanged);
            // 
            // rdbHemsire
            // 
            this.rdbHemsire.AutoSize = true;
            this.rdbHemsire.Location = new System.Drawing.Point(6, 27);
            this.rdbHemsire.Name = "rdbHemsire";
            this.rdbHemsire.Size = new System.Drawing.Size(63, 17);
            this.rdbHemsire.TabIndex = 26;
            this.rdbHemsire.TabStop = true;
            this.rdbHemsire.Text = "Hemsire";
            this.rdbHemsire.UseVisualStyleBackColor = true;
            this.rdbHemsire.CheckedChanged += new System.EventHandler(this.rdbHemsire_CheckedChanged);
            // 
            // rdbDoktor
            // 
            this.rdbDoktor.AutoSize = true;
            this.rdbDoktor.Location = new System.Drawing.Point(6, 57);
            this.rdbDoktor.Name = "rdbDoktor";
            this.rdbDoktor.Size = new System.Drawing.Size(57, 17);
            this.rdbDoktor.TabIndex = 25;
            this.rdbDoktor.TabStop = true;
            this.rdbDoktor.Text = "Doktor";
            this.rdbDoktor.UseVisualStyleBackColor = true;
            this.rdbDoktor.CheckedChanged += new System.EventHandler(this.rdbDoktor_CheckedChanged);
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(68, 103);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(197, 20);
            this.txtYas.TabIndex = 35;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(68, 77);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(197, 20);
            this.txtTcNo.TabIndex = 34;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(68, 51);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(197, 20);
            this.txtSoyad.TabIndex = 33;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 20);
            this.txtAd.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yaş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "TcNo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad : ";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(68, 135);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(197, 21);
            this.cmbCinsiyet.TabIndex = 41;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(68, 162);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(197, 20);
            this.txtMaas.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Maaş :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cinsiyet :";
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(302, 120);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(169, 55);
            this.btnPersonel.TabIndex = 42;
            this.btnPersonel.Text = "Personel Ekle";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // cmbAlan
            // 
            this.cmbAlan.FormattingEnabled = true;
            this.cmbAlan.Location = new System.Drawing.Point(68, 188);
            this.cmbAlan.Name = "cmbAlan";
            this.cmbAlan.Size = new System.Drawing.Size(197, 21);
            this.cmbAlan.TabIndex = 44;
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(13, 189);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(34, 13);
            this.lblAlan.TabIndex = 43;
            this.lblAlan.Text = "Alan :";
            // 
            // cmbBina
            // 
            this.cmbBina.FormattingEnabled = true;
            this.cmbBina.Location = new System.Drawing.Point(68, 215);
            this.cmbBina.Name = "cmbBina";
            this.cmbBina.Size = new System.Drawing.Size(197, 21);
            this.cmbBina.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Bina  :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(302, 181);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(169, 55);
            this.btnTemizle.TabIndex = 47;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 254);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cmbBina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlan);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.RadioButton rdbHemsire;
        private System.Windows.Forms.RadioButton rdbDoktor;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTemizlikci;
        private System.Windows.Forms.RadioButton rdbSekreter;
        private System.Windows.Forms.RadioButton rdbEbe;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.ComboBox cmbAlan;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.ComboBox cmbBina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTemizle;
    }
}