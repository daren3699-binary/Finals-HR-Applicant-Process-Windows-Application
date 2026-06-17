using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class InterviewEvaluation : Form
    {
        private int _applicationID;
        private int _interviewID;

        public InterviewEvaluation(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
            numScore.Minimum = 0;
            numScore.Maximum = 100;
            btnSave.Click += btnSave_Click;
            btnBack.Click += btnBack_Click;
            Load += InterviewEvaluation_Load;
        }

        private void InterviewEvaluation_Load(object sender, EventArgs e)
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

                    string nameQuery = @"SELECT a.FirstName, a.LastName
                                         FROM Applications ap
                                         JOIN Applicants a ON ap.ApplicantID = a.ApplicantID
                                         WHERE ap.ApplicationID = @id";
                    using (var cmd = new MySqlCommand(nameQuery, conn))
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
                    // looks up latest InterviewID for this application
                    string intQuery = @"SELECT InterviewID FROM InterviewSchedules
                                        WHERE ApplicationID = @id ORDER BY InterviewID DESC LIMIT 1";
                    using (var cmd = new MySqlCommand(intQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        object result = cmd.ExecuteScalar();
                        _interviewID = result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbResult.SelectedItem == null)
            {
                MessageBox.Show("Please select a result", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_interviewID == 0)
            {
                MessageBox.Show("No interview schedule found for this applicant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = cmbResult.SelectedItem.ToString();
            string remarks = txtRemarks.Text.Trim();
            if (!string.IsNullOrEmpty(txtRecommendation.Text.Trim()))
            {
                remarks += $"\nRecommendation: {txtRecommendation.Text.Trim()}";
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO InterviewEvaluations
                                          (InterviewID, Score, Remarks, Result, EvaluatedBy)
                                          VALUES (@intId, @score, @remarks, @result, @by)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@intId", _interviewID);
                        cmd.Parameters.AddWithValue("@score", numScore.Value);
                        cmd.Parameters.AddWithValue("@remarks", remarks);
                        cmd.Parameters.AddWithValue("@result", result);
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE Applications SET Status='For Final Review' WHERE ApplicationID=@id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }

                    string historyQuery = @"INSERT INTO ApplicationStatusHistory
                                           (ApplicationID, Status, Remarks, ChangedBy)
                                           VALUES (@id, 'For Final Review', @remarks, @by)";
                    using (var cmd = new MySqlCommand(historyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.Parameters.AddWithValue("@remarks", $"Interview result: {result}. Score: {numScore.Value}/100.");
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUsername);
                        cmd.ExecuteNonQuery();
                    }
                    AuditLogger.Log("HR", Session.CurrentUserId, $"Evaluated interview: {result}", "InterviewEvaluations", _applicationID);
                }
                MessageBox.Show("Evaluation saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
