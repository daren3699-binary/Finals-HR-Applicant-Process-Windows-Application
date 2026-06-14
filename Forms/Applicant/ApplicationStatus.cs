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

        private void SetDotColor(Panel dot, Color color)
        {
            dot.BackColor = color;
        }

        private void LoadStatus()
        {
            Color colorDone = Color.FromArgb(29, 158, 117);
            Color colorActive = Color.FromArgb(55, 138, 221);
            Color colorPending = Color.FromArgb(220, 220, 220);
            Color colorRejected = Color.FromArgb(226, 75, 74);
            Color colorWarning = Color.FromArgb(255, 193, 7);

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
                        SetDotColor(pnlStatus1, colorPending);
                        SetDotColor(pnlStatus2, colorPending);
                        SetDotColor(pnlStatus3, colorPending);
                        SetDotColor(pnlStatus4, colorPending);
                        SetDotColor(pnlStatus5, colorPending);
                        SetDotColor(pnlStatus6, colorPending);
                        lblStep1Desc.Text = "No application submitted yet.";
                        lblStep2Desc.Text = "Pending submission.";
                        lblStep3Desc.Text = "Pending submission.";
                        lblStep4Desc.Text = "Pending submission.";
                        lblStep5Desc.Text = "Pending submission.";
                        lblStep6Desc.Text = "Pending submission.";
                        txtHRNotes.Text = "You have not submitted an application yet.\r\nGo to Job Vacancies to apply.";
                        lblInterviewDate.Text = "-";
                        lblInterviewTime.Text = "-";
                        lblInterviewMode.Text = "-";
                        lblInterviewInterviewer.Text = "-";
                        return;
                    }

                    string[] statusOrder = { "Submitted", "Under Review", "Shortlisted", "For Interview", "For Assessment", "For Final Review", "Accepted", "Rejected", "Withdrawn" };
                    int currentIndex = Array.IndexOf(statusOrder, currentStatus);

                    SetDotColor(pnlStatus1, colorDone);
                    lblStep1Desc.Text = "Submitted on " + dateApplied.ToString("MMMM dd, yyyy") + " for " + jobTitle + ".";

                    string[] pastReview = { "Under Review", "Shortlisted", "For Interview", "For Assessment", "For Final Review", "Accepted", "Rejected", "Withdrawn" };
                    if (Array.Exists(pastReview, s => s == currentStatus))
                    {
                        SetDotColor(pnlStatus2, colorDone);
                        lblStep2Desc.Text = "HR has reviewed your application.";
                    }
                    else if (currentStatus == "Submitted")
                    {
                        SetDotColor(pnlStatus2, colorWarning);
                        lblStep2Desc.Text = "Human Resources is currently evaluating your qualifications.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus2, colorPending);
                        lblStep2Desc.Text = "Pending submission.";
                    }

                    string[] pastShortlist = { "Shortlisted", "For Interview", "For Assessment", "For Final Review", "Accepted", "Rejected", "Withdrawn" };
                    if (Array.Exists(pastShortlist, s => s == currentStatus))
                    {
                        SetDotColor(pnlStatus3, colorDone);
                        lblStep3Desc.Text = "You passed initial screening.";
                    }
                    else if (currentStatus == "Under Review")
                    {
                        SetDotColor(pnlStatus3, colorWarning);
                        lblStep3Desc.Text = "Screening is in progress.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus3, colorPending);
                        lblStep3Desc.Text = "Pending review.";
                    }

                    string[] pastInterview = { "For Assessment", "For Final Review", "Accepted", "Rejected", "Withdrawn" };
                    if (currentStatus == "For Interview")
                    {
                        SetDotColor(pnlStatus4, colorActive);
                        lblStep4Desc.Text = "You have been scheduled for an interview.";
                    }
                    else if (Array.Exists(pastInterview, s => s == currentStatus))
                    {
                        SetDotColor(pnlStatus4, colorDone);
                        lblStep4Desc.Text = "Interview completed.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus4, colorPending);
                        lblStep4Desc.Text = "Pending interview scheduling.";
                    }

                    string[] pastAssessment = { "For Final Review", "Accepted", "Rejected", "Withdrawn" };
                    if (currentStatus == "For Assessment")
                    {
                        SetDotColor(pnlStatus5, colorActive);
                        lblStep5Desc.Text = "You are scheduled for an assessment or exam.";
                    }
                    else if (Array.Exists(pastAssessment, s => s == currentStatus))
                    {
                        SetDotColor(pnlStatus5, colorDone);
                        lblStep5Desc.Text = "Assessment completed.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus5, colorPending);
                        lblStep5Desc.Text = "Pending assessment.";
                    }

                    if (currentStatus == "Accepted")
                    {
                        SetDotColor(pnlStatus6, colorDone);
                        lblStep6Desc.Text = "Congratulations! Your application has been accepted.";
                    }
                    else if (currentStatus == "Rejected")
                    {
                        SetDotColor(pnlStatus6, colorRejected);
                        lblStep6Desc.Text = "Your application was not moved forward at this time.";
                    }
                    else if (currentStatus == "Withdrawn")
                    {
                        SetDotColor(pnlStatus6, colorPending);
                        lblStep6Desc.Text = "Your application has been withdrawn.";
                    }
                    else if (currentStatus == "For Final Review")
                    {
                        SetDotColor(pnlStatus6, colorWarning);
                        lblStep6Desc.Text = "Waiting for HR Manager final decision.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus6, colorPending);
                        lblStep6Desc.Text = "Not yet determined.";
                    }

                    string interviewQuery = @"SELECT i.InterviewDate, i.InterviewTime, i.Mode, i.Location, u.FullName
                                              FROM InterviewSchedules i
                                              LEFT JOIN Users u ON i.InterviewerID = u.UserID
                                              WHERE i.ApplicationID = @appId
                                              ORDER BY i.InterviewDate DESC LIMIT 1";

                    using (MySqlCommand intCmd = new MySqlCommand(interviewQuery, conn))
                    {
                        intCmd.Parameters.AddWithValue("@appId", applicationID);
                        using (MySqlDataReader intReader = intCmd.ExecuteReader())
                        {
                            if (intReader.Read())
                            {
                                lblInterviewDate.Text = intReader.GetDateTime("InterviewDate").ToString("MMMM dd, yyyy");
                                lblInterviewTime.Text = intReader.GetTimeSpan("InterviewTime").ToString(@"hh\:mm") + " " +
                                    (intReader.GetTimeSpan("InterviewTime").Hours < 12 ? "AM" : "PM");
                                string mode = intReader["Mode"]?.ToString() ?? "-";
                                string location = intReader["Location"]?.ToString() ?? "";
                                lblInterviewMode.Text = string.IsNullOrWhiteSpace(location) ? mode : mode + " — " + location;
                                lblInterviewInterviewer.Text = intReader["FullName"]?.ToString() ?? "-";
                            }
                            else
                            {
                                lblInterviewDate.Text = "-";
                                lblInterviewTime.Text = "-";
                                lblInterviewMode.Text = "-";
                                lblInterviewInterviewer.Text = "-";
                            }
                        }
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
