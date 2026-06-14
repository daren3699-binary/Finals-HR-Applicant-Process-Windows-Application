using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class JobVacancies : UserControl
    {
        private int _applicantAccountID;

        public JobVacancies()
        {
            InitializeComponent();
        }

        public JobVacancies(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
        }

        private void JobVacancies_Load(object sender, EventArgs e)
        {
            LoadJobVacancies();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobVacancies(txtSearch.Text.Trim());
        }

        private void LoadJobVacancies(string searchFilter = "")
        {
            flpJobsContainer.Controls.Clear();

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT JobVacancyID, JobTitle, Qualifications FROM JobVacancies WHERE Status = 'Open'";
                    if (!string.IsNullOrEmpty(searchFilter))
                    {
                        query += " AND (JobTitle LIKE @search OR Qualifications LIKE @search)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchFilter))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchFilter + "%");
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int jobId = reader.GetInt32("JobVacancyID");
                                string title = reader.GetString("JobTitle");
                                string qualifications = reader.GetString("Qualifications");

                                CreateJobCard(jobId, title, qualifications);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vacancies: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateJobCard(int jobId, string title, string qualifications)
        {
            Panel card = new Panel
            {
                Size = new Size(940, 110),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 15)
            };

            Label lblJobTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            };

            Label lblJobDesc = new Label
            {
                Text = "Qualifications: " + qualifications,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(20, 45),
                Size = new Size(750, 50)
            };

            Button btnApply = new Button
            {
                Text = "Apply Now",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                BackColor = Color.FromArgb(70, 130, 180),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(800, 35),
                Size = new Size(120, 35),
                Cursor = Cursors.Hand,
                Tag = jobId
            };

            btnApply.Click += BtnApply_Click;
            card.Controls.Add(lblJobTitle);
            card.Controls.Add(lblJobDesc);
            card.Controls.Add(btnApply);

            flpJobsContainer.Controls.Add(card);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int jobId = Convert.ToInt32(btn.Tag);

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Applications WHERE ApplicantAccountID = @uid AND JobID = @jid";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        checkCmd.Parameters.AddWithValue("@jid", jobId);

                        long count = Convert.ToInt64(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("You have already submitted an application for this vacancy.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Applications (ApplicantAccountID, JobID, Status, DateApplied) " +
                                         "VALUES (@uid, @jid, 'Submitted', @date); SELEC    T LAST_INSERT_ID();";

                    int newApplicationId = 0;
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        insertCmd.Parameters.AddWithValue("@jid", jobId);
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                        newApplicationId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    string historyQuery = "INSERT INTO ApplicationStatusHistory (ApplicationID, Status, ChangeDate, Remarks) " +
                                          "VALUES (@appId, 'Submitted', @date, 'Application submitted by user.')";
                    using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue("@appId", newApplicationId);
                        historyCmd.Parameters.AddWithValue("@date", DateTime.Now);
                        historyCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobVacancies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing application: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}