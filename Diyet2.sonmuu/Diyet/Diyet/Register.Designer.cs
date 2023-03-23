namespace Diyet
{
    partial class Register
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Diyet.GradientPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPsswordAgain = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(585, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(585, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "cm";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(211)))), ((int)(((byte)(160)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(211)))), ((int)(((byte)(160)))));
            this.gradientPanel1.Controls.Add(this.btnNext);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.lblName);
            this.gradientPanel1.Controls.Add(this.txtMail);
            this.gradientPanel1.Controls.Add(this.txtPsswordAgain);
            this.gradientPanel1.Controls.Add(this.txtSurname);
            this.gradientPanel1.Controls.Add(this.txtPassword);
            this.gradientPanel1.Controls.Add(this.txtName);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(522, 388);
            this.gradientPanel1.TabIndex = 24;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(195, 309);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(218, 42);
            this.btnNext.TabIndex = 52;
            this.btnNext.Text = "İleri";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "E-Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Şifre:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(88, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 22);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Ad:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(159, 160);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(306, 26);
            this.txtMail.TabIndex = 33;
            // 
            // txtPsswordAgain
            // 
            this.txtPsswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPsswordAgain.Location = new System.Drawing.Point(159, 260);
            this.txtPsswordAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPsswordAgain.Name = "txtPsswordAgain";
            this.txtPsswordAgain.Size = new System.Drawing.Size(306, 26);
            this.txtPsswordAgain.TabIndex = 31;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(159, 109);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(306, 26);
            this.txtSurname.TabIndex = 30;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(159, 210);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 26);
            this.txtPassword.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(159, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 26);
            this.txtName.TabIndex = 29;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(522, 388);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Text = "Kayıt1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPsswordAgain;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
    }
}