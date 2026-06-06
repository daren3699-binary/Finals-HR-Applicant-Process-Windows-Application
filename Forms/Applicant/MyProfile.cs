using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class MyProfile : Form
    {
        private int _applicantAccountID;

        public MyProfile(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string accountQuery = "SELECT Email, FirstName, Surname, Sex, ContactInfo FROM ApplicantAccounts WHERE ApplicantAccountID = @id";
                    using (MySqlCommand accountCmd = new MySqlCommand(accountQuery, conn))
                    {
                        accountCmd.Parameters.AddWithValue("@id", _applicantAccountID);

                        using (var accountReader = accountCmd.ExecuteReader())
                        {
                            if (accountReader.Read())
                            {
                                txtEmail.Text = accountReader["Email"]?.ToString() ?? "";
                                txtFirstName.Text = accountReader["FirstName"]?.ToString() ?? "";
                                txtLastName.Text = accountReader["Surname"]?.ToString() ?? "";

                                string gender = accountReader["Sex"]?.ToString() ?? "";
                                if (cmbGender.Items.Contains(gender))
                                    cmbGender.SelectedItem = gender;

                                txtPhone.Text = accountReader["ContactInfo"]?.ToString() ?? "";
                            }
                        }
                    }

                    string query = @"SELECT FirstName, LastName, MiddleName, DateOfBirth, Gender, CivilStatus,
                                    Nationality, Phone,
                                    Street, Barangay, City, Province, ZipCode,
                                    School, Degree, YearGraduated,
                                    Skills,
                                    CompanyName, JobTitle, WorkFrom, WorkTo, WorkRemarks
                             FROM Applicants
                             WHERE ApplicantAccountID = @id2";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id2", _applicantAccountID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!string.IsNullOrWhiteSpace(reader["FirstName"]?.ToString()))
                                    txtFirstName.Text = reader["FirstName"].ToString();

                                if (!string.IsNullOrWhiteSpace(reader["LastName"]?.ToString()))
                                    txtLastName.Text = reader["LastName"].ToString();

                                txtMiddleName.Text = reader["MiddleName"]?.ToString() ?? "";

                                if (reader["DateOfBirth"] != DBNull.Value)
                                    dtpDateOfBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);

                                string savedGender = reader["Gender"]?.ToString() ?? "";
                                if (!string.IsNullOrWhiteSpace(savedGender) && cmbGender.Items.Contains(savedGender))
                                    cmbGender.SelectedItem = savedGender;

                                string civil = reader["CivilStatus"]?.ToString() ?? "";
                                if (cmbCivilStatus.Items.Contains(civil))
                                    cmbCivilStatus.SelectedItem = civil;

                                txtNationality.Text = reader["Nationality"]?.ToString() ?? "";

                                if (!string.IsNullOrWhiteSpace(reader["Phone"]?.ToString()))
                                    txtPhone.Text = reader["Phone"].ToString();

                                txtStreet.Text = reader["Street"]?.ToString() ?? "";
                                txtBarangay.Text = reader["Barangay"]?.ToString() ?? "";
                                txtCity.Text = reader["City"]?.ToString() ?? "";
                                txtProvince.Text = reader["Province"]?.ToString() ?? "";
                                txtZipCode.Text = reader["ZipCode"]?.ToString() ?? "";

                                txtSchool.Text = reader["School"]?.ToString() ?? "";
                                txtDegree.Text = reader["Degree"]?.ToString() ?? "";
                                txtYearGraduated.Text = reader["YearGraduated"]?.ToString() ?? "";

                                txtSkills.Text = reader["Skills"]?.ToString() ?? "";

                                txtCompany.Text = reader["CompanyName"]?.ToString() ?? "";
                                txtJobTitle.Text = reader["JobTitle"]?.ToString() ?? "";
                                txtWorkFrom.Text = reader["WorkFrom"]?.ToString() ?? "";
                                txtWorkTo.Text = reader["WorkTo"]?.ToString() ?? "";
                                txtWorkRemarks.Text = reader["WorkRemarks"]?.ToString() ?? "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load profile.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Applicants WHERE ApplicantAccountID = @id";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", _applicantAccountID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        string query;

                        if (count > 0)
                        {
                            query = @"UPDATE Applicants SET
                                        FirstName = @firstName,
                                        LastName = @lastName,
                                        MiddleName = @middleName,
                                        DateOfBirth = @dob,
                                        Gender = @gender,
                                        CivilStatus = @civilStatus,
                                        Nationality = @nationality,
                                        Phone = @phone,
                                        Street = @street,
                                        Barangay = @barangay,
                                        City = @city,
                                        Province = @province,
                                        ZipCode = @zipCode,
                                        School = @school,
                                        Degree = @degree,
                                        YearGraduated = @yearGraduated,
                                        Skills = @skills,
                                        CompanyName = @company,
                                        JobTitle = @jobTitle,
                                        WorkFrom = @workFrom,
                                        WorkTo = @workTo,
                                        WorkRemarks = @workRemarks
                                      WHERE ApplicantAccountID = @id";
                        }
                        else
                        {
                            query = @"INSERT INTO Applicants
                                        (ApplicantAccountID, FirstName, LastName, MiddleName, DateOfBirth,
                                         Gender, CivilStatus, Nationality, Phone,
                                         Street, Barangay, City, Province, ZipCode,
                                         School, Degree, YearGraduated,
                                         Skills,
                                         CompanyName, JobTitle, WorkFrom, WorkTo, WorkRemarks)
                                      VALUES
                                        (@id, @firstName, @lastName, @middleName, @dob,
                                         @gender, @civilStatus, @nationality, @phone,
                                         @street, @barangay, @city, @province, @zipCode,
                                         @school, @degree, @yearGraduated,
                                         @skills,
                                         @company, @jobTitle, @workFrom, @workTo, @workRemarks)";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", _applicantAccountID);
                            cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@middleName", txtMiddleName.Text.Trim());
                            cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value.Date);
                            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@civilStatus", cmbCivilStatus.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@street", txtStreet.Text.Trim());
                            cmd.Parameters.AddWithValue("@barangay", txtBarangay.Text.Trim());
                            cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                            cmd.Parameters.AddWithValue("@province", txtProvince.Text.Trim());
                            cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text.Trim());
                            cmd.Parameters.AddWithValue("@school", txtSchool.Text.Trim());
                            cmd.Parameters.AddWithValue("@degree", txtDegree.Text.Trim());
                            cmd.Parameters.AddWithValue("@yearGraduated", txtYearGraduated.Text.Trim());
                            cmd.Parameters.AddWithValue("@skills", txtSkills.Text.Trim());
                            cmd.Parameters.AddWithValue("@company", txtCompany.Text.Trim());
                            cmd.Parameters.AddWithValue("@jobTitle", txtJobTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@workFrom", txtWorkFrom.Text.Trim());
                            cmd.Parameters.AddWithValue("@workTo", txtWorkTo.Text.Trim());
                            cmd.Parameters.AddWithValue("@workRemarks", txtWorkRemarks.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Profile saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save profile.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}