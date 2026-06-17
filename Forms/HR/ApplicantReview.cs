using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class ApplicantReview : Form
    {
        // stores the applicant id from the applicant list
        private int _applicantId;
        private int _applicationID;
        public ApplicantReview(int applicantId) // receives the applicant id when the form is opened
        {
            InitializeComponent();
            _applicantId = applicantId;
            dgvDocuments.CellDoubleClick += dgvDocuments_CellDoubleClick;

        }

        private void ApplicantReview_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // gets applicant details + their latest application status
                    string query = @"SELECT a.FirstName, a.LastName, aa.Email,
                                     ap.Status, ap.ApplicationID
                                     FROM Applicants a
                                     JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                                     LEFT JOIN Applications ap ON a.ApplicantID = ap.ApplicantID
                                     WHERE a.ApplicantID = @id
                                     ORDER BY ap.CreatedAt DESC LIMIT 1";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicantId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = $"Name: {reader["FirstName"]} {reader["LastName"]}";
                                lblEmail.Text = $"Email: {reader["Email"]}";

                                string status = reader["Status"]?.ToString() ?? "Submitted";
                                if (cmbStatus.Items.Contains(status))
                                    cmbStatus.SelectedItem = status;
                                else
                                    cmbStatus.Text = status;

                                _applicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
            LoadAppliedJobs();
            LoadDocuments();
        }

        private void LoadAppliedJobs()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        j.JobTitle,
                                        d.DepartmentName,
                                        ap.Status,
                                        ap.SubmittedAt
                                    FROM Applications ap
                                    INNER JOIN JobVacancies j
                                        ON ap.JobVacancyID = j.JobVacancyID
                                    LEFT JOIN Departments d
                                        ON j.DepartmentID = d.DepartmentID
                                    WHERE ap.ApplicantID = @ApplicantID
                                    ORDER BY ap.CreatedAt DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantID", _applicantId);
                        var adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvAppliedJobs.DataSource = table;
                        dgvAppliedJobs.Columns["SubmittedAt"].HeaderText = "Date Submitted";
                        dgvAppliedJobs.Columns["JobTitle"].HeaderText = "Job Vacancy";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error loading applied jobs: {ex.Message}"); }
        }

        private void LoadDocuments()
        {
            if (_applicationID == 0) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        ad.DocumentID,
                                        rt.RequirementName,
                                        ad.FilePath,
                                        ad.Status,
                                        ad.UploadedAt
                                    FROM ApplicantDocuments ad
                                    INNER JOIN RequirementTypes rt
                                        ON ad.RequirementTypeID = rt.RequirementTypeID
                                    WHERE ad.ApplicationID = @ApplicationID
                                    ORDER BY ad.UploadedAt DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", _applicationID);

                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(table);

                        dgvDocuments.DataSource = table;

                        if (dgvDocuments.Columns.Contains("DocumentID")) dgvDocuments.Columns["DocumentID"].Visible = false;

                        dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading documents: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStatus = cmbStatus.SelectedItem.ToString();

            //role guard - HR Staff cannot set Accepted
            if (selectedStatus == "Accepted" && Session.CurrentRole != "HR Manager" && Session.CurrentRole != "Admin")
            {
                MessageBox.Show("Only HR Manager and Admin can accept appliants", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_applicationID == 0)
            {
                MessageBox.Show("No application found for this applicant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // updates the application status
                    string updateQuery = "UPDATE Applications SET Status = @status WHERE ApplicationID = @id";

                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", selectedStatus);
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }

                    // logs to ApplicationStatusHistory
                    string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                                            (ApplicationID, Status, Remarks, ChangedBy)
                                            VALUES (@id, @status, @remarks, @changedBy)";

                    using (var cmd2 = new MySqlCommand(historyQuery, conn))
                    {
                        cmd2.Parameters.AddWithValue("@id", _applicationID);
                        cmd2.Parameters.AddWithValue("@status", selectedStatus);
                        cmd2.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmd2.Parameters.AddWithValue("@changedBy", Session.CurrentUsername);
                        cmd2.ExecuteNonQuery();
                    }

                    AuditLogger.Log("HR", Session.CurrentUserId, $"Status changed to {selectedStatus}", "Applications", _applicationID);

                    MessageBox.Show("Status updated successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            if (_applicationID == 0)
            {
                MessageBox.Show("No application found for this applicant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Screening screen = new Screening(_applicationID);
            screen.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (_applicationID == 0) { MessageBox.Show("No application found."); return; }
            new InterviewSchedule(_applicationID).ShowDialog();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (_applicationID == 0) { MessageBox.Show("No application found."); return; }
            new InterviewEvaluation(_applicationID).ShowDialog();
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            if (Session.CurrentRole != "HR Manager" && Session.CurrentRole != "Admin")
            {
                MessageBox.Show("Only HR Manager and Admin can make hiring decisions.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_applicationID == 0) { MessageBox.Show("No application found."); return; }
            new HiringDecision(_applicationID).ShowDialog();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            new ViewApplicantProfile(_applicantId).ShowDialog();
        }

        private void dgvDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string filePath = dgvDocuments.Rows[e.RowIndex].Cells["FilePath"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("No file path found.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found:\n\n" + filePath);
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open file:\n" + ex.Message);
            }
        }

        /*private bool IsLockedStatus(string status)
        {
            return status == "Under Review"
                || status == "For Interview"
                || status == "Interviewed"
                || status == "Accepted"
                || status == "Rejected";
        }*/
    }
}
