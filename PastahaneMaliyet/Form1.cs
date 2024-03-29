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
using System.Runtime.InteropServices;

namespace PastahaneMaliyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DbPastahane;Integrated Security=True");

        void MalzemeListe() {

            SqlDataAdapter da = new SqlDataAdapter("select * from tblmalzemeler ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;        
        }

        void urunlistesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tblurunler ", cnn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from tblkasa", cnn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void urunler()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblurunler", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmburun.ValueMember = "URUNID";
            cmburun.DisplayMember = "AD";
            cmburun.DataSource = dt;
            cnn.Close();
        }

        void malzemeler()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblmalzemeler", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.ValueMember = "MALZEMEID";
            cmbmalzeme.DisplayMember = "AD";
            cmbmalzeme.DataSource = dt;
            cnn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();
            urunler();
            malzemeler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunlistesi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblmalzemeler(ad,stok,fıyat,notlar) values (@p1,@p2,@p3,@p4)", cnn);
            cmd.Parameters.Add("@p1", txtmalzemead.Text);
            cmd.Parameters.Add("@p2", decimal.Parse(txtmalzemestok.Text));
            cmd.Parameters.Add("@p3", decimal.Parse(txtmalzemefiyat.Text));
            cmd.Parameters.Add("@p4", txtmalzemenotlar.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
            txtmalzemead.Text = "";
            txtmalzemefiyat.Text = "";
            txtmalzemestok.Text = "";
            txtmalzemenotlar.Text = "";
            txtmalzemead.Focus();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblurunler (ad) values (@p1)", cnn);
            cmd.Parameters.AddWithValue("@p1", txturunad.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Ürün sisteme eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txturunad.Text = "";
            txturunad.Focus();
            urunlistesi();

            listBox1.Items.Add(cmbmalzeme.Text + "-" + txtueunmaaliyet.Text);
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblfırın (urunıd,malzemead,mıktar,malıyet) values (@p1,@p2,@p3,@p4)", cnn);
            cmd.Parameters.AddWithValue("@p1", cmburun.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", cmbmalzeme.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txturunmiktar.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtueunmaaliyet.Text));
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Malzeme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txturunmiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
           
            if (txturunmiktar.Text == "")
            {

                txturunmiktar.Text = "0";
            }

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblmalzemeler where Malzemeıd=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", cmbmalzeme.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtueunmaaliyet.Text = dr[3].ToString();
            }
            cnn.Close();
            if (cmbmalzeme.Text == "YUMURTA")
            {
                maliyet = Convert.ToDouble(txtueunmaaliyet.Text) * Convert.ToDouble(txturunmiktar.Text);
                txtueunmaaliyet.Text = maliyet.ToString();
            }
            else
            {
                maliyet = Convert.ToDouble(txtueunmaaliyet.Text) / 1000 * Convert.ToDouble(txturunmiktar.Text);
                txtueunmaaliyet.Text = maliyet.ToString();
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txturunıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select sum(Malıyet) from tblfırın where urunıd=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", txturunıd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtueunmaaliyet.Text = dr[0].ToString();
            }
            cnn.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("update tblurunler set mfıyat=@p1,sfıyat=@p2,stok=@p3 where URUNID=@p4", cnn);
            cmd.Parameters.AddWithValue("@p1", decimal.Parse(txtmfiyat.Text));
            cmd.Parameters.AddWithValue("@p2", decimal.Parse(txtsfiyat.Text));
            cmd.Parameters.AddWithValue("@p3", txturunstok.Text);
            cmd.Parameters.AddWithValue("@p4", txturunıd.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("update tblkasa set gırıs=gırıs+@s1, cıkıs=cıkıs+@s2", cnn);
            cmd2.Parameters.AddWithValue("@s1", decimal.Parse(txtsfiyat.Text));
            cmd2.Parameters.AddWithValue("@s2", decimal.Parse(txtmfiyat.Text));
            cmd2.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Ürün Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlistesi();

        }
    }
}
