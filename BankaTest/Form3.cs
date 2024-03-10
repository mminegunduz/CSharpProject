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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DbBankaTest;Integrated Security=True;");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (sayi.ToString() == MskedHesapNo.Text)
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLKISILER(Ad,Soyad,TC,Telefon,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", cnn);
                cmd.Parameters.AddWithValue("@p1", Txtad.Text);
                cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", MskedTC.Text);
                cmd.Parameters.AddWithValue("@p4", MskedTel.Text);
                cmd.Parameters.AddWithValue("@p5", MskedHesapNo.Text);
                cmd.Parameters.AddWithValue("@p6", TxtSifre.Text);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("insert into TBLHESAP(HESAPNO,BAKIYE) values (@p1,@p2)", cnn);
                cmd2.Parameters.AddWithValue("@p1", sayi);
                cmd2.Parameters.AddWithValue("@p2", 0.000);
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi.");
                Txtad.Text = "";
                TxtSoyad.Text = "";
                MskedHesapNo.Text = "";
                MskedTC.Text = "";
                MskedTel.Text = "";
                TxtSifre.Text = "";
                Txtad.Focus();
            }
            else
            {
                rastgele();
            }

        }
        int sayi;
        void rastgele()
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(100000, 1000000);
            MskedHesapNo.Text = sayi.ToString();

        }
        private void btnRandomHesap_Click(object sender, EventArgs e)
        {

            rastgele();
               
            
        }
    }
}
