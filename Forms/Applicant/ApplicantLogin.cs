using System;
using System.Drawing;
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

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog(this);
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

                    string query = "SELECT ApplicantAccountID, IsActive, PasswordHash FROM ApplicantAccounts WHERE Email = @Email";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && reader.GetString("PasswordHash") == PasswordHelper.Hash(password))
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

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}