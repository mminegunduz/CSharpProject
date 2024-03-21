using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\DELL\\Downloads\\dbSozluk.accdb");
        Random rn = new Random();
        int sure = 90;
        int kelime = 0;
        public string yarismaci;

        void getir()
        {
            int sayi;
            sayi = rn.Next(1, 2490);


            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from sozluk where id=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtIngilizce.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();

            }
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            if(TxtTurkce.Text== LblCevap.Text)
            {
                kelime++;
                LblKelime.Text = kelime.ToString();
                getir();
                TxtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure == 0)
            {
                TxtIngilizce.Enabled = false;
                TxtTurkce.Enabled = false;
                timer1.Stop();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into tblkullanici(KullaniciAd,Skor) values( @p1,@p2)",conn);
                cmd.Parameters.AddWithValue("@p1", yarismaci);
                cmd.Parameters.AddWithValue("@p2", LblKelime.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
