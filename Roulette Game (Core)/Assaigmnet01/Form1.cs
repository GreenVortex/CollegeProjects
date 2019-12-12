using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Assaigmnet01
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundSound.PlayLooping();
            reset();
        }

        //Fullscreen fix
        Point lastPoint;
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //Fullscreen fix end

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Settings
        int GameScore = 0;
        SoundPlayer fail = new SoundPlayer(Properties.Resources.fail);
        SoundPlayer win = new SoundPlayer(Properties.Resources.win);
        SoundPlayer BackgroundSound = new SoundPlayer(Properties.Resources.Background);
        //Settingss

        private void Start_Click(object sender, EventArgs e)
        {
            Score.Visible = true;
            picwin.Visible = false;
            picfail.Visible = false;

            Random random = new Random();
            int num1 = 0, num2 = 0;

            num1 = random.Next(1, 3);
            num2 = random.Next(1, 3);

            pic1.Image = Image.FromFile(@num1 + ".jpg");
            pic2.Image = Image.FromFile(@num2 + ".jpg");
            pic1.Visible = true;
            pic2.Visible = true;

            if (num1 == num2)
            {
                picwin.Visible = true;
                picfail.Visible = false;
                win.Dispose();
                win.Play();
                GameScore += 1;
                Score.Text = "Score: " + GameScore.ToString();
            }
            else
            {
                fail.Dispose();
                fail.Play();
                picwin.Visible = false;
                picfail.Visible = true;
                GameScore = 0;
                Score.Text = "Score: " + GameScore.ToString();
            }
        }

        private void BGMusicTgl_Click(object sender, EventArgs e)
        {
            BackgroundSound.Dispose();
            BackgroundSound.PlayLooping();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            pic1.Visible = false;
            pic2.Visible = false;
            picfail.Visible = false;
            picwin.Visible = false;
            Score.Visible = false;
            GameScore = 0;
        }
    }
}
