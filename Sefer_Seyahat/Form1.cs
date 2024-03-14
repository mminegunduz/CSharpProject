using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Sefer_Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=TestYolcuBilet;Integrated Security=True");
        void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblseferbılgı", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblyolcubılgı(ad,soyad,telefon,tc,cınsıyet,maıl) values(@p1,@p2,@p3,@p4,@p5,@p6)", cnn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskedTel.Text);
            cmd.Parameters.AddWithValue("@p4", MskedTc.Text);
            cmd.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p6", Txtmail.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskedTel.Text = "";
            MskedTc.Text = "";
            CmbCinsiyet.Text = "";
            Txtmail.Text = "";
            TxtAd.Focus();

        }

        private void BtnKaptan_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblkaptan(kaptanno,adsoyad,telefon) values (@p1,@p2,@p3)", cnn);
            cmd.Parameters.AddWithValue("@p1", TxtKaptanNo.Text);
            cmd.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", TxtKaptanTelNo.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtKaptanNo.Text = "";
            TxtAdSoyad.Text = "";
            TxtKaptanTelNo.Text = "";
            TxtKaptanNo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblseferbılgı(kalkıs,varıs,tarıh,saat,kaptan,fıyat) values(@p1,@p2,@p3,@p4,@p5,@p6)", cnn);
            cmd.Parameters.AddWithValue("@p1", TxtKalkis.Text);
            cmd.Parameters.AddWithValue("@p2", TxtVaris.Text);
            cmd.Parameters.AddWithValue("@p3", MskdTarih.Text);
            cmd.Parameters.AddWithValue("@p4", MskdSaat.Text);
            cmd.Parameters.AddWithValue("@p5", MskdKaptan.Text);
            cmd.Parameters.AddWithValue("@p6", TxtFiyat.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtKalkis.Text = "";
            TxtVaris.Text = "";
            MskdTarih.Text = "";
            MskdSaat.Text = "";
            MskdKaptan.Text = "";
            TxtFiyat.Text = "";
            TxtKalkis.Focus();
            seferlistesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtSeferNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "9";
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblseferdetay(seferno,yolcutc,koltuk) values (@p1,@p2,@p3)", cnn);
            cmd.Parameters.AddWithValue("@p1", TxtSeferNumara.Text);
            cmd.Parameters.AddWithValue("@p2", MskedTCno.Text);
            cmd.Parameters.AddWithValue("@p3", txtkoltukno.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Rezervasyon İşleminiz Başarıyla Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtSeferNumara.Text = "";
            MskedTCno.Text = "";
            txtkoltukno.Text = "";
            TxtSeferNumara.Focus();
        }
    }
}
