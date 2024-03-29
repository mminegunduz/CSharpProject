namespace PastahaneMaliyet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmalzemegetir = new System.Windows.Forms.Button();
            this.btnmalzemeekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmalzemenotlar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmalzemefiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmalzemestok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmalzemead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmalzemeid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txturunstok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txturunıd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbmalzeme = new System.Windows.Forms.ComboBox();
            this.cmburun = new System.Windows.Forms.ComboBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtueunmaaliyet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txturunmiktar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnkasa = new System.Windows.Forms.Button();
            this.btnmalzemelist = new System.Windows.Forms.Button();
            this.btnurunlist = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmalzemegetir);
            this.groupBox1.Controls.Add(this.btnmalzemeekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmalzemenotlar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmalzemefiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmalzemestok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmalzemead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmalzemeid);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // btnmalzemegetir
            // 
            this.btnmalzemegetir.Location = new System.Drawing.Point(329, 87);
            this.btnmalzemegetir.Name = "btnmalzemegetir";
            this.btnmalzemegetir.Size = new System.Drawing.Size(92, 38);
            this.btnmalzemegetir.TabIndex = 11;
            this.btnmalzemegetir.Text = "Getir";
            this.btnmalzemegetir.UseVisualStyleBackColor = true;
            // 
            // btnmalzemeekle
            // 
            this.btnmalzemeekle.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmalzemeekle.Location = new System.Drawing.Point(120, 235);
            this.btnmalzemeekle.Name = "btnmalzemeekle";
            this.btnmalzemeekle.Size = new System.Drawing.Size(207, 43);
            this.btnmalzemeekle.TabIndex = 10;
            this.btnmalzemeekle.Text = "MALZEME EKLE";
            this.btnmalzemeekle.UseVisualStyleBackColor = true;
            this.btnmalzemeekle.Click += new System.EventHandler(this.btnmalzemeekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "NOTLAR:";
            // 
            // txtmalzemenotlar
            // 
            this.txtmalzemenotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemenotlar.Location = new System.Drawing.Point(120, 198);
            this.txtmalzemenotlar.Name = "txtmalzemenotlar";
            this.txtmalzemenotlar.Size = new System.Drawing.Size(203, 30);
            this.txtmalzemenotlar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "FİYAT:";
            // 
            // txtmalzemefiyat
            // 
            this.txtmalzemefiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemefiyat.Location = new System.Drawing.Point(120, 162);
            this.txtmalzemefiyat.Name = "txtmalzemefiyat";
            this.txtmalzemefiyat.Size = new System.Drawing.Size(203, 30);
            this.txtmalzemefiyat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOK:";
            // 
            // txtmalzemestok
            // 
            this.txtmalzemestok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemestok.Location = new System.Drawing.Point(120, 126);
            this.txtmalzemestok.Name = "txtmalzemestok";
            this.txtmalzemestok.Size = new System.Drawing.Size(203, 30);
            this.txtmalzemestok.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "AD:";
            // 
            // txtmalzemead
            // 
            this.txtmalzemead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemead.Location = new System.Drawing.Point(120, 90);
            this.txtmalzemead.Name = "txtmalzemead";
            this.txtmalzemead.Size = new System.Drawing.Size(203, 30);
            this.txtmalzemead.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtmalzemeid
            // 
            this.txtmalzemeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemeid.Location = new System.Drawing.Point(120, 54);
            this.txtmalzemeid.Name = "txtmalzemeid";
            this.txtmalzemeid.Size = new System.Drawing.Size(203, 30);
            this.txtmalzemeid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(7, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1134, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnguncelle);
            this.groupBox3.Controls.Add(this.btnurunekle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtsfiyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtmfiyat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txturunstok);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txturunad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txturunıd);
            this.groupBox3.Location = new System.Drawing.Point(441, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girişi";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(22, 240);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(92, 38);
            this.btnguncelle.TabIndex = 11;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunekle.Location = new System.Drawing.Point(120, 235);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(207, 43);
            this.btnurunekle.TabIndex = 10;
            this.btnurunekle.Text = "ÜRÜN EKLE";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "S.FİYAT:";
            // 
            // txtsfiyat
            // 
            this.txtsfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsfiyat.Location = new System.Drawing.Point(120, 198);
            this.txtsfiyat.Name = "txtsfiyat";
            this.txtsfiyat.Size = new System.Drawing.Size(203, 30);
            this.txtsfiyat.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "M.FİYAT:";
            // 
            // txtmfiyat
            // 
            this.txtmfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmfiyat.Location = new System.Drawing.Point(120, 162);
            this.txtmfiyat.Name = "txtmfiyat";
            this.txtmfiyat.Size = new System.Drawing.Size(203, 30);
            this.txtmfiyat.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "STOK:";
            // 
            // txturunstok
            // 
            this.txturunstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunstok.Location = new System.Drawing.Point(120, 126);
            this.txturunstok.Name = "txturunstok";
            this.txturunstok.Size = new System.Drawing.Size(203, 30);
            this.txturunstok.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(65, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "AD:";
            // 
            // txturunad
            // 
            this.txturunad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunad.Location = new System.Drawing.Point(120, 90);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(203, 30);
            this.txturunad.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(74, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID:";
            // 
            // txturunıd
            // 
            this.txturunıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunıd.Location = new System.Drawing.Point(120, 54);
            this.txturunıd.Name = "txturunıd";
            this.txturunıd.Size = new System.Drawing.Size(203, 30);
            this.txturunıd.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbmalzeme);
            this.groupBox4.Controls.Add(this.cmburun);
            this.groupBox4.Controls.Add(this.btnolustur);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtueunmaaliyet);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txturunmiktar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(783, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 298);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Oluştur";
            // 
            // cmbmalzeme
            // 
            this.cmbmalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbmalzeme.FormattingEnabled = true;
            this.cmbmalzeme.Location = new System.Drawing.Point(140, 87);
            this.cmbmalzeme.Name = "cmbmalzeme";
            this.cmbmalzeme.Size = new System.Drawing.Size(203, 33);
            this.cmbmalzeme.TabIndex = 12;
            // 
            // cmburun
            // 
            this.cmburun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburun.FormattingEnabled = true;
            this.cmburun.Location = new System.Drawing.Point(140, 49);
            this.cmburun.Name = "cmburun";
            this.cmburun.Size = new System.Drawing.Size(203, 33);
            this.cmburun.TabIndex = 11;
            // 
            // btnolustur
            // 
            this.btnolustur.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnolustur.Location = new System.Drawing.Point(140, 203);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(203, 43);
            this.btnolustur.TabIndex = 10;
            this.btnolustur.Text = "EKLE";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(18, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "MALİYET:";
            // 
            // txtueunmaaliyet
            // 
            this.txtueunmaaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtueunmaaliyet.Location = new System.Drawing.Point(140, 162);
            this.txtueunmaaliyet.Name = "txtueunmaaliyet";
            this.txtueunmaaliyet.Size = new System.Drawing.Size(203, 30);
            this.txtueunmaaliyet.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(29, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "MİKTAR:";
            // 
            // txturunmiktar
            // 
            this.txturunmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunmiktar.Location = new System.Drawing.Point(140, 126);
            this.txturunmiktar.Name = "txturunmiktar";
            this.txturunmiktar.Size = new System.Drawing.Size(203, 30);
            this.txturunmiktar.TabIndex = 4;
            this.txturunmiktar.TextChanged += new System.EventHandler(this.txturunmiktar_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(7, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(52, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btncikis);
            this.groupBox5.Controls.Add(this.btnkasa);
            this.groupBox5.Controls.Add(this.btnmalzemelist);
            this.groupBox5.Controls.Add(this.btnurunlist);
            this.groupBox5.Location = new System.Drawing.Point(1150, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 221);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.Location = new System.Drawing.Point(6, 174);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(332, 44);
            this.btncikis.TabIndex = 13;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnkasa
            // 
            this.btnkasa.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkasa.Location = new System.Drawing.Point(6, 125);
            this.btnkasa.Name = "btnkasa";
            this.btnkasa.Size = new System.Drawing.Size(332, 43);
            this.btnkasa.TabIndex = 12;
            this.btnkasa.Text = "KASA";
            this.btnkasa.UseVisualStyleBackColor = true;
            this.btnkasa.Click += new System.EventHandler(this.btnkasa_Click);
            // 
            // btnmalzemelist
            // 
            this.btnmalzemelist.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmalzemelist.Location = new System.Drawing.Point(6, 76);
            this.btnmalzemelist.Name = "btnmalzemelist";
            this.btnmalzemelist.Size = new System.Drawing.Size(332, 43);
            this.btnmalzemelist.TabIndex = 11;
            this.btnmalzemelist.Text = "MALZEME LİSTESİ";
            this.btnmalzemelist.UseVisualStyleBackColor = true;
            this.btnmalzemelist.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnurunlist
            // 
            this.btnurunlist.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunlist.Location = new System.Drawing.Point(6, 27);
            this.btnurunlist.Name = "btnurunlist";
            this.btnurunlist.Size = new System.Drawing.Size(332, 43);
            this.btnurunlist.TabIndex = 10;
            this.btnurunlist.Text = "ÜRÜN LİSTESİ";
            this.btnurunlist.UseVisualStyleBackColor = true;
            this.btnurunlist.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(1147, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 298);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün Oluştur";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 271);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1504, 545);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmalzemead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmalzemeid;
        private System.Windows.Forms.Button btnmalzemegetir;
        private System.Windows.Forms.Button btnmalzemeekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmalzemenotlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmalzemefiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmalzemestok;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txturunstok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunıd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtueunmaaliyet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txturunmiktar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnkasa;
        private System.Windows.Forms.Button btnmalzemelist;
        private System.Windows.Forms.Button btnurunlist;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbmalzeme;
        private System.Windows.Forms.ComboBox cmburun;
    }
}

