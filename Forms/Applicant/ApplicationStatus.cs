using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicationStatus : UserControl
    {
        private int _applicantAccountID;
        private string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT a.Status, a.DateApplied, j.JobTitle 
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
                                string status = reader.GetString("Status");
                                DateTime dateApplied = reader.GetDateTime("DateApplied");
                                string jobTitle = reader.GetString("JobTitle");

                                // Step 1 always green if there is an application
                                pnlStatus1.BackColor = Color.FromArgb(92, 184, 92);
                                lblStep1Desc.Text = "Submitted on " + dateApplied.ToString("MMMM dd, yyyy") + " for " + jobTitle + ".";

                                // Step 2
                                if (status == "Under Review" || status == "Accepted" || status == "Rejected")
                                {
                                    pnlStatus2.BackColor = Color.FromArgb(92, 184, 92);
                                    lblStep2Desc.Text = "HR has reviewed your application.";
                                }
                                else
                                {
                                    pnlStatus2.BackColor = Color.FromArgb(255, 193, 7);
                                    lblStep2Desc.Text = "Human Resources is currently evaluating your qualifications.";
                                }

                                // Step 3
                                if (status == "Accepted")
                                {
                                    pnlStatus3.BackColor = Color.FromArgb(92, 184, 92);
                                    lblStep3Desc.Text = "You have been scheduled for an interview. Check HR updates.";
                                }
                                else if (status == "Rejected")
                                {
                                    pnlStatus3.BackColor = Color.FromArgb(180, 50, 50);
                                    lblStep3Desc.Text = "Your application was not moved forward at this time.";
                                }
                                else
                                {
                                    pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);
                                    lblStep3Desc.Text = "Pending previous validation stages.";
                                }

                                txtHRNotes.Text = "Status: " + status + "\r\nPosition: " + jobTitle + "\r\nDate Applied: " + dateApplied.ToString("MMMM dd, yyyy");
                            }
                            else
                            {
                                // No application at all
                                pnlStatus1.BackColor = Color.FromArgb(220, 220, 220);
                                pnlStatus2.BackColor = Color.FromArgb(220, 220, 220);
                                pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);

                                lblStep1Desc.Text = "No application submitted yet.";
                                lblStep2Desc.Text = "Pending submission.";
                                lblStep3Desc.Text = "Pending submission.";

                                txtHRNotes.Text = "You have not submitted an application yet.\r\nGo to Job Vacancies to apply.";
                            }
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