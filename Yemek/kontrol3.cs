using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek
{
    public partial class kontrol3 : UserControl
    {
        public kontrol3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(textBox1.Text != "" && maskedTextBox1.Text!= "")
            {

                MessageBox.Show("Adresiniz Başarıyla Kaydedildi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Lütfen Adres Giriniz.","DİKKAT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır. Bizi Tercih Ettiğiniz İçin Teşekkürler!");
        }
    }
}
