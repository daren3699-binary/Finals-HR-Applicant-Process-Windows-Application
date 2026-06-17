using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class Screening : Form
    {
        private int _applicationID;
        public Screening(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }

        private void Screening_Load(object sender, EventArgs e)
        {
            LoadApplicantInfo();
        }

        private void LoadApplicantInfo()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT a.FirstName, a.LastName, j.JobTitle
                                     FROM Applications ap
                                     JOIN Applicants a ON ap.ApplicantID = a.ApplicantID
                                     JOIN JobVacancies j ON ap.JobVacancyID = j.JobVacancyID
                                     WHERE ap.ApplicationID = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblApplicantName.Text = $"Applicant: {reader["FirstName"]} {reader["LastName"]}";
                                lblJobTitle.Text = $"Position: {reader["JobTitle"]}";
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading applicant info: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rbQualified.Checked && !rbNotQualified.Checked)
            {
                MessageBox.Show("Please select Qualified or Not Qualified.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = rbQualified.Checked ? "Qualified" : "Not Qualified";
            string newStatus = rbQualified.Checked ? "Shortlisted" : "Rejected";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // saves to ScreeningResults
                    string insertQuery = @"INSERT INTO ScreeningResults 
                                          (ApplicationID, Result, Remarks, ScreenedBy)
                                          VALUES (@appId, @result, @remarks, @by)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", _applicationID);
                        cmd.Parameters.AddWithValue("@result", result);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }

                    // updates application status
                    string updateQuery = "UPDATE Applications SET Status=@status WHERE ApplicationID=@id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }

                    // logs in ApplicationStatusHistory
                    string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                                            (ApplicationID, Status, Remarks, ChangedBy)
                                            VALUES (@id, @status, @remarks, @by)";
                    using (var cmd = new MySqlCommand(historyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUsername);
                        cmd.ExecuteNonQuery();
                    }
                    AuditLogger.Log("HR", Session.CurrentUserId, $"Screened applicant as {result}", "ScreeningResults", _applicationID);
                }
                MessageBox.Show($"Screening saved. Applicant marked as {result}.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
