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
using System.Security.Cryptography;
using System.Xml;
using DevExpress.CodeParser;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
      
        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select urunad,sum(adet) as 'adet' from TBL_URUNLER group by urunad having sum(adet)<=5 order by sum(adet)", bgl.cnn());
            da.Fill(dt);
            gridstoklar.DataSource = dt;
            
        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 5 tarıh,saat,baslık from tbl_notlar order by ID desc", bgl.cnn());
            da.Fill(dt);
            gridajanda.DataSource = dt;
        }
        void FirmaHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareket2", bgl.cnn());
            da.Fill(dt);
            gridhareket.DataSource = dt;
        }
        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad,telefon1 from tbl_fırmalar", bgl.cnn());
            da.Fill(dt);
            gridfihrist.DataSource = dt;
        }
        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            FirmaHareketleri();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            haberler();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void gridView3_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }

        private void gridView4_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }
    }

    }
    

