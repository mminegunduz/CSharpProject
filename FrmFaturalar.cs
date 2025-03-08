using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_faturabılgı", bgl.cnn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtAlici.Text = "";
            TxtId.Text = "";
            TxtSeri.Text = "";
            TxtSiraNo.Text = "";
            TxtTeslimAlan.Text = "";
            TxtTeslimEden.Text = "";
            TxtVergiDaire.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";

        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Firma Carisi
            if (TxtFaturaID.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_faturabılgı (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8) ", bgl.cnn());
                komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@p3", MskTarih.Text);
                komut.Parameters.AddWithValue("@p4", MskSaat.Text);
                komut.Parameters.AddWithValue("@p5", TxtVergiDaire.Text);
                komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

               
              
            
            if (TxtFaturaID.Text != "" && comboBox1.Text == "Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = fiyat * miktar;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut1 = new SqlCommand("insert into tbl_faturadetay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@P1,@P2,@P3,@P4,@P5)", bgl.cnn());
                komut1.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut1.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut1.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut1.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut1.Parameters.AddWithValue("@p5", TxtFaturaID.Text);
                komut1.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                //Hareket Tablosuna Veri Giriş

                SqlCommand komut2 = new SqlCommand("insert into tbl_fırmahareketler (urunıd,adet,personel,fırma,fıyat,toplam,faturaıd,tarıh) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7,@m8)", bgl.cnn());
                komut2.Parameters.AddWithValue("@m1", TxtUrunID.Text);
                komut2.Parameters.AddWithValue("@m2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@m3", TxtPersonel.Text);
                komut2.Parameters.AddWithValue("@m4", TxtFirma.Text);
                komut2.Parameters.AddWithValue("@m5", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@m6", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@m7", TxtFaturaID.Text);
                komut2.Parameters.AddWithValue("@m8", MskTarih.Text);
                komut2.ExecuteNonQuery();
                bgl.cnn().Close();


                // Stok Sayısını Azaltma
                SqlCommand komut3 = new SqlCommand("update tbl_urunler set adet=adet-@s1 where ıd=@s2", bgl.cnn());
                komut3.Parameters.AddWithValue("@s1", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@s2", TxtUrunID.Text);
                komut3.ExecuteNonQuery();

                bgl.cnn().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            //Müşteri Carisi

            if (TxtFaturaID.Text != "" && comboBox1.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = fiyat * miktar;
                TxtTutar.Text = tutar.ToString();

                SqlCommand komut1 = new SqlCommand("insert into tbl_faturadetay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@P1,@P2,@P3,@P4,@P5)", bgl.cnn());
                komut1.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut1.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut1.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut1.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut1.Parameters.AddWithValue("@p5", TxtFaturaID.Text);
                komut1.ExecuteNonQuery();
                bgl.cnn().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

                //Hareket Tablosuna Veri Giriş

                SqlCommand komut2 = new SqlCommand("insert into tbl_musterihareketler (urunıd,adet,personel,musterı,fıyat,toplam,faturaıd,tarıh) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7,@m8)", bgl.cnn());
                komut2.Parameters.AddWithValue("@m1", TxtUrunID.Text);
                komut2.Parameters.AddWithValue("@m2", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@m3", TxtPersonel.Text);
                komut2.Parameters.AddWithValue("@m4", TxtFirma.Text);
                komut2.Parameters.AddWithValue("@m5", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@m6", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@m7", TxtFaturaID.Text);
                komut2.Parameters.AddWithValue("@m8", MskTarih.Text);
                komut2.ExecuteNonQuery();
                bgl.cnn().Close();


                // Stok Sayısını Azaltma
                SqlCommand komut3 = new SqlCommand("update tbl_urunler set adet=adet-@s1 where ıd=@s2", bgl.cnn());
                komut3.Parameters.AddWithValue("@s1", TxtMiktar.Text);
                komut3.Parameters.AddWithValue("@s2", TxtUrunID.Text);
                komut3.ExecuteNonQuery();

                bgl.cnn().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["FATURABILGIID"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                TxtSeri.Text = dr["SERI"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
                TxtVergiDaire.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturabılgı where FATURABILGIID=@P1", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Fatura Silindi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturabılgı set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 WHERE FATURABILGIID=@P9", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
            komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtVergiDaire.Text);
            komut.Parameters.AddWithValue("@p6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.cnn().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select urunad,satısfıyat from tbl_urunler where ıd=@p1", bgl.cnn());
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            }
            bgl.cnn().Close();
        }
    }
}