using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ApplicantRegistration;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicantLogin : Form
    {
        public ApplicantLogin()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact HR to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ApplicantAccountID, IsActive FROM ApplicantAccounts " +
                                   "WHERE Email = @Email AND PasswordHash = @Password";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isActive = reader.GetBoolean("IsActive");

                                if (!isActive)
                                {
                                    MessageBox.Show("Your account is inactive. Contact HR.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                int accountID = reader.GetInt32("ApplicantAccountID");

                                if (chkKeepSignedIn.Checked)
                                    SessionManager.SaveSession(accountID);
                                else
                                    SessionManager.ClearSession();

                                MessageBox.Show("Login successful! Welcome.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ApplicantDashboard dashboard = new ApplicantDashboard(accountID);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ApplicantRegistration.ApplicantRegistration registrationForm = new ApplicantRegistration.ApplicantRegistration();
            registrationForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}