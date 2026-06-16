using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string email = txtChangeEmail.Text.Trim();
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmNewPassword = txtConfirmNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("New password must be at least 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasSpecial = false;

            foreach (char c in newPassword)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            }

            if (!hasUpper || !hasLower || !hasSpecial)
            {
                MessageBox.Show("New password must contain at least 1 uppercase letter, 1 lowercase letter, and 1 special character.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string verifyQuery = "SELECT COUNT(*) FROM ApplicantAccounts WHERE Email = @email AND PasswordHash = @current";
                    using (MySqlCommand verifyCmd = new MySqlCommand(verifyQuery, conn))
                    {
                        verifyCmd.Parameters.AddWithValue("@email", email);
                        verifyCmd.Parameters.AddWithValue("@current", PasswordHelper.Hash(currentPassword));
                        int match = Convert.ToInt32(verifyCmd.ExecuteScalar());

                        if (match == 0)
                        {
                            MessageBox.Show("Email or current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string updateQuery = "UPDATE ApplicantAccounts SET PasswordHash = @newpwd WHERE Email = @email";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newpwd", PasswordHelper.Hash(newPassword));
                        updateCmd.Parameters.AddWithValue("@email", email);
                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password changed successfully. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}