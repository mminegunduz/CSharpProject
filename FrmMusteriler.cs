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
    public partial class MÜŞTERİLER : Form
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_musterıler ", bgl.cnn());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select sehır from tbl_ıller", bgl.cnn());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.cnn().Close();
        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            TxtId.Text = "";
            TxtVergi.Text = "";
            MskTc.Text = "";
            MskedTel1.Text = "";
            MskTel2.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtAdres.Text = "";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            temizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ılce from tbl_ılceler where sehır=@p1", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", CmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.cnn().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_musterıler (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRE,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTel2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", CmbIl.Text);
            komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p10", TxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskedTel1.Text = dr["TELEFON"].ToString();
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
                TxtAdres.Text = dr["ADRES"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Müşteri kaydını silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from tbl_musterıler where ıd=@p1", bgl.cnn());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_musterıler set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,VERGIDAIRE=@P9,ADRES=@P10 WHERE ID=@P11", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTel2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", CmbIl.Text);
            komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p10", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p11", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
