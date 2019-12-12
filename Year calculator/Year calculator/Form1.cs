using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //On Calculate Month Button pressed
        private void CalculateMonth_Click(object sender, EventArgs e)
        {
            try
            {
            string SmallMonth = "30";
            string BigMonth = "31";
            int Month = int.Parse(MonthGet.Text);

            //Get and set month name
                if (Month == 1)
                {
                    MonthResult.Text = "January";
                    LeapYear.Text = "N/A";
                }
                if (Month == 2)
                {
                    MonthResult.Text = "February";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 3)
                {
                    MonthResult.Text = "March";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 4)
                {
                    MonthResult.Text = "April";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 5)
                {
                    MonthResult.Text = "May";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 6)
                {
                    MonthResult.Text = "June";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 7)
                {
                    MonthResult.Text = "July";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 8)
                {
                    MonthResult.Text = "August";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 9)
                {
                    MonthResult.Text = "September";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 10)
                {
                    MonthResult.Text = "October";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 11)
                {
                    MonthResult.Text = "November";
                    LeapYear.Text = "N/A";
                }
                else if (Month == 12)
                {
                    MonthResult.Text = "December";
                    LeapYear.Text = "N/A";
                }
                //If Month is greater than 12 or less than 1 throw error
                else if (Month < 1 || Month > 12)
                {
                    MessageBox.Show("Please use 1-12 for month","Incorrect Value",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                //Month day
                if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                {
                    //Set Month days to 31
                    Days.Text = BigMonth;
                }

                else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    //Set Month days to 30
                    Days.Text = SmallMonth;
                }

                else if (Month == 2)
                {
                    //Get True or False for Leap year and set day
                    int year = int.Parse(GetYear.Text);
                    if (DateTime.IsLeapYear(year))
                    {
                        Days.Text = "29";
                        LeapYear.Text = "Yes";
                    }
                    else
                    {
                        Days.Text = "28";
                        LeapYear.Text = "No";
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Incorrect value type number only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MonthGet.Clear();
            GetYear.Clear();
            MonthResult.Clear();
            Days.Clear();
            LeapYear.Clear();
        }
    }
}
