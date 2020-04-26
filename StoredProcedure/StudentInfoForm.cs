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
using System.IO;
using StoredProcedure.Properties;
using System.Collections;

namespace StoredProcedure
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        //StudentID
        private int studentId = 0;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        } // from starting form 

        //ToUpdate
        private bool isUpdate = false;
        public bool IsUpdate
        {
            get { return isUpdate; }
            set { isUpdate = value; }
        }

        //Original Row Version
        public byte[] OriginalRowVersion { get; set; }
        
        public enum Gender
        {
            NoSelection = 0,
            Male = 1,
            Female = 2,
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.isUpdate)
            {
                //if Data is already updated then the user message and reload the fresh data for update
                if(IfDataNotUpdated(OriginalRowVersion, GetCurrentRowVersion()))
                {
                    // Execute Update Code
                    UpdateStudentDetails();

                    MessageBox.Show("Student Information Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Reloading. Data Reloaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LoadAndMapDataToControlIfUpdate();
                }

            }
            else
            {
                // Execute Insert Mode
                InsertStudentDetails();
                MessageBox.Show("Student Information has added into the System!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private byte[] GetCurrentRowVersion()
        {
            byte[] currentRowVersion = new byte[8];

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(connString))
            {
                using(SqlCommand cmd = new SqlCommand("usp_GetCurrentRowVersion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", this.StudentId);

                    conn.Open();

                    currentRowVersion = (byte[])cmd.ExecuteScalar();
                }
            }

            return currentRowVersion;
        }

        private bool IfDataNotUpdated(byte[] originalRawVersion, byte[] currentRowVersion)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(originalRawVersion, currentRowVersion);
        }

        private void UpdateStudentDetails()
        {
            string conString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_StudentUpdateDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parameter
                    cmd.Parameters.AddWithValue("@ID", this.StudentId);
                    cmd.Parameters.AddWithValue("@Name",tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("Email", tbEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@InterestC#", chbCSharp.Checked);
                    cmd.Parameters.AddWithValue("@InterestVB", chbVB.Checked);
                    cmd.Parameters.AddWithValue("@InterestJava", chbJava.Checked);
                    cmd.Parameters.AddWithValue("@GenderID", GetGender());
                    cmd.Parameters.AddWithValue("@DOB", (dtpDOB.Text.Trim() == string.Empty) ? (DateTime?)null : dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@StartTime", (dtpStart.Text.Trim() == string.Empty) ? (TimeSpan?)null : dtpStart.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@EndTime", (dtpEnd.Text.Trim() == string.Empty) ? (TimeSpan?)null : dtpEnd.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@FundTypeId", (cbFundType.SelectedIndex == -1) ? 0 : cbFundType.SelectedValue);
                    cmd.Parameters.AddWithValue("@FeesPaymentId", (cbPayments.SelectedIndex == -1) ? 0 : cbPayments.SelectedValue);
                    cmd.Parameters.AddWithValue("@Comments", CommentBox.Text);
                    cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@LocalityId", (cbLocality.SelectedIndex == -1) ? 0 : cbLocality.SelectedValue);
                    cmd.Parameters.AddWithValue("@CityId", (cbCity.SelectedIndex == -1) ? 0 : cbCity.SelectedValue);
                    cmd.Parameters.AddWithValue("@PostCode", txtPostCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Photo", SavePhoto());
                    
                    //Open Connection
                    conn.Open();
                    //ExecuteReader -- (Select Statement)
                    //ExecuteScaler -- (Select Statement)
                    //ExecuteNonQuery -- (Insert, Update or Delete)
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void InsertStudentDetails()
        {
            string conString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_StudentsInsertDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Parameter
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = tbName.Text.Trim();
                    cmd.Parameters.AddWithValue("Email", tbEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@InterestC#", chbCSharp.Checked);
                    cmd.Parameters.AddWithValue("@InterestVB", chbVB.Checked);
                    cmd.Parameters.AddWithValue("@InterestJava", chbJava.Checked);
                    cmd.Parameters.AddWithValue("@GenderID", GetGender());
                    cmd.Parameters.AddWithValue("@DOB", (dtpDOB.Text.Trim() == string.Empty) ? (DateTime?)null : dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@StartTime", (dtpStart.Text.Trim() == string.Empty) ? (TimeSpan?)null : dtpStart.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@EndTime", (dtpEnd.Text.Trim() == string.Empty) ? (TimeSpan?)null : dtpEnd.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@FundTypeId", (cbFundType.SelectedIndex == -1) ? 0 : cbFundType.SelectedValue);
                    cmd.Parameters.AddWithValue("@FeesPaymentId", (cbPayments.SelectedIndex == -1) ? 0 : cbPayments.SelectedValue);
                    cmd.Parameters.AddWithValue("@Comments", CommentBox.Text);
                    cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@LocalityId", (cbLocality.SelectedIndex == -1) ? 0 : cbLocality.SelectedValue);
                    cmd.Parameters.AddWithValue("@CityId", (cbCity.SelectedIndex == -1) ? 0 : cbCity.SelectedValue);
                    cmd.Parameters.AddWithValue("@PostCode", txtPostCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Photo", SavePhoto());

                    //Open Connection
                    conn.Open();
                    //ExecuteReader -- (Select Statement)
                    //ExecuteScaler -- (Select Statement)
                    //ExecuteNonQuery -- (Insert, Update or Delete)
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Information is added to the System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pbStudentImage.Image.Save(ms, pbStudentImage.Image.RawFormat);
            return ms.GetBuffer();
        }

        //private TimeSpan? GetEndTime()
        //{
        //    if(dtpEnd.Text.Trim() == string.Empty)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return dtpEnd.Value.TimeOfDay;
        //    }
        //}

        //private TimeSpan? GetStartTime()
        //{
        //    if(dtpStart.Text.Trim() == string.Empty)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return dtpStart.Value.TimeOfDay;
        //    }
        //}

        //private DateTime? GetDateOfBirth()
        //{
        //    if(dtpDOB.Text.Trim() == string.Empty) 
        //    {
        //        return (DateTime?)null;
        //    } 
        //    else
        //    {
        //        return dtpDOB.Value.Date;
        //    }
           
        //}

        private int GetGender()
        {
            return rbFemale.Checked ? (int) Gender.Female :
                rbMale.Checked ? (int) Gender.Female : (int) Gender.NoSelection;
            // if(rbMale.Checked)
            // {
            //     return (int)Gender.Male;
            // }
            // if (rbFemale.Checked)
            // {
            //     return (int)Gender.Female;
            // }
            // return (int)Gender.NoSelection;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();

            LoadAndMapDataToControlIfUpdate();

           
        }

        private void LoadAndMapDataToControlIfUpdate()
        {
            if (!this.IsUpdate) return;
            
            DataTable dtStudentInfo = GetStudentInfoById(this.StudentId);
            DataRow row = dtStudentInfo.Rows[0];
            //Textbox
            tbName.Text = row["Name"].ToString();
            tbEmail.Text = row["Email"].ToString();
            //Checkbox
            chbCSharp.Checked = (row["InterestC#"] is DBNull) ? false : Convert.ToBoolean(row["InterestC#"]);
            chbVB.Checked = (row["InterestVB"] is DBNull) ? false : Convert.ToBoolean(row["InterestVB"]);
            chbJava.Checked = (row["InterestJava"] is DBNull) ? false : Convert.ToBoolean(row["InterestJava"]);
            //Radio Button
            rbMale.Checked = (row["GenderId"] is DBNull) ? false : (Convert.ToInt16(row["GenderId"]) == 1) ? true : false;
            rbFemale.Checked = (row["GenderId"] is DBNull) ? false : (Convert.ToInt16(row["GenderId"]) == 2) ? true : false;

            //DateTimePicker
            dtpDOB.Value = (row["DOB"] is DBNull) ? dtpDOB.MinDate : Convert.ToDateTime(row["DOB"]).Date;
            dtpStart.Value = (row["StartTime"] is DBNull) ? dtpStart.MinDate : Convert.ToDateTime(row["StartTime"]);
            dtpEnd.Value = (row["EndTime"] is DBNull) ? dtpEnd.MinDate : Convert.ToDateTime(row["EndTime"]);

            //ComboBox
            cbFundType.SelectedValue = row["FundTypeId"];
            cbPayments.SelectedValue = row["FeesPaymentId"];

            //TextBox
            tbAddress.Text = row["Address"].ToString();
            cbLocality.SelectedValue = row["LocalityId"];
            cbCity.SelectedValue = row["CityId"];
            txtPostCode.Text = row["PostCode"].ToString();

            CommentBox.Text = row["Comments"].ToString();

            pbStudentImage.Image = (row["Photo"] is DBNull) ? Resources.security_guard : GetPhoto((byte[])row["Photo"]);

            this.OriginalRowVersion = (byte[])row["OriginalRowVersion"];
        }

        public Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private DataTable GetStudentInfoById(int studentId)
        {
            DataTable dtStudentById = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using(SqlCommand cmd = new SqlCommand("usp_StudentGetStudentInfoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", studentId);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtStudentById.Load(reader);
                }
            }

            return dtStudentById;

        }

        private void LoadDataIntoComboBoxes()
        {
            cbFundType.DataSource = GetListData((int)StoredProcedure.SystemConstants.SystemEnums.ListDataTypes.FundType);
            cbFundType.DisplayMember = "Description";
            cbFundType.ValueMember = "ListDataId";
            cbFundType.SelectedIndex = -1;

            cbPayments.DataSource = GetListData((int)StoredProcedure.SystemConstants.SystemEnums.ListDataTypes.FeesPayment);
            cbPayments.DisplayMember = "Description";
            cbPayments.ValueMember = "ListDataId";
            cbPayments.SelectedIndex = -1;

            cbCity.SelectedValueChanged -= new EventHandler(cbCity_SelectedValueChanged);

            cbCity.DataSource = GetAllCities();
            cbCity.DisplayMember = "Description";
            cbCity.ValueMember = "CityId";
            cbCity.SelectedIndex = -1;

            cbCity.SelectedValueChanged += new EventHandler(cbCity_SelectedValueChanged);

        }

        private DataTable GetAllCities()
        {
            DataTable dtCities = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllCities", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtCities.Load(reader);
                    conn.Close();

                }
            }

            return dtCities;  
        }

        private DataTable GetFeesPayments()
        {
            DataTable dtFeesPayment = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllListData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtFeesPayment.Load(reader);
                    conn.Close();

                }
            }

            return dtFeesPayment;
        }

        // Objects
        // DataSet
        // DataTable
        // Array
        // Collection
        // Generics
        private DataTable GetListData(int listDataTypeId)
        {
            DataTable dtListData = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllListData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ListDataTypeId", listDataTypeId);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtListData.Load(reader);
                    conn.Close();
                   
                }
            }

            return dtListData;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = dtpDOB.Value != dtpDOB.MinDate ? "dd/MM/yyyy" : "";

            // if(dtpDOB.Value == dtpDOB.MinDate)
            // {
            //     dtpDOB.CustomFormat = " ";
            // }
            // else
            // {
            //     dtpDOB.CustomFormat = "dd/MM/yyyy";
            // }

        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete)) return;
            dtpDOB.CustomFormat = "";
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            GetCustomTimeFormat(sender, "HH:mm");

        }

        private void dtpStart_MouseDown(object sender, MouseEventArgs e)
        {
            GetCustomTimeFormat(sender, "HH:mm");
        }

        private void GetCustomTimeFormat(object sender, string format)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = dtp.Value != dtp.MinDate ? format : "";

            // if(dtp.Value == dtp.MinDate)
            // {
            //     dtp.CustomFormat = " ";
            // }
            // else
            // {
            //     dtp.CustomFormat = format;
            // }
        }

        private void dtpStart_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) && (e.KeyCode == Keys.Delete)) return;
            GetCustomTimeFormat(sender, " ");
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private DataTable GetAllLocalitiesByCityId(int cityId)
        {
            DataTable dtLocalities = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllLocalitiesByCityId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CityId", cityId);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLocalities.Load(reader);
                    conn.Close();

                }
            }

            return dtLocalities;
        }

        private void cbCity_SelectedValueChanged(object sender, EventArgs e)
        {
            cbLocality.DataSource = GetAllLocalitiesByCityId((int)cbCity.SelectedValue);
            cbLocality.DisplayMember = "Description";
            cbLocality.ValueMember = "LocalityId";
        }

        private void pbStudentImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Photo";
            //ofd.Filter = "PNG File (*.png)|*.png|JPG File (*.jpg)|*.jpg|BMP File (*.bmp)|*.bmp|GIF File (*.gif)|*.gif";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbStudentImage.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
