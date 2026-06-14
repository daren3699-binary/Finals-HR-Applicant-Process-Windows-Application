using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicationStatus : UserControl
    {
        private int _applicantAccountID;

        public ApplicationStatus()
        {
            InitializeComponent();
        }

        public ApplicationStatus(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
            LoadStatus();
        }

        private void LoadStatus()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string appQuery = @"SELECT a.ApplicationID, a.Status, a.DateApplied, j.JobTitle 
                                        FROM Applications a 
                                        JOIN JobVacancies j ON a.JobID = j.JobVacancyID
                                        WHERE a.ApplicantAccountID = @uid 
                                        ORDER BY a.DateApplied DESC LIMIT 1";

                    int applicationID = 0;
                    string currentStatus = "";
                    string jobTitle = "";
                    DateTime dateApplied = DateTime.Now;

                    using (MySqlCommand cmd = new MySqlCommand(appQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationID = reader.GetInt32("ApplicationID");
                                currentStatus = reader.GetString("Status");
                                dateApplied = reader.GetDateTime("DateApplied");
                                jobTitle = reader.GetString("JobTitle");
                            }
                        }
                    }

                    if (applicationID == 0)
                    {
                        pnlStatus1.BackColor = Color.FromArgb(220, 220, 220);
                        pnlStatus2.BackColor = Color.FromArgb(220, 220, 220);
                        pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);
                        lblStep1Desc.Text = "No application submitted yet.";
                        lblStep2Desc.Text = "Pending submission.";
                        lblStep3Desc.Text = "Pending submission.";
                        txtHRNotes.Text = "You have not submitted an application yet.\r\nGo to Job Vacancies to apply.";
                        return;
                    }

                    pnlStatus1.BackColor = Color.FromArgb(92, 184, 92);
                    lblStep1Desc.Text = "Submitted on " + dateApplied.ToString("MMMM dd, yyyy") + " for " + jobTitle + ".";

                    string[] reviewedStatuses = { "Under Review", "Shortlisted", "For Interview", "For Assessment", "For Final Review", "Accepted", "Rejected" };
                    bool isReviewed = Array.Exists(reviewedStatuses, s => s == currentStatus);

                    if (isReviewed)
                    {
                        pnlStatus2.BackColor = Color.FromArgb(92, 184, 92);
                        lblStep2Desc.Text = "HR has reviewed your application.";
                    }
                    else
                    {
                        pnlStatus2.BackColor = Color.FromArgb(255, 193, 7);
                        lblStep2Desc.Text = "Human Resources is currently evaluating your qualifications.";
                    }

                    if (currentStatus == "Accepted")
                    {
                        pnlStatus3.BackColor = Color.FromArgb(92, 184, 92);
                        lblStep3Desc.Text = "Congratulations! Your application has been accepted.";
                    }
                    else if (currentStatus == "Rejected")
                    {
                        pnlStatus3.BackColor = Color.FromArgb(180, 50, 50);
                        lblStep3Desc.Text = "Your application was not moved forward at this time.";
                    }
                    else if (currentStatus == "For Interview")
                    {
                        pnlStatus3.BackColor = Color.FromArgb(70, 130, 180);
                        lblStep3Desc.Text = "You have been scheduled for an interview.";
                    }
                    else
                    {
                        pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);
                        lblStep3Desc.Text = "Pending further evaluation.";
                    }

                    string historyQuery = @"SELECT Status, Remarks, ChangedBy, ChangedAt
                                            FROM ApplicationStatusHistory
                                            WHERE ApplicationID = @appId
                                            ORDER BY ChangedAt ASC";

                    using (MySqlCommand histCmd = new MySqlCommand(historyQuery, conn))
                    {
                        histCmd.Parameters.AddWithValue("@appId", applicationID);
                        using (MySqlDataReader histReader = histCmd.ExecuteReader())
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            bool hasHistory = false;

                            while (histReader.Read())
                            {
                                hasHistory = true;
                                string entryStatus = histReader.GetString("Status");
                                string changedAt = histReader.GetDateTime("ChangedAt").ToString("MMM dd, yyyy hh:mm tt");
                                string changedBy = histReader["ChangedBy"]?.ToString() ?? "";
                                string remarks = histReader["Remarks"]?.ToString() ?? "";

                                sb.AppendLine("[" + changedAt + "] " + entryStatus);
                                if (!string.IsNullOrWhiteSpace(remarks))
                                    sb.AppendLine("   Remarks: " + remarks);
                                if (!string.IsNullOrWhiteSpace(changedBy))
                                    sb.AppendLine("   By: " + changedBy);
                                sb.AppendLine();
                            }

                            if (hasHistory)
                                txtHRNotes.Text = sb.ToString().TrimEnd();
                            else
                                txtHRNotes.Text = "Status: " + currentStatus + "\r\nPosition: " + jobTitle + "\r\nDate Applied: " + dateApplied.ToString("MMMM dd, yyyy");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtHRNotes.Text = "Error loading status: " + ex.Message;
            }
        }
    }
}
