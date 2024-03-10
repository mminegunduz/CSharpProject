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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DbBankaTest;Integrated Security=True;");


        private void LnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLKISILER where hesapno=@p1 and sıfre=@p2", cnn);
            cmd.Parameters.AddWithValue("@p1", MskedHesap.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesap = MskedHesap.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hesap Bilgilerinizi Kontrol Ediniz Lütfen.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cnn.Close();
        }
    }
}
