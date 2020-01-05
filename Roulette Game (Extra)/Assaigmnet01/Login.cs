using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Assaigmnet01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //fullscreen fix
        Point lastPoint;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //fulscreen fix

        int Counter = 3;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Counter == 1)
            {
                MessageBox.Show("Attempts Exceeded program will now close","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Thread.Sleep(1000);
                Application.Exit();
            }
            else
            {
                string Username = UsernameImput.Text;
                string Password = PasswordInput.Text;
                if (Password.Equals("admin") && Username.Equals("admin"))
                {
                    Game myForm = new Game();
                    myForm.ShowDialog();
                    myForm.Dispose();
                    this.Close();
                }
                else
                {
                    Counter -= 1;
                    MessageBox.Show("Login error you have " + Counter.ToString() + " Attempts left", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }


    }
}
