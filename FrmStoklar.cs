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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Sinop", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("Çorum", 1);

            SqlDataAdapter da = new SqlDataAdapter("select urunad, sum(adet) from tbl_urunler group by URUNAD", bgl.cnn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Charta Stok Miktarı Listeleme

            SqlCommand komut = new SqlCommand("select urunad, sum(adet) from tbl_urunler group by URUNAD ", bgl.cnn());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.cnn().Close();

            //Charta Firma Şehir Sayısı Çekme

            SqlCommand komut2 = new SqlCommand("select ıl,count(*) from TBL_FIRMALAR group by ıl ", bgl.cnn());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.cnn().Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay fr = new FrmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!= null)
            {
                fr.ad = dr["URUNAD"].ToString();
            }
            fr.Show();

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }
    }
}
