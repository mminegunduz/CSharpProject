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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void personelliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_personeller", bgl.cnn());
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
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtGorev.Text = "";
            TxtMail.Text = "";
            TxtAdres.Text = "";
            MskedTel1.Text = "";
            MskTc.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personelliste();
            sehirlistesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_personeller (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbIl.Text);
            komut.Parameters.AddWithValue("@p7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelliste();


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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskedTel1.Text = dr["TELEFON"].ToString();
                MskTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtAdres.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Personel kaydını silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from tbl_personeller where ıd=@p1", bgl.cnn());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Personel Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personelliste();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_personeller set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE ID=@P10", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbIl.Text);
            komut.Parameters.AddWithValue("@p7", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p10", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelliste();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }
    }
}
