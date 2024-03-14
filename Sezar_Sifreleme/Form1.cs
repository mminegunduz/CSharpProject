using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // merhaba m e r h a b a 
            string veri = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            foreach(char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman + 3).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = textBox2.Text;
            char[] karakterler = sifre.ToCharArray();
            foreach(char eleman in karakterler)
            {
                textBox1.Text += Convert.ToChar(eleman - 3).ToString();
            }
        }
    }
}
