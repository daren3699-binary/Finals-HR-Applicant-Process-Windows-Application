using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class HRLogin : Form
    {
        public HRLogin()
        {
            InitializeComponent();
        }

        private void btnHRLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT u.UserID, u.Username, r.RoleName
                                     FROM Users u
                                     JOIN Roles r ON u.RoleID = r.RoleID
                                     WHERE u.Username = @Username
                                     AND u.PasswordHash = @Password
                                     AND u.IsActive = 1";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32("UserID");
                                string uname = reader.GetString("Username");
                                string role = reader.GetString("RoleName");

                                //Store session info
                                Session.CurrentUserId = userId;
                                Session.CurrentUsername = uname;
                                Session.CurrentRole = role;

                                MessageBox.Show($"Welcome, {uname}! Role: {role}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                HRDashboard dashboard = new HRDashboard();
                                dashboard.Show();
                                this.Hide();

                                // TODO: Route based on role
                                // if (roleName == "Admin" || roleName == "HR Manager")
                                // {
                                //     HRDashboard dashboard = new HRDashboard(userId, roleName);
                                //     dashboard.Show();
                                //     this.Hide();
                                // }
                                // else if (roleName == "HR Staff")
                                // {
                                //     HRSDashboard dashboard = new HRDashboard(userId, roleName);
                                //     dashboard.Show();
                                //     this.Hide();
                                // }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
