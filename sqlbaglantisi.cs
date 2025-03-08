using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection cnn()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E9P1RVT\\MINE;Initial Catalog=DboTicariOtomasyon;Integrated Security=True;");
            baglanti.Open();
            return baglanti;
        }
    }
}
