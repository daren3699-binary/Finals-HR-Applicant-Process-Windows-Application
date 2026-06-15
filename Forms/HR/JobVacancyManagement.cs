using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class JobVacancyManagement : Form
    {
        private int _selectedJobID = -1;
        private bool _isEditMode = false;
        public JobVacancyManagement()
        {
            InitializeComponent();
        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            dgvVacancies.Size = new Size(1050, 280);
            LoadDepartments();
            LoadVacancies();
        }

        private void LoadDepartments()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT DepartmentID, DepartmentName FROM Departments", conn);
                    var reader = cmd.ExecuteReader();
                    cmbDepartment.Items.Clear();
                    while (reader.Read())
                    {
                        cmbDepartment.Items.Add(new
                        {
                            ID = reader.GetInt32("DepartmentID"),
                            Name = reader.GetString("DepartmentName")
                        });
                    }
                    cmbDepartment.DisplayMember = "Name";
                    cmbDepartment.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }

        private void LoadVacancies()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT j.JobVacancyID, j.JobTitle, d.DepartmentName, 
                                     j.EmploymentType, j.Status, j.CreatedAt
                                     FROM JobVacancies j
                                     LEFT JOIN Departments d ON j.DepartmentID = d.DepartmentID
                                     ORDER BY j.CreatedAt DESC";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvVacancies.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vacancies: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtJobTitle.Text = "";
            txtDescription.Text = "";
            txtQualifications.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbEmploymentType.SelectedIndex = -1;
            _selectedJobID = -1;
            _isEditMode = false;
            pnlForm.Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            _isEditMode = false;
            pnlForm.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.CurrentRow == null)
            {
                MessageBox.Show("Please select a vacancy to edit.");
                return;
            }

            _selectedJobID = Convert.ToInt32(dgvVacancies.CurrentRow.Cells["JobVacancyID"].Value);
            _isEditMode = true;
            pnlForm.Visible = true;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM JobVacancies WHERE JobVacancyID = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _selectedJobID);
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtJobTitle.Text = reader["JobTitle"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            txtQualifications.Text = reader["Qualifications"].ToString();
                            cmbEmploymentType.SelectedItem = reader["EmploymentType"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vacancy: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Job title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // gets selected DepartmentID
                    dynamic selectedDept = cmbDepartment.SelectedItem;
                    int deptID = selectedDept != null ? selectedDept.ID : 0;

                    string query;
                    if (_isEditMode)
                    {
                        query = @"UPDATE JobVacancies SET 
                                  JobTitle=@title, DepartmentID=@dept,
                                  Description=@desc, Qualifications=@qual,
                                  EmploymentType=@emptype
                                  WHERE JobVacancyID=@id";
                    }
                    else
                    {
                        query = @"INSERT INTO JobVacancies 
                                  (JobTitle, DepartmentID, Description, Qualifications, EmploymentType, Status)
                                  VALUES (@title, @dept, @desc, @qual, @emptype, 'Open')";
                    }

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtJobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", deptID);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@qual", txtQualifications.Text.Trim());
                        cmd.Parameters.AddWithValue("@emptype", cmbEmploymentType.SelectedItem?.ToString() ?? "");
                        if (_isEditMode) cmd.Parameters.AddWithValue("@id", _selectedJobID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(_isEditMode ? "Vacancy updated!" : "Vacancy added!", "Success");
                ClearForm();
                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving: {ex.Message}");
            }
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.CurrentRow == null)
            {
                MessageBox.Show("Please select a vacancy.");
                return;
            }

            int jobID = Convert.ToInt32(dgvVacancies.CurrentRow.Cells["JobVacancyID"].Value);
            string currentStatus = dgvVacancies.CurrentRow.Cells["Status"].Value.ToString();
            string newStatus = currentStatus == "Open" ? "Closed" : "Open";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE JobVacancies SET Status=@status WHERE JobVacancyID=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", jobID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Vacancy marked as {newStatus}.");
                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewApplicants_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vacancy first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jobId = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["JobVacancyID"].Value);
            string jobTitle = dgvVacancies.SelectedRows[0].Cells["JobTitle"].Value.ToString();

            dgvVacancies.Size = new Size(620, 280);
            LoadJobApplicants(jobId, jobTitle);
            pnlApplicants.Visible = true;
        }

        private void LoadJobApplicants(int jobId, string jobTitle)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT
                                     CONCAT(a.FirstName, ' ', a.LastName) AS ApplicantName,
                                     aa.Email,
                                     ap.Status,
                                     ap.SubmittedAt
                                    FROM Applications ap
                                    INNER JOIN Applicants a ON ap.ApplicantID = a.ApplicantID
                                    INNER JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                                    WHERE ap.JobVacancyID = @jobId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@jobId", jobId);
                        var adapter = new MySqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);
                        dgvJobApplicants.DataSource = table;
                        lblApplicantsHeader.Text = $"Applicants for: {jobTitle}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }

        private void ToggleButtons(bool enabled)
        {
            btnAddNew.Enabled = enabled;
            btnEdit.Enabled = enabled;
            btnOpenClose.Enabled = enabled;
            btnViewApplicants.Enabled = enabled;
            dgvVacancies.Enabled = enabled;
            if (!enabled)
            {
                pnlApplicants.Visible = false;
                dgvVacancies.Size = new Size(1050, 280);
            }
        }

        private void btnCloseApplicants_Click(object sender, EventArgs e)
        {
            pnlApplicants.Visible = false;
            dgvVacancies.Size = new Size(1050, 280);
        }

        private void dgvVacancies_SelectionChanged(object sender, EventArgs e)
        {
            if (!pnlApplicants.Visible) return;
            if (dgvVacancies.SelectedRows.Count == 0) return;

            int jobId = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["JobVacancyID"].Value);
            string jobTitle = dgvVacancies.SelectedRows[0].Cells["JobTitle"].Value.ToString();
            LoadJobApplicants(jobId, jobTitle);
        }
    }
}
