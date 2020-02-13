using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
                String name;
                String password;
                int count = 0;

                name = Username.Text;
                password = Password.Text;

                if (name == "admin" && password == "123456")
                {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                }

                else if (name == "admin")
                {
                    count++;
                    MessageBox.Show("Incorrect password - please try again");
                    Username.Clear();
                    Password.Clear();

                    MessageBox.Show("You have " + (3 - count).ToString() + " attempts left");

                    if (count == 3)
                    {
                        Application.Exit();
                    }
                }

                else if (password == "123456")
                {
                    count++;
                    MessageBox.Show("Incorrect name - please try again");
                    Username.Clear();
                    Password.Clear();

                    MessageBox.Show("You have " + (3 - count).ToString() + " attempts left");

                    if (count == 3)
                    {
                        Application.Exit();
                    }
                }

                else if (name == "" && password == "")
                {
                    MessageBox.Show("Please enter data into fields");
                }

                else
                {
                    count++;
                    MessageBox.Show("Incorrect name or password - please try again");
                    Username.Clear();
                    Password.Clear();

                    MessageBox.Show("You have " + (3 - count).ToString() + " attempts left");

                    if (count == 3)
                    {
                        Application.Exit();
                    }
                }

            }
        }
}
