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

        private void Search_Click(object sender, EventArgs e)
        {
                        this.studentsTableAdapter.Update(this.student_DetailsDataSet);

            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = \\NSSServer\StudentFolders$\2019\MCT\19JAndersson.OFI\GitHub\CollegeProjects\Database Project\Database Project\Student Details.mdb");
            //set up connection string
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Students WHERE name LIKE '" + SearchWord.Text + "%'",conn);


            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
          
            da.Fill(ds);
           
            this.studentsDataGridView.DataSource = ds.Tables[0];
            OleDbDataReader dbDataReader = cmd.ExecuteReader();

            
            if (dbDataReader.Read())
            {
                nameTextBox.Text = dbDataReader["name"].ToString();
                phoneNumberTextBox.Text = dbDataReader["phoneNumber"].ToString();


              addressTextBox.Text = dbDataReader["Address"].ToString();
                class_GroupTextBox.Text = dbDataReader["Class Group"].ToString();
                summer_MarkTextBox.Text = dbDataReader["Summer Mark"].ToString();

                christmas_MarkTextBox.Text = dbDataReader["Christmas Mark"].ToString();

            }
            else
            {
                MessageBox.Show("Record not found","Not Found");
            }


            conn.Close();

        }

        private void helpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"\\NSSServer\StudentFolders$\2019\MCT\19JAndersson.OFI\GitHub\CollegeProjects\Database Project\Database Project\";
            openFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*|*.*)";
            openFileDialog.Title = "Open Help";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                openFileDialog.OpenFile();

                System.Diagnostics.Process.Start(openFileDialog.FileName);
            }
        }
    }
}
