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
    public partial class ApplicantList : Form
    {
        public ApplicantList()
        {
            InitializeComponent();
        }
        // Loads automatically when the form is opened
        private void ApplicantList_Load(object sender, EventArgs e)
        {
            LoadApplicants("");
        }
        // Loads the applicants from the database and filtered by search keyword
        private void LoadApplicants(string search)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();


                    string query = @"SELECT
                                        ap.ApplicationID,
                                        a.ApplicantID,
                                        CONCAT(a.FirstName, ' ', a.LastName) AS ApplicantName,
                                        aa.Email,
                                        j.JobTitle,
                                        ap.Status,
                                        ap.SubmittedAt
                                    FROM Applications ap
                                    INNER JOIN Applicants a
                                        ON ap.ApplicantID = a.ApplicantID
                                    INNER JOIN ApplicantAccounts aa
                                        ON a.ApplicantAccountID = aa.ApplicantAccountID
                                    INNER JOIN JobVacancies j
                                        ON ap.JobVacancyID = j.JobVacancyID
                                    WHERE
                                        a.FirstName LIKE @search
                                        OR a.LastName LIKE @search
                                        OR aa.Email LIKE @search
                                        OR j.JobTitle LIKE @search
                                    ORDER BY ap.CreatedAt DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // %search% = "contains" the keyword anywhere
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        // DataAdapter fills a DataTable, which we bind to the grid
                        var adapter = new MySqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        // Binding the table to the grid displays the rows automatically
                        dgvApplicants.DataSource = table;
                        dgvApplicants.Columns["ApplicationID"].Visible = false;
                        dgvApplicants.Columns["ApplicantID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadApplicants("");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvApplicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // prevents crash if user clicks the header row
            {   
                // gets the applicant id from the clicked row
                int applicantId = Convert.ToInt32(dgvApplicants.Rows[e.RowIndex].Cells["ApplicantID"].Value);
                ApplicantReview review = new ApplicantReview(applicantId);
                review.Show();
            }
        }
    }
}
