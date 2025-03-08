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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_fırmalar", bgl.cnn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("select fırmakod1 from tbl_kodlar", bgl.cnn());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchKod1.Text = dr[0].ToString();
            }
            bgl.cnn().Close();
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
            TxtId.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtMail.Text = "";
            TxtSektor.Text = "";
            TxtVergi.Text = "";
            TxtYetkili.Text = "";
            TxtYetkili.Text = "";
            MskFax.Text = "";
            MskTel2.Text = "";
            MskedTel1.Text = "";
            MskTel3.Text = "";
            MskYetkiliTc.Text = "";
            TxtAdres.Text = "";
            TxtAd.Focus();

        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            temizle();
            sehirlistesi();
            carikodaciklamalar();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtYetkili.Text = dr["YETKILISTATU"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                MskYetkiliTc.Text = dr["YETKILITC"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                MskedTel1.Text = dr["TELEFON1"].ToString();
                MskTel2.Text = dr["TELEFON2"].ToString();
                MskTel3.Text = dr["TELEFON3"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
                TxtAdres.Text = dr["ADRES"].ToString();
                TxtKod1.Text = dr["OZELKOD1"].ToString();
                TxtKod2.Text = dr["OZELKOD2"].ToString();
                TxtKod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_fırmalar (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", bgl.cnn());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskYetkiliTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p7", MskTel2.Text);
            komut.Parameters.AddWithValue("@p8", MskTel3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MskFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIl.Text);
            komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p14", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Firmayı silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from tbl_fırmalar where ıd=@p1", bgl.cnn());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                firmalistesi();
                MessageBox.Show("Firma listeden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_fırmalar set AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,MAIL=@P9,IL=@P11,ILCE=@P12,FAX=@P10,VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 WHERE ID=@P18", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskYetkiliTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskedTel1.Text);
            komut.Parameters.AddWithValue("@p7", MskTel2.Text);
            komut.Parameters.AddWithValue("@p8", MskTel3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MskFax.Text);
            komut.Parameters.AddWithValue("@p11", CmbIl.Text);
            komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p14", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKod3.Text);
            komut.Parameters.AddWithValue("@p18", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void groupControl6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CmbIl_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
