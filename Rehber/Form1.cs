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
namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from KISILER", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            TxtId.Text = "";
            MskedTel.Text = "";
            TxtResim.Text = "";
            TxtAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Source=DESKTOP-E9P1RVT\MINE;Initial Catalog=Rehber;Integrated Security=True
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into KISILER (AD,SOYAD,TELEFON,MAIL,RESIM) values(@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskedTel.Text);
            cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p5", TxtResim.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kişi başarıyla sisteme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskedTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult secsil = new DialogResult();
            secsil = MessageBox.Show("Bu kişi rehberinizden silinecektir. Onaylıyor musunuz?", "SİL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (secsil == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from KISILER where ID=" + TxtId.Text, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                listele();
                temizle();

            }
            else
            {
                MessageBox.Show("Kişi rehberden silinemedi.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update KISILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4,RESIM=@p5 where ID=@p6", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskedTel.Text);
            cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p5", TxtResim.Text);
            cmd.Parameters.AddWithValue("@p6", TxtId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kişi bilgisi başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }
    }
}
