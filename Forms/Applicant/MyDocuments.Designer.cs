namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class MyDocuments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlSummary = new System.Windows.Forms.Panel();
            lblSubmittedLabel = new System.Windows.Forms.Label();
            lblSubmittedCount = new System.Windows.Forms.Label();
            lblMissingLabel = new System.Windows.Forms.Label();
            lblMissingCount = new System.Windows.Forms.Label();
            lblStatusNote = new System.Windows.Forms.Label();
            lblPageTitle = new System.Windows.Forms.Label();
            lblDocumentListHeader = new System.Windows.Forms.Label();
            dgvDocuments = new System.Windows.Forms.DataGridView();
            colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDateSubmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlUploadSection = new System.Windows.Forms.Panel();
            lblSelectDocType = new System.Windows.Forms.Label();
            cmbDocumentType = new System.Windows.Forms.ComboBox();
            lblSelectedFile = new System.Windows.Forms.Label();
            txtSelectedFile = new System.Windows.Forms.TextBox();
            btnBrowse = new System.Windows.Forms.Button();
            lblRemarksInput = new System.Windows.Forms.Label();
            txtRemarks = new System.Windows.Forms.TextBox();
            btnUpload = new System.Windows.Forms.Button();
            btnReplace = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            pnlUploadSection.SuspendLayout();
            SuspendLayout();

            // lblPageTitle
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblPageTitle.Location = new System.Drawing.Point(40, 30);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(220, 50);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "My Documents";

            // pnlSummary
            pnlSummary.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblSubmittedLabel);
            pnlSummary.Controls.Add(lblSubmittedCount);
            pnlSummary.Controls.Add(lblMissingLabel);
            pnlSummary.Controls.Add(lblMissingCount);
            pnlSummary.Controls.Add(lblStatusNote);
            pnlSummary.Location = new System.Drawing.Point(40, 95);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new System.Drawing.Size(960, 62);
            pnlSummary.TabIndex = 1;

            // lblSubmittedLabel
            lblSubmittedLabel.AutoSize = true;
            lblSubmittedLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubmittedLabel.Location = new System.Drawing.Point(12, 10);
            lblSubmittedLabel.Name = "lblSubmittedLabel";
            lblSubmittedLabel.Size = new System.Drawing.Size(68, 20);
            lblSubmittedLabel.TabIndex = 0;
            lblSubmittedLabel.Text = "Submitted:";

            // lblSubmittedCount
            lblSubmittedCount.AutoSize = true;
            lblSubmittedCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSubmittedCount.ForeColor = System.Drawing.Color.Green;
            lblSubmittedCount.Location = new System.Drawing.Point(85, 10);
            lblSubmittedCount.Name = "lblSubmittedCount";
            lblSubmittedCount.Size = new System.Drawing.Size(16, 20);
            lblSubmittedCount.TabIndex = 1;
            lblSubmittedCount.Text = "0";

            // lblMissingLabel
            lblMissingLabel.AutoSize = true;
            lblMissingLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblMissingLabel.Location = new System.Drawing.Point(12, 34);
            lblMissingLabel.Name = "lblMissingLabel";
            lblMissingLabel.Size = new System.Drawing.Size(56, 20);
            lblMissingLabel.TabIndex = 2;
            lblMissingLabel.Text = "Missing:";

            // lblMissingCount
            lblMissingCount.AutoSize = true;
            lblMissingCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblMissingCount.ForeColor = System.Drawing.Color.Red;
            lblMissingCount.Location = new System.Drawing.Point(85, 34);
            lblMissingCount.Name = "lblMissingCount";
            lblMissingCount.Size = new System.Drawing.Size(16, 20);
            lblMissingCount.TabIndex = 3;
            lblMissingCount.Text = "0";

            // lblStatusNote
            lblStatusNote.AutoSize = true;
            lblStatusNote.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            lblStatusNote.ForeColor = System.Drawing.Color.DimGray;
            lblStatusNote.Location = new System.Drawing.Point(200, 20);
            lblStatusNote.Name = "lblStatusNote";
            lblStatusNote.Size = new System.Drawing.Size(420, 19);
            lblStatusNote.TabIndex = 4;
            lblStatusNote.Text = "Documents can only be uploaded or replaced before HR review starts.";

            // lblDocumentListHeader
            lblDocumentListHeader.AutoSize = true;
            lblDocumentListHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDocumentListHeader.Location = new System.Drawing.Point(40, 172);
            lblDocumentListHeader.Name = "lblDocumentListHeader";
            lblDocumentListHeader.Size = new System.Drawing.Size(105, 20);
            lblDocumentListHeader.TabIndex = 2;
            lblDocumentListHeader.Text = "Document List:";

            // dgvDocuments
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.AllowUserToDeleteRows = false;
            dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.BackgroundColor = System.Drawing.Color.White;
            dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colDocType, colFileName, colStatus, colRemarks, colDateSubmitted });
            dgvDocuments.Location = new System.Drawing.Point(40, 195);
            dgvDocuments.MultiSelect = false;
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowHeadersVisible = false;
            dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.Size = new System.Drawing.Size(960, 200);
            dgvDocuments.TabIndex = 3;

            // colDocType
            colDocType.HeaderText = "Document Type";
            colDocType.Name = "colDocType";
            colDocType.FillWeight = 20F;

            // colFileName
            colFileName.HeaderText = "File Name";
            colFileName.Name = "colFileName";
            colFileName.FillWeight = 25F;

            // colStatus
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 15F;

            // colRemarks
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            colRemarks.FillWeight = 25F;

            // colDateSubmitted
            colDateSubmitted.HeaderText = "Date Submitted";
            colDateSubmitted.Name = "colDateSubmitted";
            colDateSubmitted.FillWeight = 15F;

            // pnlUploadSection
            pnlUploadSection.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            pnlUploadSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUploadSection.Controls.Add(lblSelectDocType);
            pnlUploadSection.Controls.Add(cmbDocumentType);
            pnlUploadSection.Controls.Add(lblSelectedFile);
            pnlUploadSection.Controls.Add(txtSelectedFile);
            pnlUploadSection.Controls.Add(btnBrowse);
            pnlUploadSection.Controls.Add(lblRemarksInput);
            pnlUploadSection.Controls.Add(txtRemarks);
            pnlUploadSection.Controls.Add(btnUpload);
            pnlUploadSection.Controls.Add(btnReplace);
            pnlUploadSection.Controls.Add(btnClear);
            pnlUploadSection.Location = new System.Drawing.Point(40, 410);
            pnlUploadSection.Name = "pnlUploadSection";
            pnlUploadSection.Size = new System.Drawing.Size(960, 160);
            pnlUploadSection.TabIndex = 4;

            // lblSelectDocType
            lblSelectDocType.AutoSize = true;
            lblSelectDocType.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSelectDocType.Location = new System.Drawing.Point(12, 15);
            lblSelectDocType.Name = "lblSelectDocType";
            lblSelectDocType.Size = new System.Drawing.Size(108, 20);
            lblSelectDocType.TabIndex = 0;
            lblSelectDocType.Text = "Document Type:";

            // cmbDocumentType
            cmbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDocumentType.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbDocumentType.Location = new System.Drawing.Point(130, 12);
            cmbDocumentType.Name = "cmbDocumentType";
            cmbDocumentType.Size = new System.Drawing.Size(200, 28);
            cmbDocumentType.TabIndex = 1;

            // lblSelectedFile
            lblSelectedFile.AutoSize = true;
            lblSelectedFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSelectedFile.Location = new System.Drawing.Point(12, 52);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new System.Drawing.Size(80, 20);
            lblSelectedFile.TabIndex = 2;
            lblSelectedFile.Text = "Selected File:";

            // txtSelectedFile
            txtSelectedFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtSelectedFile.Location = new System.Drawing.Point(130, 49);
            txtSelectedFile.Name = "txtSelectedFile";
            txtSelectedFile.ReadOnly = true;
            txtSelectedFile.Size = new System.Drawing.Size(580, 27);
            txtSelectedFile.TabIndex = 3;

            // btnBrowse
            btnBrowse.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnBrowse.ForeColor = System.Drawing.Color.White;
            btnBrowse.Location = new System.Drawing.Point(720, 49);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(80, 27);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += new System.EventHandler(btnBrowse_Click);

            // lblRemarksInput
            lblRemarksInput.AutoSize = true;
            lblRemarksInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRemarksInput.Location = new System.Drawing.Point(12, 90);
            lblRemarksInput.Name = "lblRemarksInput";
            lblRemarksInput.Size = new System.Drawing.Size(63, 20);
            lblRemarksInput.TabIndex = 5;
            lblRemarksInput.Text = "Remarks:";

            // txtRemarks
            txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtRemarks.Location = new System.Drawing.Point(130, 87);
            txtRemarks.MaxLength = 200;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new System.Drawing.Size(670, 27);
            txtRemarks.TabIndex = 6;

            // btnUpload
            btnUpload.BackColor = System.Drawing.Color.FromArgb(31, 73, 125);
            btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnUpload.ForeColor = System.Drawing.Color.White;
            btnUpload.Location = new System.Drawing.Point(130, 124);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(100, 28);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += new System.EventHandler(btnUpload_Click);

            // btnReplace
            btnReplace.BackColor = System.Drawing.Color.FromArgb(180, 100, 30);
            btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReplace.FlatAppearance.BorderSize = 0;
            btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnReplace.ForeColor = System.Drawing.Color.White;
            btnReplace.Location = new System.Drawing.Point(240, 124);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(100, 28);
            btnReplace.TabIndex = 8;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = false;
            btnReplace.Click += new System.EventHandler(btnReplace_Click);

            // btnClear
            btnClear.BackColor = System.Drawing.Color.Gray;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(350, 124);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(80, 28);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += new System.EventHandler(btnClear_Click);

            // openFileDialog1
            openFileDialog1.Filter = "Allowed Files|*.pdf;*.jpg;*.jpeg;*.png;*.docx|PDF Files|*.pdf|Images|*.jpg;*.jpeg;*.png|Word Documents|*.docx";
            openFileDialog1.Title = "Select Document";

            // MyDocuments UserControl
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlSummary);
            Controls.Add(lblDocumentListHeader);
            Controls.Add(dgvDocuments);
            Controls.Add(pnlUploadSection);
            Name = "MyDocuments";
            Size = new System.Drawing.Size(1060, 715);

            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            pnlUploadSection.ResumeLayout(false);
            pnlUploadSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSubmittedLabel;
        private System.Windows.Forms.Label lblSubmittedCount;
        private System.Windows.Forms.Label lblMissingLabel;
        private System.Windows.Forms.Label lblMissingCount;
        private System.Windows.Forms.Label lblStatusNote;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDocumentListHeader;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSubmitted;
        private System.Windows.Forms.Panel pnlUploadSection;
        private System.Windows.Forms.Label lblSelectDocType;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblRemarksInput;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
