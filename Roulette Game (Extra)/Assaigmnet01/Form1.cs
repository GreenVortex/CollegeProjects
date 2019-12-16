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
            Reset();
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
        readonly SoundPlayer fail = new SoundPlayer(Properties.Resources.fail);
        readonly SoundPlayer win = new SoundPlayer(Properties.Resources.win);
        readonly SoundPlayer BackgroundSound = new SoundPlayer(Properties.Resources.Background);
        //Settingss


        private void Start_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num1, num2;
            pic1.Visible = true;
            pic2.Visible = true;
            Score.Visible = true;
            picwin.Visible = false;
            picfail.Visible = false;
            {
                num1 = random.Next(1, 3);
                num2 = random.Next(1, 3);

                pic1.Image = Image.FromFile(@num1 + ".jpg");
                pic2.Image = Image.FromFile(@num2 + ".jpg");

                Results(num1, num2);
                DisplayResults(Results(num1, num2));
                Boolean Results(int n1, int n2)
                {
                    Boolean Result = false;
                    if (num1 == num2)
                    {
                        Result = true;
                    }
                    else
                    {
                        Result = false;
                    }
                    return Result;
                }
                void DisplayResults(Boolean Result)
                {
                    Results(num1, num2);
                    if (Result == true)
                    {
                        picwin.Visible = true;
                        picfail.Visible = false;
                        win.Play();
                        win.Dispose();
                        GameScore += 1;
                        Score.Text = "Score: " + GameScore.ToString();
                    }
                    else
                    {
                        fail.Play();
                        fail.Dispose();
                        picwin.Visible = false;
                        picfail.Visible = true;
                        GameScore = 0;
                        Score.Text = "Score: " + GameScore.ToString();
                    }
                }
            }
        }

        private void BGMusicTgl_Click(object sender, EventArgs e)
        {
            BackgroundSound.Dispose();
            BackgroundSound.PlayLooping();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
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
