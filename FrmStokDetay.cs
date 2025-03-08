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
    public partial class FrmStokDetay : Form
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }

        public string ad;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_urunler where urunad='" + ad + "'", bgl.cnn());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            e.Appearance.BackColor2 = Color.LightSeaGreen;
            e.Appearance.BackColor = Color.Turquoise;
        }
    }
}
