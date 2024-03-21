using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgren
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=FilmArsivi;Integrated Security=True");

        public static Label label4;
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (Txtkullanici.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  
            else
            {
                Form1 fr = new Form1();
                fr.yarismaci = Txtkullanici.Text;
                fr.ShowDialog();
               
            }
            
        }
    }
}
