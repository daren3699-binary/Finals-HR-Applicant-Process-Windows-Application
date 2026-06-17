using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            cmbApplicantFilter.SelectedIndex = 0;
            cmbInterviewsFilter.SelectedIndex = 0;
            cmbVacancyFilter.SelectedIndex = 0;
            cmbReqFilter.SelectedIndex = 0;

            LoadApplicantReport("");
            LoadInterviewReport("");
            LoadVacancyReport("");
            LoadRequirementsReport("");
        }


        private void LoadApplicantReport(string statusFilter)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Joins 4 tables to get a complete applicant report
                    string query = @"SELECT a.ApplicantID, a.FirstName, a.LastName,
                                     aa.Email, j.JobTitle, ap.Status, ap.SubmittedAt
                                     FROM Applicants a
                                     JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                                     JOIN Applications ap ON a.ApplicantID = ap.ApplicantID
                                     JOIN JobVacancies j ON ap.JobVacancyID = j.JobVacancyID";

                    // adding WHERE clause only if a filter was selected 
                    if (!string.IsNullOrEmpty(statusFilter)) query += " WHERE ap.Status = @status";
                    query += " ORDER BY ap.SubmittedAt DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter)) cmd.Parameters.AddWithValue("@status", statusFilter);

                        DataTable table = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(table);
                        dgvApplicantReport.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
        }

        private void LoadInterviewReport(string statusFilter)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        i.InterviewID,
                                        CONCAT(a.FirstName,' ',a.LastName) AS ApplicantName,
                                        j.JobTitle,
                                        i.InterviewDate,
                                        i.Mode,
                                        i.Location,
                                        i.Status
                                    FROM InterviewSchedules i
                                    JOIN Applications ap
                                        ON i.ApplicationID = ap.ApplicationID
                                    JOIN Applicants a
                                        ON ap.ApplicantID = a.ApplicantID
                                    JOIN JobVacancies j
                                        ON ap.JobVacancyID = j.JobVacancyID";

                    if (!string.IsNullOrEmpty(statusFilter)) query += " WHERE i.Status = @status";
                    query += " ORDER BY i.InterviewDate DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter)) cmd.Parameters.AddWithValue("@status", statusFilter);
                        DataTable table = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(table);
                        dgvInterviewsReport.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
        }

        private void LoadVacancyReport(string statusFilter)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        j.JobVacancyID,
                                        j.JobTitle,
                                        d.DepartmentName,
                                        j.EmploymentType,
                                        j.Status,
                                        j.CreatedAt,
                                        COUNT(ap.ApplicationID) AS ApplicantCount
                                    FROM JobVacancies j
                                    LEFT JOIN Departments d
                                        ON j.DepartmentID = d.DepartmentID
                                    LEFT JOIN Applications ap
                                        ON j.JobVacancyID = ap.JobVacancyID";

                    if (!string.IsNullOrEmpty(statusFilter)) query += " WHERE j.Status = @status";
                    query += @" GROUP BY j.JobVacancyID
                                ORDER BY j.CreatedAt DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter)) cmd.Parameters.AddWithValue("@status", statusFilter);
                        DataTable table = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(table);
                        dgvVacancyReport.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
        }

        private void LoadRequirementsReport(string statusFilter)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT
                                        CONCAT(a.FirstName,' ',a.LastName) AS ApplicantName,
                                        j.JobTitle,
                                        rt.RequirementName,
                                        COALESCE(ad.Status, 'Missing') AS Status,
                                        ad.UploadedAt
                                    FROM Applications ap
                                    JOIN Applicants a
                                        ON ap.ApplicantID = a.ApplicantID
                                    JOIN JobVacancies j
                                        ON ap.JobVacancyID = j.JobVacancyID
                                    CROSS JOIN RequirementTypes rt
                                    LEFT JOIN ApplicantDocuments ad
                                        ON ad.ApplicationID = ap.ApplicationID
                                        AND ad.RequirementTypeID = rt.RequirementTypeID";

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        if (statusFilter == "Missing")
                        {
                            query += " WHERE ad.Status IS NULL";
                        }
                        else
                        {
                            query += " WHERE ad.Status = @status";
                        }
                    }

                    query += " ORDER BY ApplicantName, rt.RequirementName";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "Missing") cmd.Parameters.AddWithValue("@status", statusFilter);

                        DataTable table = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(table);
                        dgvReqReport.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
        }

        private void ExportGrid(DataGridView grid, string filenamePrefix)
        {
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveDialog.FileName = filenamePrefix + "_" + DateTime.Now.ToString("yyyyMMdd");

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewColumn col in grid.Columns) sb.Append(col.HeaderText + ",");

            sb.AppendLine();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells) sb.Append(cell.Value?.ToString() + ",");
                sb.AppendLine();
            }

            File.WriteAllText(saveDialog.FileName, sb.ToString());

            MessageBox.Show("Export successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Filter ComboBox Events
        private void cmbApplicantFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cmbApplicantFilter.SelectedItem?.ToString() ?? "";
            LoadApplicantReport(filter == "All" ? "" : filter);
        }

        private void cmbInterviewsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cmbInterviewsFilter.SelectedItem?.ToString() ?? "";
            LoadInterviewReport(filter == "All" ? "" : filter);
        }

        private void cmbVacancyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cmbVacancyFilter.SelectedItem?.ToString() ?? "";
            LoadVacancyReport(filter == "All" ? "" : filter);
        }

        private void cmbReqFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cmbReqFilter.SelectedItem?.ToString() ?? "";
            LoadRequirementsReport(filter == "All" ? "" : filter);
        }

        // Export Button Events
        private void btnApplicantExport_Click(object sender, EventArgs e)
        {
            ExportGrid(dgvApplicantReport, "ApplicantReport");
        }

        private void btnInterviewExport_Click(object sender, EventArgs e)
        {
            ExportGrid(dgvInterviewsReport, "InterviewReport");
        }

        private void btnVacancyExport_Click(object sender, EventArgs e)
        {
            ExportGrid(dgvVacancyReport, "JobVacancyReport");
        }

        private void btnReqExport_Click(object sender, EventArgs e)
        {
            ExportGrid(dgvReqReport, "MissingRequirementsReport");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
