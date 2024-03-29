using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               switch( soruno)
                {
                    case 1:
                        if(textBox1.Text== "ankara")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "camii")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "ebru")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hacker")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ışık")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "incir")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kalem")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lüleburgaz")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "münevver")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "nakit")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ocak")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "para")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "raks")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "sinop")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "trabzon")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uyluk")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yay")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zürafa")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break; 
                      

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?"; //ankara
                button1.BackColor = Color.Yellow;
                button25.Text = "A";
                button25.BackColor = Color.Orange;
            }
            if(soruno == 2)
            {
                textBox1.Text = "";
                richTextBox1.Text = "İpek Böceği üretimi Türkiye'nin hangi ilinde meşhurdur?"; //bursa
                button2.BackColor = Color.Yellow;
                button25.Text = "B";
                button25.BackColor = Color.Orange;
            }
            if(soruno == 3)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Müslümanların kutsal saydığı mabet yeri?"; //cami
                button3.BackColor = Color.Yellow;
                button25.Text = "C";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 4)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiye'de karpuzuyla ünlü olan il hangisidir?"; //diyarbakır
                button4.BackColor = Color.Yellow;
                button25.Text = "D";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 5)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Farsça bulut anlamına gelen kelime nedir?"; //ebru
                button5.BackColor = Color.Yellow;
                button25.Text = "E";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 6)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Padişahın emirlerinin yazılı haline ne denir?"; //ferman
                button6.BackColor = Color.Yellow;
                button25.Text = "F";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 7)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Dünyanın ısı kaynağı?"; //güneş
                button7.BackColor = Color.Yellow;
                button25.Text = "G";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 8)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Hesap çalabilen kişilere ne ad verilir?"; //hacker
                button8.BackColor = Color.Yellow;
                button25.Text = "H";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 9)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yapay aydınlatma kaynağı?"; //ışık
                button9.BackColor = Color.Yellow;
                button25.Text = "I";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 10)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Aydın ilinde yetiştirilen meşhur meyve?"; //incir
                button10.BackColor = Color.Yellow;
                button25.Text = "İ";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 11)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Askeri topluluk?"; //jandarma 
                button11.BackColor = Color.Yellow;
                button25.Text = "J";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 12)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yazı yazarken kullandığımız alet?"; //kalem
                button12.BackColor = Color.Yellow;
                button25.Text = "K";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 13)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Kırklareli'nin bir ilçesi?"; //lüleburgaz
                button13.BackColor = Color.Yellow;
                button25.Text = "L";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 14)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Farsçada aydınlanmış,nurlanmış anlamına gelen kelime?"; //münevver
                button14.BackColor = Color.Yellow;
                button25.Text = "M";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 15)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Kullanılması hemen mümkün olan para, peşin para, likit?"; //nakit
                button15.BackColor = Color.Yellow;
                button25.Text = "N";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 16)
            {
                textBox1.Text = "";
                richTextBox1.Text = "İlk ay?"; //ocak
                button16.BackColor = Color.Yellow;
                button25.Text = "O";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 17)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Lidyalıların bulduğu ve günümüzde hala kullanılan eşya?"; //para
                button17.BackColor = Color.Yellow;
                button25.Text = "P";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 18)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Dans etmek anlamına gelen arapça kelime?"; //raks
                button18.BackColor = Color.Yellow;
                button25.Text = "R";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 19)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiye'nin en kuzeyindeki il?"; //sinop
                button19.BackColor = Color.Yellow;
                button25.Text = "S";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 20)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Sümela Manastırı hangi ildedir?"; //trabzon
                button20.BackColor = Color.Yellow;
                button25.Text = "T";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 21)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Kalçadan dize kadar olan bacak bölümü?"; //uyluk
                button21.BackColor = Color.Yellow;
                button25.Text = "U";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 22)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiyenin en büyük gölü hangi ildedir?"; //van
                button22.BackColor = Color.Yellow;
                button25.Text = "V";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 23)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Ok atmaya yarayan, iki ucu arasına kiriş gerilmiş, eğri ağaç veya metal çubuk?"; //yay
                button23.BackColor = Color.Yellow;
                button25.Text = "Y";
                button25.BackColor = Color.Orange;
            }
            if (soruno == 24)
            {
                textBox1.Text = "";
                richTextBox1.Text = "En uzun kara hayvanı hangisidir?"; //zürafa
                button24.BackColor = Color.Yellow;
                button25.Text = "Z";
                button25.BackColor = Color.Orange;
            }
            if(soruno> 24)
            {
                textBox1.Text = "";
                linkLabel1.Text = "SONLANDIR";
                MessageBox.Show("Tebrikler oyun bitti. Doğru Sayısı: " + label3.Text + " " + "Yanlış Sayısı: " + label4.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
