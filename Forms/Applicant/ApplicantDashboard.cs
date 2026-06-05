using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicantDashboard : Form
    {
        private int _applicantAccountID;
        private string _applicantName;
        private string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

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
            btnHome_Click(sender, e);
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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string nameQuery = "SELECT FirstName FROM Applicants WHERE ApplicantAccountID = @uid"; using (MySqlCommand nameCmd = new MySqlCommand(nameQuery, conn))
                    {
                        nameCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        object nameResult = nameCmd.ExecuteScalar();
                        _applicantName = nameResult != null ? nameResult.ToString() : "User";
                    }

                    lblWelcome.Text = "Hello, " + _applicantName + "!";
                    btnProfileMenu.Text = _applicantName + "  v";

                    string appQuery = @"SELECT a.Status, a.DateApplied, j.JobTitle 
                                        FROM Applications a 
                                        JOIN JobVacancies j ON a.JobID = j.JobID 
                                        WHERE a.ApplicantAccountID = @uid 
                                        ORDER BY a.DateApplied DESC LIMIT 1";

                    using (MySqlCommand appCmd = new MySqlCommand(appQuery, conn))
                    {
                        appCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        using (MySqlDataReader reader = appCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string currentStatus = reader.GetString("Status");
                                DateTime dateApplied = reader.GetDateTime("DateApplied");
                                string jobTitle = reader.GetString("JobTitle");

                                lblValueStatus.Text = currentStatus;
                                lblValueDate.Text = dateApplied.ToString("MMMM dd, yyyy");
                                lblValuePosition.Text = jobTitle;

                                lblActivityNote.Text = "You have an active application for the " + jobTitle + " role.";
                                lblActivityNote2.Text = "Current status: " + currentStatus;

                                if (currentStatus == "Submitted")
                                    accentStatus.BackColor = Color.FromArgb(70, 130, 180);
                                else if (currentStatus == "Under Review")
                                    accentStatus.BackColor = Color.FromArgb(255, 193, 7);
                                else if (currentStatus == "Accepted")
                                    accentStatus.BackColor = Color.FromArgb(92, 184, 92);
                                else if (currentStatus == "Rejected")
                                    accentStatus.BackColor = Color.FromArgb(180, 50, 50);
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
                }
            }
            catch (Exception ex)
            {
                lblValueStatus.Text = "Database Disconnected";
                lblValueDate.Text = "N/A";
                lblValuePosition.Text = "N/A";
                lblActivityNote.Text = "Error connecting to storage: " + ex.Message;
                lblActivityNote2.Text = "Current status: Offline";
                accentStatus.BackColor = Color.Maroon;
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

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 10F);

            ToolStripMenuItem itemProfile = new ToolStripMenuItem("My Profile");
            itemProfile.Click += (s, ev) => { new MyProfile(_applicantAccountID).ShowDialog(); };

            ToolStripMenuItem itemLogout = new ToolStripMenuItem("Logout");
            itemLogout.ForeColor = Color.FromArgb(180, 50, 50);
            itemLogout.Click += (s, ev) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SessionManager.ClearSession();
                    new ApplicantLogin().Show();
                    this.Close();
                }
            };

            menu.Items.Add(itemProfile);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(itemLogout);
            menu.Show(btnProfileMenu, new Point(0, btnProfileMenu.Height));
        }

        private void lblSubWelcome_Click(object sender, EventArgs e) { }
    }
}