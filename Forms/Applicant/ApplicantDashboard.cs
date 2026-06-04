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
        string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

        public ApplicantDashboard(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void ApplicantDashboard_Load(object sender, EventArgs e)
        {
            pnlHeader.BorderStyle = BorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            LoadApplicantName();
        }

        private void LoadApplicantName()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT FirstName FROM ApplicantAccounts WHERE ApplicantAccountID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _applicantAccountID);

                object result = cmd.ExecuteScalar();
                _applicantName = result != null ? result.ToString() : "User";
                lblWelcome.Text = "Hello, " + _applicantName + "!";
                btnProfileMenu.Text = _applicantName + "  v";

                conn.Close();
            }
            catch
            {
                _applicantName = "User";
                lblWelcome.Text = "Hello, User!";
            }

            ShowHome();
        }

        private void ShowHome()
        {
            pnlContent.Controls.Clear();

            string appStatus = "Pending";
            string dateApplied = "N/A";
            string position = "N/A";
            string missingReqs = "None";
            string interviewDate = "Not scheduled";
            string interviewLocation = "";

            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT a.Status, a.DateApplied, j.JobTitle, a.MissingRequirements, 
                                        a.InterviewDate, a.InterviewLocation
                                 FROM Applications a
                                 LEFT JOIN JobVacancies j ON a.JobID = j.JobID
                                 WHERE a.ApplicantAccountID = @id
                                 ORDER BY a.DateApplied DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _applicantAccountID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        appStatus = reader["Status"]?.ToString() ?? "Pending";
                        dateApplied = reader["DateApplied"] != DBNull.Value
                            ? Convert.ToDateTime(reader["DateApplied"]).ToString("MMMM dd, yyyy")
                            : "N/A";
                        position = reader["JobTitle"]?.ToString() ?? "N/A";
                        missingReqs = reader["MissingRequirements"]?.ToString() ?? "None";
                        if (string.IsNullOrWhiteSpace(missingReqs)) missingReqs = "None";
                        interviewDate = reader["InterviewDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["InterviewDate"]).ToString("MMMM dd, yyyy h:mm tt")
                            : "Not scheduled";
                        interviewLocation = reader["InterviewLocation"]?.ToString() ?? "";
                    }
                }

                conn.Close();
            }
            catch { }

            Label lblHello = new Label();
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHello.ForeColor = Color.FromArgb(30, 30, 30);
            lblHello.Location = new Point(40, 40);
            lblHello.Text = "Hello, " + _applicantName + "!";

            Label lblSub = new Label();
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.Gray;
            lblSub.Location = new Point(40, 85);
            lblSub.Text = "Here's an overview of your application.";

            Panel pnlLine = new Panel();
            pnlLine.BackColor = Color.FromArgb(220, 220, 220);
            pnlLine.Location = new Point(40, 118);
            pnlLine.Size = new Size(1000, 1);

            Color statusColor = appStatus == "Approved" ? Color.FromArgb(92, 184, 92)
                              : appStatus == "Rejected" ? Color.FromArgb(217, 83, 79)
                              : Color.FromArgb(255, 193, 7);

            Panel cardStatus = MakeCard("Application Status", appStatus, statusColor, 40, 135);
            Panel cardDate = MakeCard("Date Applied", dateApplied, Color.FromArgb(70, 130, 180), 310, 135);
            Panel cardPosition = MakeCard("Position Applied", position, Color.FromArgb(111, 66, 193), 580, 135);

            Color missingColor = missingReqs == "None" ? Color.FromArgb(92, 184, 92) : Color.FromArgb(217, 83, 79);
            Panel cardMissing = MakeCard("Missing Requirements", missingReqs, missingColor, 40, 285);

            string interviewDisplay = interviewDate;
            if (!string.IsNullOrWhiteSpace(interviewLocation) && interviewDate != "Not scheduled")
                interviewDisplay = interviewDate + "\n" + interviewLocation;

            Color interviewColor = interviewDate == "Not scheduled" ? Color.FromArgb(150, 150, 150) : Color.FromArgb(23, 162, 184);
            Panel cardInterview = MakeTallCard("Interview Schedule", interviewDisplay, interviewColor, 310, 285);

            Label lblActivity = new Label();
            lblActivity.AutoSize = true;
            lblActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActivity.ForeColor = Color.FromArgb(30, 30, 30);
            lblActivity.Location = new Point(40, 460);
            lblActivity.Text = "Recent Activity";

            Panel pnlActivity = new Panel();
            pnlActivity.Location = new Point(40, 492);
            pnlActivity.Size = new Size(1000, 100);
            pnlActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlActivity.BackColor = Color.White;

            Label lblActivityNote = new Label();
            lblActivityNote.AutoSize = true;
            lblActivityNote.Font = new Font("Segoe UI", 9F);
            lblActivityNote.ForeColor = Color.Gray;
            lblActivityNote.Location = new Point(15, 15);
            lblActivityNote.Text = dateApplied != "N/A"
                ? "Application submitted on " + dateApplied + " for " + position + "."
                : "No application submitted yet. Go to My Application to get started.";

            Label lblActivityNote2 = new Label();
            lblActivityNote2.AutoSize = true;
            lblActivityNote2.Font = new Font("Segoe UI", 9F);
            lblActivityNote2.ForeColor = Color.Gray;
            lblActivityNote2.Location = new Point(15, 45);
            lblActivityNote2.Text = "Current status: " + appStatus;

            pnlActivity.Controls.Add(lblActivityNote);
            pnlActivity.Controls.Add(lblActivityNote2);

            Label lblActions = new Label();
            lblActions.AutoSize = true;
            lblActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActions.ForeColor = Color.FromArgb(30, 30, 30);
            lblActions.Location = new Point(40, 615);
            lblActions.Text = "Quick Actions";

            Button btnGoApplication = MakeActionButton("View My Application", 40, 650);
            btnGoApplication.Click += (s, e) => btnMyApplication_Click(s, e);

            Button btnGoStatus = MakeActionButton("Check Application Status", 230, 650);
            btnGoStatus.Click += (s, e) => btnAppStatus_Click(s, e);

            Button btnGoJobs = MakeActionButton("Browse Job Vacancies", 440, 650);
            btnGoJobs.Click += (s, e) => btnJobVacancies_Click(s, e);

            pnlContent.Controls.Add(lblHello);
            pnlContent.Controls.Add(lblSub);
            pnlContent.Controls.Add(pnlLine);
            pnlContent.Controls.Add(cardStatus);
            pnlContent.Controls.Add(cardDate);
            pnlContent.Controls.Add(cardPosition);
            pnlContent.Controls.Add(cardMissing);
            pnlContent.Controls.Add(cardInterview);
            pnlContent.Controls.Add(lblActivity);
            pnlContent.Controls.Add(pnlActivity);
            pnlContent.Controls.Add(lblActions);
            pnlContent.Controls.Add(btnGoApplication);
            pnlContent.Controls.Add(btnGoStatus);
            pnlContent.Controls.Add(btnGoJobs);
        }

        private Panel MakeCard(string title, string value, Color accentColor, int x, int y)
        {
            Panel card = new Panel();
            card.Location = new Point(x, y);
            card.Size = new Size(240, 120);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            Panel accent = new Panel();
            accent.BackColor = accentColor;
            accent.Location = new Point(0, 0);
            accent.Size = new Size(6, 120);

            Label lblTitle = new Label();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(18, 18);
            lblTitle.Text = title.ToUpper();

            Label lblValue = new Label();
            lblValue.AutoSize = false;
            lblValue.Size = new Size(210, 60);
            lblValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblValue.Location = new Point(18, 45);
            lblValue.Text = value;

            card.Controls.Add(accent);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

        private Panel MakeTallCard(string title, string value, Color accentColor, int x, int y)
        {
            Panel card = new Panel();
            card.Location = new Point(x, y);
            card.Size = new Size(310, 120);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            Panel accent = new Panel();
            accent.BackColor = accentColor;
            accent.Location = new Point(0, 0);
            accent.Size = new Size(6, 120);

            Label lblTitle = new Label();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(18, 18);
            lblTitle.Text = title.ToUpper();

            Label lblValue = new Label();
            lblValue.AutoSize = false;
            lblValue.Size = new Size(280, 70);
            lblValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblValue.Location = new Point(18, 42);
            lblValue.Text = value;

            card.Controls.Add(accent);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

        private Button MakeActionButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(180, 38);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9F);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            btn.ForeColor = Color.FromArgb(70, 130, 180);
            btn.BackColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            return btn;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void btnAppStatus_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl.Location = new Point(40, 40);
            lbl.Text = "Application Status";
            pnlContent.Controls.Add(lbl);
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl.Location = new Point(40, 40);
            lbl.Text = "Job Vacancies";
            pnlContent.Controls.Add(lbl);
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl.Location = new Point(40, 40);
            lbl.Text = "My Application";
            pnlContent.Controls.Add(lbl);
        }

        private void btnMyDocuments_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl.Location = new Point(40, 40);
            lbl.Text = "My Documents";
            pnlContent.Controls.Add(lbl);
        }

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new Font("Segoe UI", 10F);

            ToolStripMenuItem itemProfile = new ToolStripMenuItem("My Profile");
            itemProfile.Click += (s, ev) =>
            {
                MyProfile profileForm = new MyProfile(_applicantAccountID);
                profileForm.ShowDialog();
            };

            ToolStripMenuItem itemLogout = new ToolStripMenuItem("Logout");
            itemLogout.ForeColor = Color.FromArgb(180, 50, 50);
            itemLogout.Click += (s, ev) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ApplicantLogin loginForm = new ApplicantLogin();
                    loginForm.Show();
                    this.Close();
                }
            };

            menu.Items.Add(itemProfile);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(itemLogout);

            menu.Show(btnProfileMenu, new Point(0, btnProfileMenu.Height));
        }

        private void lblSubWelcome_Click(object sender, EventArgs e)
        {
        }
    }
}