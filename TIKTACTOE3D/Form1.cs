using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIKTACTOE3D
{
    public partial class Form1 : Form
    {
        char p1, p2, p3, p4, p5, p6, p7, p8, p9;
        char kto;
        public Form1()
        {
            InitializeComponent();
            pola();
        }

        public void pola()
        {
            kto = 'o';
            kolejka.Text = kto.ToString();
            kolejka.BackColor = Color.White;
            pole1.Text = ""; pole1.Enabled = true; pole1.BackColor = Color.White;
            pole2.Text = ""; pole2.Enabled = true; pole2.BackColor = Color.White;
            pole3.Text = ""; pole3.Enabled = true; pole3.BackColor = Color.White;
            pole4.Text = ""; pole4.Enabled = true; pole4.BackColor = Color.White;
            pole5.Text = ""; pole5.Enabled = true; pole5.BackColor = Color.White;
            pole6.Text = ""; pole6.Enabled = true; pole6.BackColor = Color.White;
            pole7.Text = ""; pole7.Enabled = true; pole7.BackColor = Color.White;
            pole8.Text = ""; pole8.Enabled = true; pole8.BackColor = Color.White;
            pole9.Text = ""; pole9.Enabled = true; pole9.BackColor = Color.White;

        }

        public void sprawdz()
        {
            if ((pole1.Text == pole2.Text && pole2.Text == pole3.Text && pole1.Text != "") ||
               (pole4.Text == pole5.Text && pole5.Text == pole6.Text && pole4.Text != "") ||
               (pole7.Text == pole8.Text && pole8.Text == pole9.Text && pole7.Text != "") ||
               (pole1.Text == pole4.Text && pole4.Text == pole7.Text && pole1.Text != "") ||
               (pole2.Text == pole5.Text && pole5.Text == pole8.Text && pole2.Text != "") ||
               (pole3.Text == pole6.Text && pole6.Text == pole9.Text && pole3.Text != "") ||
               (pole1.Text == pole5.Text && pole5.Text == pole9.Text && pole1.Text != "") ||
               (pole3.Text == pole5.Text && pole5.Text == pole7.Text && pole3.Text != "")){
                if (kto == 'o')
                {
                    MessageBox.Show("Wygral zawodnik x");
                    pola();
                }
                else
                {
                    MessageBox.Show("Wygral zawodnik o");
                    pola();
                }
            }
        }

        private void pole1_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole1.Text = "O";
                kto = 'x';
            }
            else
            {
                pole1.Text = "X";
                kto = 'o';
            }
            pole1.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole1.Enabled = false;
            sprawdz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kto = 'o';
            kolejka.Text = kto.ToString();
            kolejka.BackColor = Color.White;
            pole1.Text = ""; pole1.Enabled = true; pole1.BackColor = Color.White;
            pole2.Text = ""; pole2.Enabled = true; pole2.BackColor = Color.White;
            pole3.Text = ""; pole3.Enabled = true; pole3.BackColor = Color.White;
            pole4.Text = ""; pole4.Enabled = true; pole4.BackColor = Color.White;
            pole5.Text = ""; pole5.Enabled = true; pole5.BackColor = Color.White;
            pole6.Text = ""; pole6.Enabled = true; pole6.BackColor = Color.White;
            pole7.Text = ""; pole7.Enabled = true; pole7.BackColor = Color.White;
            pole8.Text = ""; pole8.Enabled = true; pole8.BackColor = Color.White;
            pole9.Text = ""; pole9.Enabled = true; pole9.BackColor = Color.White;
        }

        private void pole2_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole2.Text = "O";
                kto = 'x';
            }
            else
            {
                pole2.Text = "X";
                kto = 'o';
            }
            pole2.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole2.Enabled = false;
            sprawdz();
        }
        private void pole3_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole3.Text = "O";
                kto = 'x';
            }
            else
            {
                pole3.Text = "X";
                kto = 'o';
            }
            pole3.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole3.Enabled = false;
            sprawdz();
        }

        private void pole4_Click_1(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole4.Text = "O";
                kto = 'x';
            }
            else
            {
                pole4.Text = "X";
                kto = 'o';
            }
            pole4.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole4.Enabled = false;
            sprawdz();
        }
        private void pole5_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole5.Text = "O";
                kto = 'x';
            }
            else
            {
                pole5.Text = "X";
                kto = 'o';
            }
            pole5.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole5.Enabled = false;
            sprawdz();
        }
        private void pole6_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole6.Text = "O";
                kto = 'x';
            }
            else
            {
                pole6.Text = "X";
                kto = 'o';
            }
            pole6.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole6.Enabled = false;
            sprawdz();
        }

        private void pole7_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole7.Text = "O";
                kto = 'x';
            }
            else
            {
                pole7.Text = "X";
                kto = 'o';
            }
            pole7.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole7.Enabled = false;
            sprawdz();
        }

        private void pole8_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole8.Text = "O";
                kto = 'x';
            }
            else
            {
                pole8.Text = "X";
                kto = 'o';
            }
            pole8.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole8.Enabled = false;
            sprawdz();
        }

        private void pole9_Click(object sender, EventArgs e)
        {
            if (kto == 'o')
            {
                pole9.Text = "O";
                kto = 'x';
            }
            else
            {
                pole9.Text = "X";
                kto = 'o';
            }
            pole9.BackColor = Color.White;
            kolejka.Text = kto.ToString();
            pole9.Enabled = false;
            sprawdz();
        }
    }
}
