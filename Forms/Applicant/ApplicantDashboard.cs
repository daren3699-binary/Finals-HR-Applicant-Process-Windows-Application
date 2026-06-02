using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicantDashboard : Form
    {
        private int _applicantAccountID;
        string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

        public ApplicantDashboard(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void ApplicantDashboard_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadMissingDocuments();
            LoadInterviewSchedule();
        }

        private void LoadStatus()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT Status FROM Applications WHERE ApplicantAccountID = @id ORDER BY DateApplied DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _applicantAccountID);

                object result = cmd.ExecuteScalar();
                lblStatusValue.Text = result != null ? result.ToString() : "No application yet";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading status: " + ex.Message);
            }
        }

        private void LoadMissingDocuments()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT rt.RequirementName FROM RequirementTypes rt " +
                               "WHERE rt.RequirementTypeID NOT IN (" +
                               "SELECT ad.RequirementTypeID FROM ApplicantDocuments ad " +
                               "WHERE ad.ApplicantAccountID = @id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _applicantAccountID);

                MySqlDataReader reader = cmd.ExecuteReader();
                lstMissingDocs.Items.Clear();

                while (reader.Read())
                {
                    lstMissingDocs.Items.Add(reader["RequirementName"].ToString());
                }

                if (lstMissingDocs.Items.Count == 0)
                {
                    lstMissingDocs.Items.Add("No missing documents");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }

        private void LoadInterviewSchedule()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT InterviewDate, InterviewTime, Mode, Location FROM InterviewSchedules " +
                               "WHERE ApplicantAccountID = @id AND Status = 'Scheduled' ORDER BY InterviewDate ASC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _applicantAccountID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblInterviewValue.Text = reader["InterviewDate"].ToString() + " " +
                                            reader["InterviewTime"].ToString() + " - " +
                                            reader["Mode"].ToString() + " at " +
                                            reader["Location"].ToString();
                }
                else
                {
                    lblInterviewValue.Text = "No interview scheduled";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview: " + ex.Message);
            }
        }
    }
}