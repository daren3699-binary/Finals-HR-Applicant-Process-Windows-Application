using System;
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
            LoadReport("");
        }
        private void LoadReport(string statusFilter)
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

                        var adapter = new MySqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);
                        dgvReport.DataSource = table;
                    }
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string filter = cmbFilter.SelectedItem?.ToString() ?? "";
            LoadReport(filter == "All" ? "" : filter);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveDialog.FileName = "HR_Report_" + DateTime.Now.ToString("yyyyMMdd");

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // the syntax StringBuilder builds the CSV text line by line
                var sb = new StringBuilder();

                // writes column headers
                foreach (DataGridViewColumn col in dgvReport.Columns) sb.Append(col.HeaderText + ",");
                sb.AppendLine();

                // writes each row
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells) sb.Append(cell.Value?.ToString() + ",");
                    sb.AppendLine();
                }

                File.WriteAllText(saveDialog.FileName, sb.ToString());
                MessageBox.Show("Exported successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
