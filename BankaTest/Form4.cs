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

namespace BankaTest
{
 
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void gnderilen() {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("execute GONDERILEN @DEGER=@P1", cnn);
            cmd.Parameters.AddWithValue("@p1", hesapno);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }
        void alıcı()

        {
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("execute ALICI @DEGER=@P2", cnn);
            cmd2.Parameters.AddWithValue("@P2", hesapno);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            cnn.Close();
        }
        SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DbBankaTest;Integrated Security=True;");
        public string hesapno;
        public string hesapno2;
        private void Form4_Load(object sender, EventArgs e)
        {
            gnderilen();
            alıcı();
        }
    }
}
