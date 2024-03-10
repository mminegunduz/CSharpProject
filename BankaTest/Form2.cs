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
namespace BankaTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DbBankaTest;Integrated Security=True;");

        public string hesap;

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesap;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from TBLKISILER where hesapno=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LBLAD.Text = dr[1] + "" + dr[2];
                LblTC.Text = dr[3].ToString();
                LblTel.Text = dr[4].ToString();

            }
            cnn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışo
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Update TBLHESAP set bakıye=bakıye+@p1 where hesapno=@p2", cnn);
            cmd.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));
            cmd.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();


            //Gönderen hesabın para azalışı
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("Update TBLHESAP set bakıye=bakıye-@k1 where hesapno=@k2", cnn);
            cmd2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
            cmd2.Parameters.AddWithValue("@k2", hesap);
            cmd2.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("İşlem Gerçekleştirildi.");

            //hareket tablosu

            cnn.Open();
            SqlCommand cmd3 = new SqlCommand("insert into tblhareket(gonderen,alıcı,tutar) values (@m1,@m2,@m3)", cnn);
            cmd3.Parameters.AddWithValue("@m1", hesap);
            cmd3.Parameters.AddWithValue("@m2", maskedTextBox1.Text);
            cmd3.Parameters.AddWithValue("@m3", decimal.Parse(TxtTutar.Text));
            cmd3.ExecuteNonQuery();
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.hesapno = hesap;
            frm.hesapno2 = maskedTextBox1.Text;
            frm.Show();
        }
    }
}
