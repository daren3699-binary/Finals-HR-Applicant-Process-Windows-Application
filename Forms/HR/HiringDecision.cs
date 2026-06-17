using System;
using System.Drawing;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class HiringDecision : Form
    {
        private int _applicationID;

        public HiringDecision(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
            btnSave.Click += btnSave_Click;
            btnBack.Click += btnBack_Click;
            Load += HiringDecision_Load;
        }

        private void HiringDecision_Load(object sender, EventArgs e)
        {
            if (Session.CurrentRole != "HR Manager" && Session.CurrentRole != "Admin")
            {
                MessageBox.Show("Access Denied. Only HR Manager and Admin can make hiring decisions.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoadApplicantInfo();
        }

        private void LoadApplicantInfo()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT a.FirstName, a.LastName
                                     FROM Applications ap
                                     JOIN Applicants a ON ap.ApplicantID = a.ApplicantID
                                     WHERE ap.ApplicationID = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblApplicant.Text = $"Applicant: {reader["FirstName"]} {reader["LastName"]}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDecision.SelectedItem == null)
            {
                MessageBox.Show("Please select a decision.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string decision = cmbDecision.SelectedItem.ToString();
            // backend guard, double checks even if dropdown was manipulated
            if (decision == "Accepted" && Session.CurrentRole != "HR Manager" && Session.CurrentRole != "Admin")
            {
                MessageBox.Show("Only HR Manager or Admin can accept applicants.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // "on-hold" display in Database
            string newStatus = decision == "Accepted" ? "Accepted" :
                               decision == "Rejected" ? "Rejected" : "On Hold";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO HiringDecisions
                                          (ApplicationID, Decision, Remarks, DecidedBy)
                                          VALUES (@appId, @decision, @remarks, @by)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", _applicationID);
                        cmd.Parameters.AddWithValue("@decision", newStatus);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE Applications SET Status=@status WHERE ApplicationID=@id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }

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

                    AuditLogger.Log("HR", Session.CurrentUserId, $"Hiring decision: {newStatus}", "HiringDecisions", _applicationID);
                }
                MessageBox.Show($"Decision saved: {newStatus}", "Saved");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
