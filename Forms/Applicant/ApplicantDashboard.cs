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

                conn.Close();
            }
            catch (Exception ex)
            {
                lblWelcome.Text = "Hello, User!";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void ShowHome()
        {
            pnlContent.Controls.Clear();

            Label welcome = new Label();
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            welcome.ForeColor = Color.FromArgb(0, 102, 204);
            welcome.Location = new Point(40, 60);
            welcome.Text = "Hello, " + _applicantName + "!";

            Label sub = new Label();
            sub.AutoSize = true;
            sub.Font = new Font("Segoe UI", 12F);
            sub.ForeColor = Color.Gray;
            sub.Location = new Point(40, 110);
            sub.Text = "Welcome to the HR Applicant Portal. Use the menu on the left to navigate.";

            pnlContent.Controls.Add(welcome);
            pnlContent.Controls.Add(sub);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ApplicantLogin loginForm = new ApplicantLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void lblSubWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}