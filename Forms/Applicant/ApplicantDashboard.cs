using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicantDashboard : Form
    {
        private int _applicantAccountID;
        private string _applicantName;

        public ApplicantDashboard()
        {
            InitializeComponent();
        }

        public ApplicantDashboard(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void ApplicantDashboard_Load(object sender, EventArgs e)
        {
            pnlHeader.BorderStyle = BorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            LoadSidebarIcons();
            btnHome_Click(sender, e);
        }

        private void LoadSidebarIcons()
        {
            Color iconColor = Color.FromArgb(70, 70, 70);

            btnHome.Image = SidebarIcons.Home(iconColor);
            btnJobVacancies.Image = SidebarIcons.Briefcase(iconColor);
            btnMyApplication.Image = SidebarIcons.Document(iconColor);
            btnAppStatus.Image = SidebarIcons.Clipboard(iconColor);
            btnMyDocuments.Image = SidebarIcons.Folder(iconColor);
            btnViewProfile.Image = SidebarIcons.Person(iconColor);
            btnMyProfile.Image = SidebarIcons.Pencil(iconColor);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(lblSubWelcome);
            pnlContent.Controls.Add(pnlLine);
            pnlContent.Controls.Add(cardStatus);
            pnlContent.Controls.Add(cardDate);
            pnlContent.Controls.Add(cardPosition);
            pnlContent.Controls.Add(cardMissing);
            pnlContent.Controls.Add(cardInterview);
            pnlContent.Controls.Add(lblActivityHeader);
            pnlContent.Controls.Add(pnlActivity);
            pnlContent.Controls.Add(lblActionsHeader);
            pnlContent.Controls.Add(btnGoApplication);
            pnlContent.Controls.Add(btnGoStatus);
            pnlContent.Controls.Add(btnGoJobs);

            LoadApplicantNameAndStatus();
        }

        private void LoadApplicantNameAndStatus()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string nameQuery = "SELECT FirstName FROM Applicants WHERE ApplicantAccountID = @uid";
                    using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, conn))
                    {
                        nameCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        object nameResult = nameCmd.ExecuteScalar();
                        _applicantName = nameResult != null ? nameResult.ToString() : "User";
                    }

                    lblWelcome.Text = "Hello, " + _applicantName + "!";

                    string appQuery = @"SELECT a.ApplicationID, a.Status, a.DateApplied, j.JobTitle
                                        FROM Applications a
                                        JOIN JobVacancies j ON a.JobID = j.JobVacancyID
                                        WHERE a.ApplicantAccountID = @uid
                                        ORDER BY a.DateApplied DESC LIMIT 1";

                    int applicationID = 0;
                    string currentStatus = "";
                    string jobTitle = "";

                    using (MySqlCommand appCmd = new MySqlCommand(appQuery, conn))
                    {
                        appCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        using (MySqlDataReader reader = appCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationID = reader.GetInt32("ApplicationID");
                                currentStatus = reader.GetString("Status");
                                DateTime dateApplied = reader.GetDateTime("DateApplied");
                                jobTitle = reader.GetString("JobTitle");

                                lblValueStatus.Text = currentStatus;
                                lblValueDate.Text = dateApplied.ToString("MMMM dd, yyyy");
                                lblValuePosition.Text = jobTitle;

                                lblActivityNote.Text = "You have an active application for the " + jobTitle + " role.";
                                lblActivityNote2.Text = "Current status: " + currentStatus;

                                accentStatus.BackColor = GetStatusColor(currentStatus);
                            }
                            else
                            {
                                lblValueStatus.Text = "No Active Application";
                                lblValueDate.Text = "N/A";
                                lblValuePosition.Text = "N/A";
                                lblActivityNote.Text = "No application submitted yet. Go to Job Vacancies to get started.";
                                lblActivityNote2.Text = "Current status: Unsubmitted";
                                accentStatus.BackColor = Color.FromArgb(150, 150, 150);
                            }
                        }
                    }

                    if (applicationID > 0)
                    {
                        int totalRequired = 0;
                        int submitted = 0;

                        string countQuery = "SELECT COUNT(*) FROM RequirementTypes";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                            totalRequired = Convert.ToInt32(countCmd.ExecuteScalar());

                        string submittedQuery = "SELECT COUNT(*) FROM ApplicantDocuments WHERE ApplicationID = @appId AND Status = 'Submitted'";
                        using (MySqlCommand submittedCmd = new MySqlCommand(submittedQuery, conn))
                        {
                            submittedCmd.Parameters.AddWithValue("@appId", applicationID);
                            submitted = Convert.ToInt32(submittedCmd.ExecuteScalar());
                        }

                        int missing = totalRequired - submitted;
                        lblValueMissing.Text = missing < 0 ? "0" : missing.ToString();

                        string interviewQuery = @"SELECT InterviewDate, DATE_FORMAT(InterviewDate, '%h:%i %p') AS InterviewTime, Mode, Location
                                                  FROM InterviewSchedules
                                                  WHERE ApplicationID = @appId
                                                  ORDER BY InterviewDate DESC LIMIT 1";

                        using (MySqlCommand intCmd = new MySqlCommand(interviewQuery, conn))
                        {
                            intCmd.Parameters.AddWithValue("@appId", applicationID);
                            using (MySqlDataReader intReader = intCmd.ExecuteReader())
                            {
                                if (intReader.Read())
                                {
                                    string date = intReader.GetDateTime("InterviewDate").ToString("MMM dd, yyyy");
                                    string time = intReader["InterviewTime"]?.ToString() ?? "";
                                    string mode = intReader["Mode"]?.ToString() ?? "";
                                    string location = intReader["Location"]?.ToString() ?? "";
                                    string details = date + (string.IsNullOrWhiteSpace(time) ? "" : " " + time) + (string.IsNullOrWhiteSpace(mode) ? "" : " | " + mode);
                                    if (!string.IsNullOrWhiteSpace(location))
                                        details += " | " + location;
                                    lblValueInterview.Text = details;
                                }
                                else
                                {
                                    lblValueInterview.Text = "No interview scheduled.";
                                }
                            }
                        }
                    }
                    else
                    {
                        lblValueMissing.Text = "0";
                        lblValueInterview.Text = "No interview scheduled.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblValueStatus.Text = "Database Disconnected";
                lblValueDate.Text = "N/A";
                lblValuePosition.Text = "N/A";
                lblValueMissing.Text = "N/A";
                lblValueInterview.Text = "N/A";
                lblActivityNote.Text = "Error connecting to storage: " + ex.Message;
                lblActivityNote2.Text = "Current status: Offline";
                accentStatus.BackColor = Color.Maroon;
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Submitted": return Color.FromArgb(70, 130, 180);
                case "Under Review": return Color.FromArgb(255, 193, 7);
                case "Shortlisted": return Color.FromArgb(100, 180, 100);
                case "For Interview": return Color.FromArgb(55, 138, 221);
                case "For Assessment": return Color.FromArgb(150, 100, 200);
                case "For Final Review": return Color.FromArgb(255, 160, 50);
                case "Accepted": return Color.FromArgb(92, 184, 92);
                case "Rejected": return Color.FromArgb(180, 50, 50);
                case "Withdrawn": return Color.FromArgb(150, 150, 150);
                default: return Color.FromArgb(150, 150, 150);
            }
        }

        private void btnAppStatus_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ApplicationStatus appStatusControl = new ApplicationStatus(_applicantAccountID);
            pnlContent.Controls.Add(appStatusControl);
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            JobVacancies jobsControl = new JobVacancies(_applicantAccountID);
            pnlContent.Controls.Add(jobsControl);
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            MyApplication myApp = new MyApplication(_applicantAccountID);
            myApp.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(myApp);
        }

        private void btnMyDocuments_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            MyDocuments myDocs = new MyDocuments(_applicantAccountID);
            pnlContent.Controls.Add(myDocs);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            using (EditMyProfile profileForm = new EditMyProfile(_applicantAccountID))
            {
                profileForm.ShowDialog();
            }

            LoadApplicantNameAndStatus();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ViewProfile viewProfile = new ViewProfile(_applicantAccountID);
            viewProfile.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(viewProfile);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.ClearSession();
                new ApplicantLogin().Show();
                this.Close();
            }
        }

        private void lblSubWelcome_Click(object sender, EventArgs e) { }
    }
}