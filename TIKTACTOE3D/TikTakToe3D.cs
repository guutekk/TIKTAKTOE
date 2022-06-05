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
    public partial class TikTakToe3D : Form
    {
        bool status;
        char queue;
        int a;
        int top;
        int left;
        int punkty_x;
        int punkty_y;
        int test = 0;
        int test2 = 0;

        List<PictureBox[]> pbList = new List<PictureBox[]> { };
        PictureBox _clicked;
        public TikTakToe3D()
        {
            InitializeComponent();
            GameStart();
            this.ControlBox = false;

        }

        private void GameStart()
        {
            for (int i = 1; i <= 4; i++)
            {
                pbList.Add(new PictureBox[16]);
            }

            queue = 'o';
            Create_Area(pbList[0], "pole1", 112, 1198);
            Create_Area(pbList[1], "pole2", 306, 1245);
            Create_Area(pbList[2], "pole3", 500, 1292);
            Create_Area(pbList[3], "pole4", 694, 1339);

        }

        private void Create_Area(PictureBox[] pictureBox, string name, int _top, int _left)
        {
            a = 0;
            top = _top;
            left = _left;
            for (int i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Height = 50;
                pictureBox[i].Width = 50;
                pictureBox[i].Name = name + i;
                pictureBox[i].Image = Properties.Resources.pole;
                pictureBox[i].MouseClick += TikTakToe3D_MouseClick1;



                if (a == 4)
                {
                    top = top + 46;
                    left = _left;
                    a = 0;

                }

                if (a < 4)
                {
                    a++;
                    pictureBox[i].Left = left;
                    pictureBox[i].Top = top;
                    Controls.Add(pictureBox[i]);
                    left = left + 47;

                }

            }
        }

        private void TikTakToe3D_MouseClick1(object sender, MouseEventArgs e)
        {
            _clicked = sender as PictureBox;
            if (queue == 'x')
            {
                Clicked_Change(_clicked, queue);
                queue = 'o';
            }
            else if(queue == 'o')
            {
                Clicked_Change(_clicked, queue);
                queue = 'x';
            }
            _clicked.Enabled = false;
        }

        private void Clicked_Change(PictureBox pictureBox, char queue)
        {
            if(queue == 'x')
            {
                pictureBox.Image = Properties.Resources.polex;
                pictureBox.Tag = queue;
                Check_X();
                Check_O();
                Kolejka.Image = Properties.Resources.smallo;
            }
            else if(queue == 'o')
            {
                pictureBox.Image = Properties.Resources.poleo;
                pictureBox.Tag = queue;
                Check_X();
                Check_O();
                Kolejka.Image = Properties.Resources.smallx;
            }
        }
        private void Change_Tag(PictureBox[] pictureBox, int since, int where)
        {
            for (int i = since; i <= where; i++)
            {
                pictureBox[i].Tag = 'k';
            }
        }

        private void Check_picturebox(int since, int where, char tag, PictureBox[] pictureboxes)
        {
            for (int i = since; i < where; i++)
            {
                if(Convert.ToChar(pictureboxes[i].Tag) == 'x')
                {
                }
            }
        }

        private void Check_X()
        {
            var objectList = this.Controls.OfType<Control>().Where(x => x is PictureBox);
            foreach (PictureBox k in objectList)
            {
                if (Convert.ToChar(k.Tag) == 'x')
                {
                    test++;
                    Console.WriteLine(test);
                }
            }

            /*if (Convert.ToChar(array1[0].Tag) == 'x' && Convert.ToChar(array1[1].Tag) == 'x' && Convert.ToChar(array1[2].Tag) == 'x' && Convert.ToChar(array1[3].Tag) == 'x' ||
                Convert.ToChar(array2[0].Tag) == 'x' && Convert.ToChar(array2[1].Tag) == 'x' && Convert.ToChar(array2[2].Tag) == 'x' && Convert.ToChar(array2[3].Tag) == 'x' ||
                Convert.ToChar(array3[0].Tag) == 'x' && Convert.ToChar(array3[1].Tag) == 'x' && Convert.ToChar(array3[2].Tag) == 'x' && Convert.ToChar(array3[3].Tag) == 'x' ||
                Convert.ToChar(array4[0].Tag) == 'x' && Convert.ToChar(array4[1].Tag) == 'x' && Convert.ToChar(array4[2].Tag) == 'x' && Convert.ToChar(array4[3].Tag) == 'x')
            {
                MessageBox.Show("Wygrał zawodnik: x");
                Change_Tag(array1, 0, 3);
            }
            if (Convert.ToChar(array1[4].Tag) == 'x' && Convert.ToChar(array1[5].Tag) == 'x' && Convert.ToChar(array1[6].Tag) == 'x' && Convert.ToChar(array1[7].Tag) == 'x' ||
                Convert.ToChar(array2[4].Tag) == 'x' && Convert.ToChar(array2[5].Tag) == 'x' && Convert.ToChar(array2[6].Tag) == 'x' && Convert.ToChar(array2[7].Tag) == 'x' ||
                Convert.ToChar(array3[4].Tag) == 'x' && Convert.ToChar(array3[5].Tag) == 'x' && Convert.ToChar(array3[6].Tag) == 'x' && Convert.ToChar(array3[7].Tag) == 'x' ||
                Convert.ToChar(array4[4].Tag) == 'x' && Convert.ToChar(array4[5].Tag) == 'x' && Convert.ToChar(array4[6].Tag) == 'x' && Convert.ToChar(array4[7].Tag) == 'x')
            {
                MessageBox.Show("Wygrał zawodnik: x");
                Change_Tag(array1, 4, 7);
            }
            if (Convert.ToChar(array1[8].Tag) == 'x' && Convert.ToChar(array1[9].Tag) == 'x' && Convert.ToChar(array1[10].Tag) == 'x' && Convert.ToChar(array1[11].Tag) == 'x' ||
                Convert.ToChar(array2[8].Tag) == 'x' && Convert.ToChar(array2[9].Tag) == 'x' && Convert.ToChar(array2[10].Tag) == 'x' && Convert.ToChar(array2[11].Tag) == 'x' ||
                Convert.ToChar(array3[8].Tag) == 'x' && Convert.ToChar(array3[9].Tag) == 'x' && Convert.ToChar(array3[10].Tag) == 'x' && Convert.ToChar(array3[11].Tag) == 'x' ||
                Convert.ToChar(array4[8].Tag) == 'x' && Convert.ToChar(array4[9].Tag) == 'x' && Convert.ToChar(array4[10].Tag) == 'x' && Convert.ToChar(array4[11].Tag) == 'x')
            {
                MessageBox.Show("Wygrał zawodnik: x");
                Change_Tag(array1, 8, 11);
            }
            if (Convert.ToChar(array1[12].Tag) == 'x' && Convert.ToChar(array1[13].Tag) == 'x' && Convert.ToChar(array1[14].Tag) == 'x' && Convert.ToChar(array1[15].Tag) == 'x' ||
                Convert.ToChar(array2[12].Tag) == 'x' && Convert.ToChar(array2[13].Tag) == 'x' && Convert.ToChar(array2[14].Tag) == 'x' && Convert.ToChar(array2[15].Tag) == 'x' ||
                Convert.ToChar(array3[12].Tag) == 'x' && Convert.ToChar(array3[13].Tag) == 'x' && Convert.ToChar(array3[14].Tag) == 'x' && Convert.ToChar(array3[15].Tag) == 'x' ||
                Convert.ToChar(array4[12].Tag) == 'x' && Convert.ToChar(array4[13].Tag) == 'x' && Convert.ToChar(array4[14].Tag) == 'x' && Convert.ToChar(array4[15].Tag) == 'x')
            {
                MessageBox.Show("Wygrał zawodnik: x");
                Change_Tag(array1, 12, 15);
            }*/
        }

        private void Check_O()
        {
            /*if (Convert.ToChar(array1[0].Tag) == 'o' && Convert.ToChar(array1[1].Tag) == 'o' && Convert.ToChar(array1[2].Tag) == 'o' && Convert.ToChar(array1[3].Tag) == 'o')
            {
                MessageBox.Show("Wygrał zawodnik: o");
                Change_Tag(array1, 0, 3);
            }
            if (Convert.ToChar(array1[4].Tag) == 'o' && Convert.ToChar(array1[5].Tag) == 'o' && Convert.ToChar(array1[6].Tag) == 'o' && Convert.ToChar(array1[7].Tag) == 'o')
            {
                MessageBox.Show("Wygrał zawodnik: o");
                Change_Tag(array1, 4, 7);
            }
            if (Convert.ToChar(array1[8].Tag) == 'o' && Convert.ToChar(array1[9].Tag) == 'o' && Convert.ToChar(array1[10].Tag) == 'o' && Convert.ToChar(array1[11].Tag) == 'o')
            {
                MessageBox.Show("Wygrał zawodnik: o");
                Change_Tag(array1, 8,11);
            }
            if (Convert.ToChar(array1[12].Tag) == 'o' && Convert.ToChar(array1[13].Tag) == 'o' && Convert.ToChar(array1[14].Tag) == 'o' && Convert.ToChar(array1[15].Tag) == 'o')
            {
                MessageBox.Show("Wygrał zawodnik: o");
                Change_Tag(array1, 12, 15);
            }*/
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
            status = false;
            MainPage p = new MainPage(status);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status = true;
            MainPage p = new MainPage(status);
            p.Show();
            Close();
        }

        private void Reset_Area_Click(object sender, EventArgs e)
        {
            Close();
            TikTakToe3D tik = new TikTakToe3D();
            tik.Show();
            GameStart();
        }
    }
}