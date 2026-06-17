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
                        query += " AND (JobTitle LIKE @search OR Qualifications LIKE @search)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchFilter))
                            cmd.Parameters.AddWithValue("@search", "%" + searchFilter + "%");

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
                Size = new Size(630, 50)
            };

            Button btnViewDetails = new Button
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(70, 130, 180),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(670, 35),
                Size = new Size(110, 35),
                Cursor = Cursors.Hand,
                Tag = jobId
            };
            btnViewDetails.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            btnViewDetails.Click += BtnViewDetails_Click;

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
            card.Controls.Add(btnViewDetails);
            card.Controls.Add(btnApply);

            flpJobsContainer.Controls.Add(card);
        }

        private void BtnViewDetails_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int jobId = Convert.ToInt32(btn.Tag);

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT j.JobTitle, j.Qualifications, d.DepartmentName, j.EmploymentType
                                     FROM JobVacancies j
                                     LEFT JOIN Departments d ON j.DepartmentID = d.DepartmentID
                                     WHERE j.JobVacancyID = @jid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@jid", jobId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string title = reader["JobTitle"]?.ToString() ?? "";
                                string qualifications = reader["Qualifications"]?.ToString() ?? "";
                                string department = reader["DepartmentName"]?.ToString() ?? "N/A";
                                string empType = reader["EmploymentType"]?.ToString() ?? "N/A";

                                Form detailForm = new Form
                                {
                                    Text = title,
                                    Size = new Size(520, 420),
                                    StartPosition = FormStartPosition.CenterParent,
                                    FormBorderStyle = FormBorderStyle.FixedDialog,
                                    MaximizeBox = false,
                                    MinimizeBox = false,
                                    BackColor = Color.White
                                };

                                Label lblDetailTitle = new Label
                                {
                                    Text = title,
                                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                                    Location = new Point(20, 20),
                                    AutoSize = true
                                };

                                Label lblDeptLabel = new Label { Text = "Department:", Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(20, 70), AutoSize = true };
                                Label lblDept = new Label { Text = department, Font = new Font("Segoe UI", 9F), Location = new Point(140, 70), AutoSize = true };

                                Label lblTypeLabel = new Label { Text = "Employment Type:", Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(20, 100), AutoSize = true };
                                Label lblType = new Label { Text = empType, Font = new Font("Segoe UI", 9F), Location = new Point(140, 100), AutoSize = true };

                                Label lblQualLabel = new Label { Text = "Qualifications:", Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(20, 140), AutoSize = true };

                                TextBox txtQual = new TextBox
                                {
                                    Text = qualifications,
                                    Multiline = true,
                                    ReadOnly = true,
                                    ScrollBars = ScrollBars.Vertical,
                                    Location = new Point(20, 165),
                                    Size = new Size(460, 160),
                                    BackColor = Color.FromArgb(247, 248, 250),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Font = new Font("Segoe UI", 9F)
                                };

                                Button btnClose = new Button
                                {
                                    Text = "Close",
                                    Location = new Point(370, 340),
                                    Size = new Size(110, 32),
                                    BackColor = Color.FromArgb(70, 130, 180),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Font = new Font("Segoe UI", 9F, FontStyle.Bold)
                                };
                                btnClose.Click += (s, ev) => detailForm.Close();

                                detailForm.Controls.Add(lblDetailTitle);
                                detailForm.Controls.Add(lblDeptLabel);
                                detailForm.Controls.Add(lblDept);
                                detailForm.Controls.Add(lblTypeLabel);
                                detailForm.Controls.Add(lblType);
                                detailForm.Controls.Add(lblQualLabel);
                                detailForm.Controls.Add(txtQual);
                                detailForm.Controls.Add(btnClose);

                                detailForm.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading job details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!btn.Enabled) return;
            btn.Enabled = false;
            int jobId = Convert.ToInt32(btn.Tag);

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string statusQuery = "SELECT Status FROM JobVacancies WHERE JobVacancyID = @jid";
                    using (MySqlCommand statusCmd = new MySqlCommand(statusQuery, conn))
                    {
                        statusCmd.Parameters.AddWithValue("@jid", jobId);
                        object result = statusCmd.ExecuteScalar();
                        string jobStatus = result?.ToString() ?? "";
                        if (jobStatus != "Open")
                        {
                            MessageBox.Show("This job vacancy is no longer open for applications.", "Job Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LoadJobVacancies();
                            return;
                        }
                    }

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

                    string activeQuery = @"SELECT j.JobTitle, a.Status
                                           FROM Applications a
                                           JOIN JobVacancies j ON a.JobID = j.JobVacancyID
                                           WHERE a.ApplicantAccountID = @uid
                                             AND a.Status NOT IN ('Rejected', 'Withdrawn')
                                           LIMIT 1";
                    using (MySqlCommand activeCmd = new MySqlCommand(activeQuery, conn))
                    {
                        activeCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        using (MySqlDataReader activeReader = activeCmd.ExecuteReader())
                        {
                            if (activeReader.Read())
                            {
                                string activeTitle = activeReader.GetString("JobTitle");
                                string activeStatus = activeReader.GetString("Status");

                                if (activeStatus == "Accepted")
                                {
                                    MessageBox.Show(
                                        "You have already been accepted for \"" + activeTitle + "\". You cannot apply to another job.",
                                        "Already Hired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "You already have an active application for \"" + activeTitle + "\" (Status: " + activeStatus + "). " +
                                        "You must wait until that application is resolved (Accepted, Rejected, or Withdrawn) before applying to a new job.",
                                        "Active Application Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                return;
                            }
                        }
                    }

                    int applicantId = 0;
                    string resolveQuery = "SELECT ApplicantID FROM Applicants WHERE ApplicantAccountID = @uid";
                    using (MySqlCommand resolveCmd = new MySqlCommand(resolveQuery, conn))
                    {
                        resolveCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        object resolveResult = resolveCmd.ExecuteScalar();
                        applicantId = resolveResult != null ? Convert.ToInt32(resolveResult) : 0;
                    }

                    if (applicantId == 0)
                    {
                        MessageBox.Show("Your profile record could not be found. Please open My Profile and save it once before applying.", "Profile Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insertQuery = "INSERT INTO Applications (ApplicantID, ApplicantAccountID, JobVacancyID, JobID, Status, DateApplied) " +
                                         "VALUES (@applicantId, @uid, @jid, @jid, 'Submitted', @date); SELECT LAST_INSERT_ID();";

                    int newApplicationId = 0;
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@applicantId", applicantId);
                        insertCmd.Parameters.AddWithValue("@uid", _applicantAccountID);
                        insertCmd.Parameters.AddWithValue("@jid", jobId);
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                        newApplicationId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    string historyQuery = "INSERT INTO ApplicationStatusHistory (ApplicationID, Status, Remarks, ChangedBy) " +
                                          "VALUES (@appId, 'Submitted', 'Application submitted by user.', 'Applicant')";
                    using (MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue("@appId", newApplicationId);
                        historyCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadJobVacancies();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("You have already submitted an application for this vacancy.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing application: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn.Enabled = true;
            }
        }
    }
}