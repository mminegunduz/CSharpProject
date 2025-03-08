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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute musterihareketler", bgl.cnn());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void firmahareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("execute firmahareketler", bgl.cnn());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        void giderler()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from tbl_gıderler", bgl.cnn());
            da3.Fill(dt3);
            gridControl2.DataSource = dt3;
        }

        public string ad;

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            LblKullanici.Text = ad;
            musterihareket();
            firmahareket();
            giderler();


            //Toplam Tutarı Hesaplama

            SqlCommand komut1 = new SqlCommand("select sum(tutar) from tbl_faturadetay", bgl.cnn());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKasaToplam.Text = dr1[0].ToString() + "TL";
            }
            bgl.cnn().Close();


            //Son ayın Faturaları

            SqlCommand komut2 = new SqlCommand("select (elektrık+su+dogalgaz+ınternet+ekstra) from TBL_GIDERLER order by ID asc", bgl.cnn());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + "TL";
            }
            bgl.cnn().Close();


            //Son Ayın Personel Maaşları

            SqlCommand komut3 = new SqlCommand("select maaslar from tbl_gıderler order by ID asc", bgl.cnn());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblPersonelMaas.Text = dr3[0].ToString() + "TL";

            }
            bgl.cnn().Close();


            //Toplam Müşteri Sayısı

            SqlCommand komut4 = new SqlCommand("select count(*) from tbl_musterıler", bgl.cnn());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();

            }
            bgl.cnn().Close();


            //Toplam Firma Sayısı

            SqlCommand komut5 = new SqlCommand("select count(*) from tbl_fırmalar", bgl.cnn());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFirmaSayisi.Text = dr5[0].ToString();

            }
            bgl.cnn().Close();



            //Toplam Firma Şehir Sayısı

            SqlCommand komut6 = new SqlCommand("select count(Distinct(IL)) from tbl_fırmalar", bgl.cnn());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblFSehir.Text = dr6[0].ToString();

            }
            bgl.cnn().Close();


            //Toplam Müşteri Şehir Sayısı

            SqlCommand komut7 = new SqlCommand("select count(Distinct(IL)) from tbl_musterıler", bgl.cnn());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblMSehir.Text = dr7[0].ToString(); 

            }
            bgl.cnn().Close();


            //Toplam Personel Sayısı

            SqlCommand komut8 = new SqlCommand("select count(*) from tbl_personeller", bgl.cnn());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LblPersonelSayisi.Text = dr8[0].ToString();

            }
            bgl.cnn().Close();


            //Toplam Stok Sayısı

            SqlCommand komut9 = new SqlCommand("select sum(adet) from tbl_urunler", bgl.cnn());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                LblStok.Text = dr9[0].ToString();

            }
            bgl.cnn().Close();



            


        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            //ELEKTRİK
            if(sayac>0 && sayac <= 5)
            {
                groupControl10.Text = "Elektrik";
                chartControl1.Series["Series 1"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("SELECT TOP 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID desc", bgl.cnn());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));

                }
                bgl.cnn().Close();
            }

            //SU
            if(sayac>5 && sayac <= 10)
            {
                groupControl10.Text = "Su";
                chartControl1.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,su from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //DOĞALGAZ
            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "Doğalgaz";
                chartControl1.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,dogalgaz from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //INTERNET
            if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "İnternet";
                chartControl1.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,ınternet from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //EKSTRA
            if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "Ekstra";
                chartControl1.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,ekstra from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            if (sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            //ELEKTRİK
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "Elektrik";
                chartControl2.Series["Series 1"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("SELECT TOP 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID desc", bgl.cnn());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));

                }
                bgl.cnn().Close();
            }

            //SU
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "Su";
                chartControl2.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,su from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //DOĞALGAZ
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl10.Text = "Doğalgaz";
                chartControl2.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,dogalgaz from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //INTERNET
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "İnternet";
                chartControl2.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,ınternet from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            //EKSTRA
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "Ekstra";
                chartControl2.Series["Series 1"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,ekstra from tbl_gıderler order by ıd desc", bgl.cnn());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.cnn().Close();
            }

            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
