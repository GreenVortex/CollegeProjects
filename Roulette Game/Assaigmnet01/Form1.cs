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
            SoundPlayer Background = new SoundPlayer(Properties.Resources.Background);
            Background.PlayLooping();
            pic1.Visible = false;
            pic2.Visible = false;
            picfail.Visible = false;
            picwin.Visible = false;
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

        private void Start_Click(object sender, EventArgs e)
        {
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

            SoundPlayer fail = new SoundPlayer(Properties.Resources.fail);
            SoundPlayer win = new SoundPlayer(Properties.Resources.win);

            if (num1 == num2)
            {

                picwin.Visible = true;
                picfail.Visible = false;
                win.Play();
            }
            else
            {
                fail.Play();
                picwin.Visible = false;
                picfail.Visible = true;
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }
    }
}
