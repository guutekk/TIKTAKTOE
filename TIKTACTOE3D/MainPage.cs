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
    public partial class MainPage : Form
    {
        bool status=true;
        public MainPage(bool _status)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.music);

            //player.SoundLocation = Properties.Resources.music;
            player.PlayLooping();
            status = _status;
            InitializeComponent();
            this.ControlBox = false;
            if (status == false)
            {
                Application.Exit();
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            TikTakToe3D t = new TikTakToe3D();
            t.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ustawienia u = new Ustawienia();
            u.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
