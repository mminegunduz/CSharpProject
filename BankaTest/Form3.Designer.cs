namespace BankaTest
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.MskedTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskedTel = new System.Windows.Forms.MaskedTextBox();
            this.MskedHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.btnRandomHesap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "HESAP NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC KİMLİK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SOYAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ŞİFRE:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(231, 52);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(178, 30);
            this.Txtad.TabIndex = 1;
            // 
            // MskedTC
            // 
            this.MskedTC.Location = new System.Drawing.Point(231, 126);
            this.MskedTC.Mask = "00000000000";
            this.MskedTC.Name = "MskedTC";
            this.MskedTC.Size = new System.Drawing.Size(178, 30);
            this.MskedTC.TabIndex = 3;
            this.MskedTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(231, 90);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(178, 30);
            this.TxtSoyad.TabIndex = 2;
            // 
            // MskedTel
            // 
            this.MskedTel.Location = new System.Drawing.Point(231, 164);
            this.MskedTel.Mask = "(999) 000-0000";
            this.MskedTel.Name = "MskedTel";
            this.MskedTel.Size = new System.Drawing.Size(178, 30);
            this.MskedTel.TabIndex = 4;
            // 
            // MskedHesapNo
            // 
            this.MskedHesapNo.Enabled = false;
            this.MskedHesapNo.Location = new System.Drawing.Point(231, 201);
            this.MskedHesapNo.Mask = "000000";
            this.MskedHesapNo.Name = "MskedHesapNo";
            this.MskedHesapNo.Size = new System.Drawing.Size(178, 30);
            this.MskedHesapNo.TabIndex = 5;
            this.MskedHesapNo.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(231, 237);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(178, 30);
            this.TxtSifre.TabIndex = 6;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnKaydet.Location = new System.Drawing.Point(265, 273);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(109, 34);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnRandomHesap
            // 
            this.btnRandomHesap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRandomHesap.Location = new System.Drawing.Point(436, 200);
            this.btnRandomHesap.Name = "btnRandomHesap";
            this.btnRandomHesap.Size = new System.Drawing.Size(49, 33);
            this.btnRandomHesap.TabIndex = 8;
            this.btnRandomHesap.Text = "...";
            this.btnRandomHesap.UseVisualStyleBackColor = false;
            this.btnRandomHesap.Click += new System.EventHandler(this.btnRandomHesap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(159, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "ÜYE GİRİŞ EKRANI";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(506, 336);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRandomHesap);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskedHesapNo);
            this.Controls.Add(this.MskedTel);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.MskedTC);
            this.Controls.Add(this.Txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.MaskedTextBox MskedTC;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskedTel;
        private System.Windows.Forms.MaskedTextBox MskedHesapNo;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button btnRandomHesap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}