using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ApplicationRegistration
{
    public partial class ApplicationRegistration : Form
    {
        string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

        public ApplicationRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string middleInitial = txtMiddleInitial.Text.Trim();
            string dateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            string sex = cmbSex.SelectedItem?.ToString() ?? "";
            string contactInfo = txtContactInfo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (firstName == "" || surname == "" || sex == "" || contactInfo == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                return;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            }

            if (!hasUpper || !hasLower || !hasSpecial)
            {
                MessageBox.Show("Password must contain at least 1 uppercase letter, 1 lowercase letter, and 1 special character (e.g. @, #, !).");
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM ApplicantAccounts WHERE Email = @email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Email is already registered. Please use a different email.");
                    conn.Close();
                    return;
                }

                string insertQuery = "INSERT INTO ApplicantAccounts (FirstName, Surname, MiddleInitial, DateOfBirth, Sex, ContactInfo, Email, Password) VALUES (@firstname, @surname, @middleinitial, @dob, @sex, @contactinfo, @email, @password)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@firstname", firstName);
                insertCmd.Parameters.AddWithValue("@surname", surname);
                insertCmd.Parameters.AddWithValue("@middleinitial", middleInitial);
                insertCmd.Parameters.AddWithValue("@dob", dateOfBirth);
                insertCmd.Parameters.AddWithValue("@sex", sex);
                insertCmd.Parameters.AddWithValue("@contactinfo", contactInfo);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Registration successful! You can now log in.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}