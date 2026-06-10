using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class HRDashboard : Form
    {
        public HRDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUserId = 0;
            Session.CurrentUsername = "";
            Session.CurrentRole = "";

            var main = new MainMenu();
            main.Show();
            this.Close();
        }

        private int GetCount(MySqlConnection conn, string query)
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void HRDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {Session.CurrentUsername}! ({Session.CurrentRole})";
            btnMaintenance.Visible = Session.CurrentRole == "Admin";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    lblTotalApplicants.Text = "Total Applicants: " + GetCount(conn, "SELECT COUNT(*) FROM Applicants");

                    lblPending.Text = "Pending Review: " + GetCount(conn, "SELECT COUNT(*) FROM Applications WHERE Status = 'Submitted'");

                    lblInterviews.Text = "Scheduled Interviews: " + GetCount(conn, "SELECT COUNT(*) FROM InterviewSchedules WHERE Status = 'Scheduled'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void btnApplicantList_Click(object sender, EventArgs e)
        {
            ApplicantList list = new ApplicantList();
            list.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void btnJobVacancy_Click(object sender, EventArgs e)
        {
            JobVacancyManagement jvm = new JobVacancyManagement();
            jvm.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance m = new Maintenance();
            m.Show();
        }
    }
}
