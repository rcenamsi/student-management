using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StoredProcedure
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private DataTable dtStudents = new DataTable();

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            //dgvStudentInfo.DataSource = GetStudentList();
            LoadDataIntoGridView();
            tbName.Focus();
            //dtStudents = GetStudentList();
            //dgvStudentInfo.DataSource = dgvStudentInfo;
        }

        private void LoadDataIntoGridView()
        {
            dgvStudentInfo.DataSource = GetStudentList();
        }
        private DataTable GetStudentList()
        {
            dtStudents = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_StudentGellAllStudents", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtStudents.Load(reader);
                }
            }

            return dtStudents;
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentInfoForm(0, false);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //DataView dvStudents = dtStudents.DefaultView;
            //dvStudents.RowFilter = "Name LIKE '%" + tbName.Text.Trim() + "%'";
            FilterStringByColumn("Name", tbName);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            //DataView dvStudents = dtStudents.DefaultView;
            //dvStudents.RowFilter = "Email LIKE '%" + tbEmail.Text.Trim() + "%'";
            FilterStringByColumn("Email", tbEmail);
        }

        private void FilterStringByColumn(string columnName, TextBox txt)
        {
            DataView dvStudents = dtStudents.DefaultView;
            dvStudents.RowFilter = columnName + " LIKE '%" + txt.Text +"%'";
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            FilterStringByColumn("Address", tbAddress);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbEmail.Clear();
            tbAddress.Clear();
            tbName.Focus();
        }

        private void dgvStudentInfo_DoubleClick(object sender, EventArgs e)
        {
            int rowUpdate = dgvStudentInfo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32(dgvStudentInfo.Rows[rowUpdate].Cells["ID"].Value);

            ShowStudentInfoForm(studentId, true);
        }

        private void ShowStudentInfoForm(int studentId, bool isUpdate)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.StudentId = studentId;
            sif.IsUpdate = isUpdate;
            sif.ShowDialog();

            LoadDataIntoGridView();
        }

        
    }
}
