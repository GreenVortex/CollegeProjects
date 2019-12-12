using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Display.AppendText("1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Display.AppendText("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Display.AppendText("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Display.AppendText("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Display.AppendText("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Display.AppendText("6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Display.AppendText("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Display.AppendText("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Display.AppendText("9");
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Display.AppendText("0");
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

        }
    }
}
