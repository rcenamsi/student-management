using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StoredProcedure
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int noOfAttempts = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsValidated())
            {
                try
                {
                    bool isUsernameCorrect, isPasswordCorrect, isActive;
                
                    GetIsUserLoginCorrect(out isUsernameCorrect, out isPasswordCorrect, out isActive);
                
                    if(isUsernameCorrect && isPasswordCorrect)
                    {
                        if(isActive)
                        {
                            this.Hide();

                            if (cbRememberMe.Checked)
                            {
                                Properties.Settings.Default.Username = txtUsername.Text;
                                Properties.Settings.Default.Save();
                            }

                            ManageStudentsForm msf = new ManageStudentsForm();
                            msf.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Your account is not active. Please Consult Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                    else
                    {
                        noOfAttempts++;

                        if (!isUsernameCorrect)
                        {
                            MessageBox.Show("Username is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtPassword.Focus();
                            
                            if(noOfAttempts >= 3)
                            {
                                DisableThisAccount();
                                MessageBox.Show("The account associated with this username is disabled now \nPlease Contact Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsername.Clear();
                            }
                                txtPassword.Clear();
                                txtUsername.Focus();
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error :" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisableThisAccount()
        {
            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserDisableThisAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void GetIsUserLoginCorrect(out bool isUsernameCorrect, out bool isPasswordCorrect, out bool isActive)
        {
            string connString = ConfigurationManager.ConnectionStrings["StoredProcedure.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("usp_UserCheckLoginDetails", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                
                //Output Parameter
                cmd.Parameters.Add("@IsUsernameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IsPasswordCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Direction = ParameterDirection.Output;

                //Parameter
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();

                isUsernameCorrect = (bool)cmd.Parameters["@isUsernameCorrect"].Value;
                isPasswordCorrect = (bool)cmd.Parameters["@isPasswordCorrect"].Value;
                isActive = (bool)cmd.Parameters["@IsActive"].Value;
           
            }
        }

        private bool IsValidated()
        {
            if(txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username name is requried", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is requried", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;
        }
    }
}
