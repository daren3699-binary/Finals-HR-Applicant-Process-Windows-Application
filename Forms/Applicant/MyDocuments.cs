using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class MyDocuments : UserControl
    {
        private int _applicantAccountID;
        private int _applicationID;
        private bool _editingAllowed = true;
        private string _selectedFilePath = "";

        public MyDocuments(int applicantAccountID)
        {
            InitializeComponent();
            _applicantAccountID = applicantAccountID;
            this.Dock = DockStyle.Fill;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDocumentTypes();
            ResolveApplicationID();
            CheckApplicationStatus();
            LoadDocuments();
        }

        private void ResolveApplicationID()
        {
            string query = @"SELECT ApplicationID FROM Applications
                             WHERE ApplicantAccountID = @id
                             ORDER BY DateApplied DESC LIMIT 1";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _applicantAccountID);
                    object result = cmd.ExecuteScalar();
                    _applicationID = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch { _applicationID = 0; }
        }

        private void LoadDocumentTypes()
        {
            cmbDocumentType.Items.Clear();
            string query = "SELECT RequirementTypeID, RequirementName FROM RequirementTypes ORDER BY RequirementName";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDocumentType.Items.Add(new ComboItem(
                                reader.GetInt32("RequirementTypeID"),
                                reader.GetString("RequirementName")
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading document types: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckApplicationStatus()
        {
            if (_applicationID <= 0)
            {
                _editingAllowed = false;
                SetUploadControlsEnabled(false);
                lblStatusNote.Text = "No active application found.";
                return;
            }

            string query = "SELECT Status FROM Applications WHERE ApplicationID = @AppID";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string status = result.ToString();
                        _editingAllowed = (status == "Draft" || status == "Submitted");

                        if (!_editingAllowed)
                        {
                            SetUploadControlsEnabled(false);
                            lblStatusNote.Text = "Documents are locked. Application status: " + status;
                            lblStatusNote.ForeColor = Color.Crimson;
                        }
                        else
                        {
                            lblStatusNote.Text = "You may upload or replace documents. Status: " + status;
                            lblStatusNote.ForeColor = Color.DimGray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking application status: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDocuments()
        {
            dgvDocuments.Rows.Clear();

            if (_applicationID <= 0)
            {
                lblSubmittedCount.Text = "0";
                lblMissingCount.Text = "0";
                return;
            }

            int totalRequired = 0;
            string countQuery = "SELECT COUNT(*) FROM RequirementTypes";

            string query = @"SELECT rt.RequirementName, ad.FilePath, ad.Status, ad.Remarks,
                                    ad.UploadedAt
                             FROM RequirementTypes rt
                             LEFT JOIN ApplicantDocuments ad
                                    ON ad.RequirementTypeID = rt.RequirementTypeID AND ad.ApplicationID = @AppID
                             ORDER BY rt.RequirementName";

            int submittedCount = 0;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    totalRequired = Convert.ToInt32(countCmd.ExecuteScalar());

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool hasDocument = !reader.IsDBNull(reader.GetOrdinal("Status"));
                            string docStatus = hasDocument ? reader.GetString("Status") : "Missing";
                            string filePath = hasDocument && !reader.IsDBNull(reader.GetOrdinal("FilePath")) ? reader.GetString("FilePath") : "Not submitted";
                            string remarks = reader.IsDBNull(reader.GetOrdinal("Remarks")) ? "" : reader.GetString("Remarks");
                            string dateStr = reader.IsDBNull(reader.GetOrdinal("UploadedAt")) ? ""
                                : reader.GetDateTime("UploadedAt").ToString("MM/dd/yyyy");

                            int rowIndex = dgvDocuments.Rows.Add(
                                reader.GetString("RequirementName"),
                                filePath,
                                docStatus,
                                remarks,
                                dateStr
                            );

                            if (docStatus == "Submitted")
                            {
                                dgvDocuments.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                                submittedCount++;
                            }
                            else if (docStatus == "Missing")
                            {
                                dgvDocuments.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Crimson;
                            }
                        }
                    }
                }

                lblSubmittedCount.Text = submittedCount.ToString();
                int missingCount = totalRequired - submittedCount;
                lblMissingCount.Text = missingCount < 0 ? "0" : missingCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePath = openFileDialog1.FileName;
                txtSelectedFile.Text = System.IO.Path.GetFileName(_selectedFilePath);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!_editingAllowed)
            {
                MessageBox.Show("Uploading is not allowed. Your application is already under review.",
                    "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            ComboItem selectedType = (ComboItem)cmbDocumentType.SelectedItem;

            if (DocumentTypeAlreadyExists(selectedType.Id))
            {
                MessageBox.Show("A document of this type already exists.\n\nUse Replace to update it.",
                    "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"INSERT INTO ApplicantDocuments
                                (ApplicationID, RequirementTypeID, FilePath, Status, Remarks, UploadedAt)
                             VALUES
                                (@AppID, @TypeID, @FilePath, 'Submitted', @Remarks, NOW())";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    cmd.Parameters.AddWithValue("@TypeID", selectedType.Id);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.ExecuteNonQuery();
                    AuditLogger.Log("Applicant", _applicantAccountID, $"Uploaded document: {selectedType.Name}", "ApplicantDocuments", _applicationID);
                }

                MessageBox.Show("Document uploaded successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading document: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!_editingAllowed)
            {
                MessageBox.Show("Replacing is not allowed. Your application is already under review.",
                    "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            ComboItem selectedType = (ComboItem)cmbDocumentType.SelectedItem;

            if (!DocumentTypeAlreadyExists(selectedType.Id))
            {
                MessageBox.Show("No existing record for this document type.\n\nUse Upload to add it.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"UPDATE ApplicantDocuments
                             SET FilePath = @FilePath, Status = 'Submitted', Remarks = @Remarks, UploadedAt = NOW()
                             WHERE ApplicationID = @AppID AND RequirementTypeID = @TypeID";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    cmd.Parameters.AddWithValue("@TypeID", selectedType.Id);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.ExecuteNonQuery();
                    AuditLogger.Log("Applicant", _applicantAccountID, $"Replaced document: {selectedType.Name}", "ApplicantDocuments", _applicationID);
                }

                MessageBox.Show("Document replaced successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error replacing document: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private bool ValidateInputs()
        {
            if (cmbDocumentType.SelectedItem == null)
            {
                MessageBox.Show("Please select a document type.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDocumentType.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                MessageBox.Show("Please browse and select a file.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBrowse.Focus();
                return false;
            }
            if (!System.IO.File.Exists(_selectedFilePath))
            {
                MessageBox.Show("The selected file no longer exists. Please browse again.",
                    "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _selectedFilePath = "";
                txtSelectedFile.Text = "";
                return false;
            }
            return true;
        }

        private bool DocumentTypeAlreadyExists(int requirementTypeID)
        {
            string query = @"SELECT COUNT(*) FROM ApplicantDocuments
                             WHERE ApplicationID = @AppID AND RequirementTypeID = @TypeID";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    cmd.Parameters.AddWithValue("@TypeID", requirementTypeID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch { return false; }
        }

        private void SetUploadControlsEnabled(bool enabled)
        {
            cmbDocumentType.Enabled = enabled;
            txtSelectedFile.Enabled = enabled;
            btnBrowse.Enabled = enabled;
            txtRemarks.Enabled = enabled;
            btnUpload.Enabled = enabled;
            btnReplace.Enabled = enabled;
        }

        private void ClearInputs()
        {
            cmbDocumentType.SelectedIndex = -1;
            txtSelectedFile.Text = "";
            txtRemarks.Text = "";
            _selectedFilePath = "";
        }

        private class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ComboItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() { return Name; }
        }
    }
}