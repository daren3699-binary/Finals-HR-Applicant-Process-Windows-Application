using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class MyApplication : UserControl
    {
        private int _applicantAccountID;
        private int _applicationID = -1;
        private string _currentStatus = "";

        public MyApplication(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
            LoadApplication();
        }

        public MyApplication()
        {
            InitializeComponent();
        }

        private void LoadApplication()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT a.ApplicationID, a.Status, a.DateApplied, j.JobTitle, j.Qualifications
                                     FROM Applications a
                                     JOIN JobVacancies j ON a.JobID = j.JobID
                                     WHERE a.ApplicantAccountID = @uid
                                     ORDER BY a.DateApplied DESC LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _applicationID = reader.GetInt32("ApplicationID");
                                _currentStatus = reader.GetString("Status");
                                DateTime dateApplied = reader.GetDateTime("DateApplied");
                                string jobTitle = reader.GetString("JobTitle");
                                string qualifications = reader.IsDBNull(reader.GetOrdinal("Qualifications")) ? "" : reader.GetString("Qualifications");

                                lblJobTitle.Text = jobTitle;
                                lblStatus.Text = _currentStatus;
                                lblDateApplied.Text = dateApplied.ToString("MMMM dd, yyyy");
                                txtQualifications.Text = qualifications;

                                ApplyStatusColor(_currentStatus);
                                SetEditingLock(_currentStatus);
                            }
                            else
                            {
                                ShowNoApplication();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStatusColor(string status)
        {
            switch (status)
            {
                case "Draft":
                    lblStatus.ForeColor = Color.FromArgb(100, 100, 100);
                    break;
                case "Submitted":
                    lblStatus.ForeColor = Color.FromArgb(70, 130, 180);
                    break;
                case "Under Review":
                    lblStatus.ForeColor = Color.FromArgb(200, 150, 0);
                    break;
                case "Accepted":
                    lblStatus.ForeColor = Color.FromArgb(92, 184, 92);
                    break;
                case "Rejected":
                    lblStatus.ForeColor = Color.FromArgb(180, 50, 50);
                    break;
                default:
                    lblStatus.ForeColor = Color.FromArgb(100, 100, 100);
                    break;
            }
        }

        private void SetEditingLock(string status)
        {
            bool canEdit = status == "Draft" || status == "Submitted";
            btnWithdraw.Enabled = canEdit;

            if (!canEdit)
            {
                lblLockNote.Text = "Your application is locked. Editing is no longer allowed once HR has started review.";
                lblLockNote.ForeColor = Color.FromArgb(180, 50, 50);
            }
            else
            {
                lblLockNote.Text = "You may withdraw your application while it has not yet been reviewed by HR.";
                lblLockNote.ForeColor = Color.Gray;
            }
        }

        private void ShowNoApplication()
        {
            lblJobTitle.Text = "No Application Found";
            lblStatus.Text = "N/A";
            lblDateApplied.Text = "N/A";
            txtQualifications.Text = "";
            lblLockNote.Text = "You have not submitted an application yet. Go to Job Vacancies to apply.";
            lblLockNote.ForeColor = Color.Gray;
            btnWithdraw.Enabled = false;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (_applicationID == -1) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to withdraw your application? This cannot be undone.",
                "Withdraw Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string update = "UPDATE Applications SET Status = 'Withdrawn' WHERE ApplicationID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your application has been withdrawn.", "Withdrawn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error withdrawing application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}