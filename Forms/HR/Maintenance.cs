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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadRequirementTypes();
        }

        // Departments
        private void LoadDepartments()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentName";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvDepartments.DataSource = table;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            string name = txtDeptName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a department name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Departments (DepartmentName) VALUES (@name)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtDeptName.Text = "";
                LoadDepartments();
                MessageBox.Show("Department added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow == null)
            {
                MessageBox.Show("Please select a department to delete.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvDepartments.CurrentRow.Cells["DepartmentID"].Value);
            string name = dgvDepartments.CurrentRow.Cells["DepartmentName"].Value.ToString();

            var confirm = MessageBox.Show($"Delete '{name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Departments WHERE DepartmentID = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDepartments();
                MessageBox.Show("Department deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete — this department may be in use by a job vacancy.\n" + ex.Message);
            }
        }
        // Requirement types
        private void LoadRequirementTypes()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT RequirementTypeID, RequirementName FROM RequirementTypes ORDER BY RequirementName";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvRequirements.DataSource = table;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAddReq_Click(object sender, EventArgs e)
        {
            string name = txtReqName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a requirement type name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO RequirementTypes (RequirementName) VALUES (@name)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtReqName.Text = "";
                LoadRequirementTypes();
                MessageBox.Show("Requirement type added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteReq_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.CurrentRow == null)
            {
                MessageBox.Show("Please select a requirement type to delete.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvRequirements.CurrentRow.Cells["RequirementTypeID"].Value);
            string name = dgvRequirements.CurrentRow.Cells["RequirementName"].Value.ToString();

            var confirm = MessageBox.Show($"Delete '{name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM RequirementTypes WHERE RequirementTypeID = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadRequirementTypes();
                MessageBox.Show("Requirement type deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete — this type may be in use by an applicant document.\n" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
