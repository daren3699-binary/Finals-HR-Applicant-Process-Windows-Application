using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class InterviewSchedule : Form
    {
        private int _applicationID;

        public InterviewSchedule(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
            btnSave.Click += btnSave_Click;
            btnBack.Click += btnBack_Click;
        }

        private void InterviewSchedule_Load(object sender, EventArgs e)
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
            if (dtpInterviewDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Interview date must be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMode.SelectedItem == null)
            {
                MessageBox.Show("Please select a mode.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string insertQuery = @"INSERT INTO InterviewSchedules
                                          (ApplicationID, InterviewDate, Mode, Location, InterviewerID, Status)
                                          VALUES (@appId, @date, @mode, @loc, @by, 'Scheduled')";

                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", _applicationID);
                        cmd.Parameters.AddWithValue("@date", dtpInterviewDate.Value);
                        cmd.Parameters.AddWithValue("@mode", cmbMode.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@loc", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE Applications SET Status='For Interview' WHERE ApplicationID=@id";
                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }

                    string historyQuery = @"INSERT INTO ApplicationStatusHistory
                                           (ApplicationID, Status, Remarks, ChangedBy)
                                           VALUES (@id, 'For Interview', 'Interview scheduled.', @by)";
                    using (var cmd = new MySqlCommand(historyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.Parameters.AddWithValue("@by", Session.CurrentUsername);
                        cmd.ExecuteNonQuery();
                    }

                    AuditLogger.Log("HR", Session.CurrentUserId, "Scheduled interview", "InterviewSchedules", _applicationID);

                }
                MessageBox.Show("Interview scheduled successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
