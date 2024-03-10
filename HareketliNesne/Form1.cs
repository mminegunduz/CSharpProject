using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareketliNesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top<=1)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 750)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 350)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 4;
            if (pictureBox1.Left <=180)
            {
                timer4.Stop();
                timer5.Start();
            }
        }



        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >=630)
            {
                timer6.Stop();
                timer7.Start();

            }
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 65)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 4;
            if(pictureBox1.Top >= 270)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 4;
            if(pictureBox1.Left<= 265){
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 4;
            if (pictureBox1.Top <= 120)
            {
                timer9.Stop();
                timer10.Start();
            }

        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 4;
            if (pictureBox1.Left >= 552)
            {
                timer10.Stop();
                timer11.Start();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 3;
            if (pictureBox1.Top >= 213)
            {
                timer11.Stop();
                timer12.Start();
            }

        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 3;
            if (pictureBox1.Left <= 478)
            {
                timer12.Stop();
                MessageBox.Show("Tebrikler! Labutları düşürdünüz.","TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
