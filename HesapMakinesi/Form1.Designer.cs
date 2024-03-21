namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(43, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(131, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 80);
            this.button2.TabIndex = 0;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(219, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 80);
            this.button3.TabIndex = 0;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(307, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 80);
            this.button4.TabIndex = 0;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OptIslem);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.Location = new System.Drawing.Point(395, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 80);
            this.button5.TabIndex = 0;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Location = new System.Drawing.Point(43, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 80);
            this.button6.TabIndex = 0;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Location = new System.Drawing.Point(131, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 80);
            this.button7.TabIndex = 0;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Location = new System.Drawing.Point(219, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 80);
            this.button8.TabIndex = 0;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Green;
            this.button9.Location = new System.Drawing.Point(307, 192);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 80);
            this.button9.TabIndex = 0;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.OptIslem);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Location = new System.Drawing.Point(395, 192);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 80);
            this.button10.TabIndex = 0;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Location = new System.Drawing.Point(43, 278);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 80);
            this.button11.TabIndex = 0;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.Location = new System.Drawing.Point(131, 278);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 80);
            this.button12.TabIndex = 0;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.Location = new System.Drawing.Point(219, 278);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 80);
            this.button13.TabIndex = 0;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Green;
            this.button14.Location = new System.Drawing.Point(307, 278);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 80);
            this.button14.TabIndex = 0;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.OptIslem);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Green;
            this.button15.Location = new System.Drawing.Point(395, 278);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 166);
            this.button15.TabIndex = 1;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.Location = new System.Drawing.Point(43, 364);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(170, 80);
            this.button16.TabIndex = 2;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightPink;
            this.button17.Location = new System.Drawing.Point(219, 364);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 80);
            this.button17.TabIndex = 0;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Green;
            this.button18.Location = new System.Drawing.Point(307, 364);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 80);
            this.button18.TabIndex = 0;
            this.button18.Text = "*";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.OptIslem);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(39, 36);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 22);
            this.lblsonuc.TabIndex = 3;
            // 
            // txtsonuc
            // 
            this.txtsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsonuc.Location = new System.Drawing.Point(43, 61);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(434, 34);
            this.txtsonuc.TabIndex = 4;
            this.txtsonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(519, 507);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.Click += new System.EventHandler(this.OptIslem);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.TextBox txtsonuc;
    }
}

