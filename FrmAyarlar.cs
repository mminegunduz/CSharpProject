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

namespace Ticari_Otomasyon
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_admın", bgl.cnn());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            TxtKullanici.Text = "";
            TxtSifre.Text = "";

        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            if (BtnIslem.Text == "KAYDET")
            {

                SqlCommand komut = new SqlCommand("insert into tbl_admın values (@p1,@p2)", bgl.cnn());
                komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            if(BtnIslem.Text== "GÜNCELLE")
            {
                SqlCommand komut = new SqlCommand("update tbl_admın set sifre=@p2 where kullaniciad=@p1", bgl.cnn());
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Kayıt Güncellendi", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr!= null)
            {
                TxtKullanici.Text = dr["KullaniciAd"].ToString();
                TxtSifre.Text = dr["Sifre"].ToString();
            }
        }

        private void TxtKullanici_TextChanged(object sender, EventArgs e)
        {
            if(TxtKullanici.Text!= "")
            {
                BtnIslem.Text = "GÜNCELLE";
                BtnIslem.BackColor = Color.GreenYellow;
            }
            else
            {
                BtnIslem.Text = "KAYDET";
                BtnIslem.BackColor = Color.IndianRed;
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }
    }
}
