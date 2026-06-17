using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ViewProfile : UserControl
    {
        private int _applicantAccountID;

        public ViewProfile()
        {
            InitializeComponent();
        }

        public ViewProfile(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void ViewProfile_Load(object sender, EventArgs e)
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
                                txtGender.Text = accountReader["Sex"]?.ToString() ?? "";
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

                                txtDateOfBirth.Text = reader["DateOfBirth"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["DateOfBirth"]).ToString("MMMM dd, yyyy")
                                    : "";

                                string savedGender = reader["Gender"]?.ToString() ?? "";
                                if (!string.IsNullOrWhiteSpace(savedGender))
                                    txtGender.Text = savedGender;

                                txtCivilStatus.Text = reader["CivilStatus"]?.ToString() ?? "";
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

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            using (EditMyProfile editForm = new EditMyProfile(_applicantAccountID))
            {
                editForm.ShowDialog();
            }

            // Refresh the read-only view in case anything was changed and saved.
            LoadProfile();
        }
    }
}
