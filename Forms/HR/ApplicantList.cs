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

                    // linking Applicants table to ApplicantsAccounts to get the email
                    string query = @"SELECT a.ApplicantID, a.FirstName, a.LastName, 
                                     a.ContactNumber, aa.Email
                                     FROM Applicants a
                                     JOIN ApplicantAccounts aa 
                                     ON a.ApplicantAccountID = aa.ApplicantAccountID
                                     WHERE a.FirstName LIKE @search 
                                     OR a.LastName LIKE @search 
                                     OR aa.Email LIKE @search";

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

       
    }
}
