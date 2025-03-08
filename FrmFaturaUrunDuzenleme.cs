using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string urunid;
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunID.Text = urunid;

            SqlCommand komut = new SqlCommand("select * from tbl_faturadetay where faturaurunıd=@p1", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtFiyat.Text = dr[3].ToString();
                TxtMiktar.Text = dr[2].ToString();
                TxtTutar.Text = dr[4].ToString();
                TxtUrunAd.Text = dr[1].ToString();
                bgl.cnn().Close();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturadetay set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 WHERE FATURAURUNID=@P5", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p5", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Değişikler Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturadetay where faturaurunıd=@p1", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
