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

        private void ResetAllPending()
        {
            Color colorPending = Color.FromArgb(220, 220, 220);

            SetDotColor(pnlStatus1, colorPending);
            SetDotColor(pnlStatus2, colorPending);
            SetDotColor(pnlStatus3, colorPending);
            SetDotColor(pnlStatus4, colorPending);
            SetDotColor(pnlStatus5, colorPending);
            SetDotColor(pnlStatus6, colorPending);
            SetDotColor(pnlStatus7, colorPending); // NEW: Hired step

            lblStep1Desc.Text = "No application submitted yet.";
            lblStep2Desc.Text = "Pending submission.";
            lblStep3Desc.Text = "Pending submission.";
            lblStep4Desc.Text = "Pending submission.";
            lblStep5Desc.Text = "Pending submission.";
            lblStep6Desc.Text = "Pending submission.";
            lblStep7Desc.Text = "Pending submission."; // NEW
        }

        private void LoadStatus()
        {
            Color colorDone = Color.FromArgb(29, 158, 117);   // green
            Color colorActive = Color.FromArgb(55, 138, 221);   // blue
            Color colorPending = Color.FromArgb(220, 220, 220);  // grey
            Color colorRejected = Color.FromArgb(226, 75, 74);    // red
            Color colorWarning = Color.FromArgb(255, 193, 7);    // amber

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // ── 1. Fetch the most recent application for this applicant ──────────
                    // FIX: Prioritise non-terminal active applications over old ones so
                    //      a later Draft does not shadow an Accepted/Hired record.
                    //      We ORDER BY a priority expression: terminal statuses last,
                    //      then by DateApplied DESC as a tiebreaker.
                    string appQuery = @"
                        SELECT a.ApplicationID, a.Status, a.DateApplied, j.JobTitle
                        FROM   Applications a
                        JOIN   JobVacancies  j ON a.JobID = j.JobVacancyID
                        WHERE  a.ApplicantAccountID = @uid
                        ORDER BY
                            CASE a.Status
                                WHEN 'Hired'          THEN 0
                                WHEN 'Accepted'       THEN 1
                                WHEN 'For Final Review' THEN 2
                                WHEN 'For Assessment' THEN 3
                                WHEN 'For Interview'  THEN 4
                                WHEN 'Shortlisted'    THEN 5
                                WHEN 'Under Review'   THEN 6
                                WHEN 'Submitted'      THEN 7
                                WHEN 'Rejected'       THEN 8
                                WHEN 'Withdrawn'      THEN 9
                                WHEN 'Draft'          THEN 10
                                ELSE 11
                            END ASC,
                            a.DateApplied DESC
                        LIMIT 1";

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

                    // ── 2. No application at all ─────────────────────────────────────────
                    if (applicationID == 0)
                    {
                        ResetAllPending();
                        txtHRNotes.Text = "You have not submitted an application yet.\r\nGo to Job Vacancies to apply.";
                        lblInterviewDate.Text = "-";
                        lblInterviewTime.Text = "-";
                        lblInterviewMode.Text = "-";
                        lblInterviewInterviewer.Text = "-";
                        return;
                    }

                    // ── 3. Step 1 — Application Submitted ────────────────────────────────
                    SetDotColor(pnlStatus1, colorDone);
                    lblStep1Desc.Text = "Submitted on " + dateApplied.ToString("MMMM dd, yyyy") + " for " + jobTitle + ".";

                    // ── 4. Step 2 — Under Review ─────────────────────────────────────────
                    string[] pastReview = { "Under Review", "Shortlisted", "For Interview",
                                            "For Assessment", "For Final Review",
                                            "Accepted", "Hired", "Rejected", "Withdrawn" };
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
                        lblStep2Desc.Text = "Pending review.";
                    }

                    // ── 5. Step 3 — Shortlisted ──────────────────────────────────────────
                    string[] pastShortlist = { "Shortlisted", "For Interview",
                                               "For Assessment", "For Final Review",
                                               "Accepted", "Hired", "Rejected", "Withdrawn" };
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
                        lblStep3Desc.Text = "Pending screening.";
                    }

                    // ── 6. Step 4 — For Interview ─────────────────────────────────────────
                    string[] pastInterview = { "For Assessment", "For Final Review",
                                               "Accepted", "Hired", "Rejected", "Withdrawn" };
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

                    // ── 7. Step 5 — For Assessment ────────────────────────────────────────
                    string[] pastAssessment = { "For Final Review",
                                                "Accepted", "Hired", "Rejected", "Withdrawn" };
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

                    // ── 8. Step 6 — Final Decision (Accepted / Rejected / Withdrawn) ──────
                    // NOTE: "Accepted" is no longer the LAST step — it feeds into Hired below.
                    if (currentStatus == "Accepted" || currentStatus == "Hired")
                    {
                        SetDotColor(pnlStatus6, colorDone);
                        lblStep6Desc.Text = "Congratulations! HR Manager has accepted your application.";
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
                    else if (currentStatus == "On Hold")
                    {
                        SetDotColor(pnlStatus6, colorWarning);
                        lblStep6Desc.Text = "Your application is currently on hold pending further review.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus6, colorPending);
                        lblStep6Desc.Text = "Not yet determined.";
                    }

                    // ── 9. Step 7 — HIRED (NEW) ───────────────────────────────────────────
                    if (currentStatus == "Hired")
                    {
                        SetDotColor(pnlStatus7, colorDone);
                        lblStep7Desc.Text = "You are now officially hired. Welcome to the team!";
                    }
                    else if (currentStatus == "Accepted")
                    {
                        // Accepted but onboarding not yet confirmed
                        SetDotColor(pnlStatus7, colorWarning);
                        lblStep7Desc.Text = "Awaiting final onboarding confirmation from HR.";
                    }
                    else if (currentStatus == "Rejected" || currentStatus == "Withdrawn")
                    {
                        SetDotColor(pnlStatus7, colorRejected);
                        lblStep7Desc.Text = "Application closed.";
                    }
                    else
                    {
                        SetDotColor(pnlStatus7, colorPending);
                        lblStep7Desc.Text = "Not yet determined.";
                    }

                    // ── 10. Interview details ──────────────────────────────────────────────
                    string interviewQuery = @"
                        SELECT i.InterviewDate,
                               DATE_FORMAT(i.InterviewDate, '%h:%i %p') AS InterviewTime,
                               i.Mode, i.Location, u.Username
                        FROM   InterviewSchedules i
                        LEFT JOIN Users u ON i.InterviewerID = u.UserID
                        WHERE  i.ApplicationID = @appId
                        ORDER  BY i.InterviewDate DESC
                        LIMIT  1";

                    using (MySqlCommand intCmd = new MySqlCommand(interviewQuery, conn))
                    {
                        intCmd.Parameters.AddWithValue("@appId", applicationID);
                        using (MySqlDataReader intReader = intCmd.ExecuteReader())
                        {
                            if (intReader.Read())
                            {
                                lblInterviewDate.Text = intReader.GetDateTime("InterviewDate")
                                                                 .ToString("MMMM dd, yyyy");
                                lblInterviewTime.Text = intReader["InterviewTime"]?.ToString() ?? "-";

                                string mode = intReader["Mode"]?.ToString() ?? "-";
                                string location = intReader["Location"]?.ToString() ?? "";
                                lblInterviewMode.Text = string.IsNullOrWhiteSpace(location)
                                                        ? mode
                                                        : mode + " — " + location;

                                lblInterviewInterviewer.Text = intReader["Username"]?.ToString() ?? "-";
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

                    // ── 11. Status history / HR notes ─────────────────────────────────────
                    string historyQuery = @"
                        SELECT Status, Remarks, ChangedBy, ChangedAt
                        FROM   ApplicationStatusHistory
                        WHERE  ApplicationID = @appId
                        ORDER  BY ChangedAt ASC";

                    using (MySqlCommand histCmd = new MySqlCommand(historyQuery, conn))
                    {
                        histCmd.Parameters.AddWithValue("@appId", applicationID);
                        using (MySqlDataReader histReader = histCmd.ExecuteReader())
                        {
                            var sb = new System.Text.StringBuilder();
                            bool hasHistory = false;

                            while (histReader.Read())
                            {
                                hasHistory = true;
                                string entryStatus = histReader.GetString("Status");
                                string changedAt = histReader.GetDateTime("ChangedAt")
                                                               .ToString("MMM dd, yyyy hh:mm tt");
                                string changedBy = histReader["ChangedBy"]?.ToString() ?? "";
                                string remarks = histReader["Remarks"]?.ToString() ?? "";

                                sb.AppendLine("[" + changedAt + "] " + entryStatus);
                                if (!string.IsNullOrWhiteSpace(remarks))
                                    sb.AppendLine("   Remarks: " + remarks);
                                if (!string.IsNullOrWhiteSpace(changedBy))
                                    sb.AppendLine("   By: " + changedBy);
                                sb.AppendLine();
                            }

                            txtHRNotes.Text = hasHistory
                                ? sb.ToString().TrimEnd()
                                : "Status: " + currentStatus + "\r\n"
                                + "Position: " + jobTitle + "\r\n"
                                + "Date Applied: " + dateApplied.ToString("MMMM dd, yyyy");
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