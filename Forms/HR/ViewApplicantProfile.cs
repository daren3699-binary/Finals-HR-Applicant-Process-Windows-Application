using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class ViewApplicantProfile : Form
    {
        private int _applicantId;

        public ViewApplicantProfile(int applicantId)
        {
            InitializeComponent();
            _applicantId = applicantId;
            Load += ViewApplicantProfile_Load;
        }

        private void ViewApplicantProfile_Load(object sender, EventArgs e)
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

                    string query = @"SELECT a.FirstName, a.LastName, a.MiddleName, a.DateOfBirth, a.Gender,
                                    a.CivilStatus, a.Nationality, a.Phone,
                                    a.Street, a.Barangay, a.City, a.Province, a.ZipCode,
                                    a.School, a.Degree, a.YearGraduated,
                                    a.Skills,
                                    a.CompanyName, a.JobTitle, a.WorkFrom, a.WorkTo, a.WorkRemarks,
                                    aa.Email
                             FROM Applicants a
                             JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                             WHERE a.ApplicantID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicantId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text = reader["FirstName"]?.ToString() ?? "";
                                txtLastName.Text = reader["LastName"]?.ToString() ?? "";
                                txtMiddleName.Text = reader["MiddleName"]?.ToString() ?? "";
                                txtEmail.Text = reader["Email"]?.ToString() ?? "";

                                txtDateOfBirth.Text = reader["DateOfBirth"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["DateOfBirth"]).ToString("MMMM dd, yyyy")
                                    : "";

                                txtGender.Text = reader["Gender"]?.ToString() ?? "";
                                txtCivilStatus.Text = reader["CivilStatus"]?.ToString() ?? "";
                                txtNationality.Text = reader["Nationality"]?.ToString() ?? "";
                                txtPhone.Text = reader["Phone"]?.ToString() ?? "";

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
                            else
                            {
                                MessageBox.Show("This applicant has not completed their profile yet.",
                                    "No Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
