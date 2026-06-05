using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class MyDocuments : UserControl
    {
        private int _applicantAccountID;
        private int _applicationID;
        private bool _editingAllowed = true;
        private string _selectedFilePath = "";

        string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

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

        // ------------------------------------------------------------------
        // Resolve the most recent ApplicationID for this applicant
        // ------------------------------------------------------------------
        private void ResolveApplicationID()
        {
            string query = @"SELECT ApplicationID FROM Applications
                             WHERE ApplicantAccountID = @id
                             ORDER BY DateApplied DESC LIMIT 1";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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

        // ------------------------------------------------------------------
        // Populate Document Type dropdown from RequirementTypes table
        // ------------------------------------------------------------------
        private void LoadDocumentTypes()
        {
            cmbDocumentType.Items.Clear();
            string query = "SELECT RequirementTypeID, TypeName FROM RequirementTypes ORDER BY TypeName";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDocumentType.Items.Add(new ComboItem(
                                reader.GetInt32("RequirementTypeID"),
                                reader.GetString("TypeName")
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

        // ------------------------------------------------------------------
        // Check application status - lock controls if HR review has started
        // ------------------------------------------------------------------
        private void CheckApplicationStatus()
        {
            if (_applicationID <= 0)
            {
                _editingAllowed = false;
                SetUploadControlsEnabled(false);
                lblStatusNote.Text = "No active application found.";
                return;
            }

            string query = "SELECT CurrentStatus FROM Applications WHERE ApplicationID = @AppID";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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

        // ------------------------------------------------------------------
        // Load document grid
        // ------------------------------------------------------------------
        private void LoadDocuments()
        {
            dgvDocuments.Rows.Clear();

            if (_applicationID <= 0) return;

            string query = @"SELECT rt.TypeName, ad.FileName, ad.DocumentStatus,
                                    ad.Remarks, ad.DateSubmitted
                             FROM ApplicantDocuments ad
                             JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID
                             WHERE ad.ApplicationID = @AppID
                             ORDER BY rt.TypeName";

            int submittedCount = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string docStatus = reader.GetString("DocumentStatus");
                            string remarks = reader.IsDBNull(reader.GetOrdinal("Remarks")) ? "" : reader.GetString("Remarks");
                            string dateStr = reader.IsDBNull(reader.GetOrdinal("DateSubmitted")) ? ""
                                : reader.GetDateTime("DateSubmitted").ToString("MM/dd/yyyy");

                            int rowIndex = dgvDocuments.Rows.Add(
                                reader.GetString("TypeName"),
                                reader.GetString("FileName"),
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
                lblMissingCount.Text = (dgvDocuments.Rows.Count - submittedCount).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------------------------------------------
        // Browse for a file
        // ------------------------------------------------------------------
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePath = openFileDialog1.FileName;
                txtSelectedFile.Text = System.IO.Path.GetFileName(_selectedFilePath);
            }
        }

        // ------------------------------------------------------------------
        // Upload new document
        // ------------------------------------------------------------------
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

            string fileName = System.IO.Path.GetFileName(_selectedFilePath);
            string query = @"INSERT INTO ApplicantDocuments
                                (ApplicationID, RequirementTypeID, FileName, FilePath, DocumentStatus, Remarks, DateSubmitted)
                             VALUES
                                (@AppID, @TypeID, @FileName, @FilePath, 'Submitted', @Remarks, NOW())";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    cmd.Parameters.AddWithValue("@TypeID", selectedType.Id);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.ExecuteNonQuery();
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

        // ------------------------------------------------------------------
        // Replace existing document
        // ------------------------------------------------------------------
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

            string fileName = System.IO.Path.GetFileName(_selectedFilePath);
            string query = @"UPDATE ApplicantDocuments
                             SET FileName = @FileName, FilePath = @FilePath,
                                 DocumentStatus = 'Submitted', Remarks = @Remarks, DateSubmitted = NOW()
                             WHERE ApplicationID = @AppID AND RequirementTypeID = @TypeID";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);
                    cmd.Parameters.AddWithValue("@TypeID", selectedType.Id);
                    cmd.ExecuteNonQuery();
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

        // ------------------------------------------------------------------
        // Helpers
        // ------------------------------------------------------------------
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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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
