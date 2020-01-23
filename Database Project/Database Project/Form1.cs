using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DetailsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.student_DetailsDataSet.Students);

        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_DetailsDataSet);

        }

        private void dundalkToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void summer_Pass_GradeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Summer_Pass_Grade(this.student_DetailsDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dundalk_or_DroghedaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Dundalk_or_Drogheda(this.student_DetailsDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void summer_FailToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Summer_Fail(this.student_DetailsDataSet.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void summer_FailToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Results_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentsDataGridView.Rows.Count - 1; i++)
            {
                int s = Convert.ToInt32(studentsDataGridView.Rows[i].Cells[4].Value);
                int c = Convert.ToInt32(studentsDataGridView.Rows[i].Cells[5].Value);
                int r = (s + c) / 2;
                studentsDataGridView.Rows[i].Cells[6].Value = r.ToString();
            }

        }
    }
}
