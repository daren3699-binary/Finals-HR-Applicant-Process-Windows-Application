namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class ApplicantReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblStatus = new Label();
            lblRemarks = new Label();
            cmbStatus = new ComboBox();
            txtRemarks = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            btnScreen = new Button();
            btnSchedule = new Button();
            btnEvaluate = new Button();
            btnDecide = new Button();
            pnlOtherForms = new Panel();
            label1 = new Label();
            lblAppliedJobs = new Label();
            dgvAppliedJobs = new DataGridView();
            dgvDocuments = new DataGridView();
            lblApplicantDocuments = new Label();
            pnlOtherForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppliedJobs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(466, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Applicant Review";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F);
            lblName.Location = new Point(279, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F);
            lblEmail.Location = new Point(279, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F);
            lblStatus.Location = new Point(279, 459);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(151, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Application Status:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.2F);
            lblRemarks.Location = new Point(279, 506);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(83, 23);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks: ";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Submitted", "Under Review", "For Interview", "Hired", "Rejected" });
            cmbStatus.Location = new Point(436, 453);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(417, 28);
            cmbStatus.TabIndex = 5;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(436, 505);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(417, 40);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(591, 560);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnScreen
            // 
            btnScreen.Location = new Point(12, 102);
            btnScreen.Name = "btnScreen";
            btnScreen.Size = new Size(200, 29);
            btnScreen.TabIndex = 9;
            btnScreen.Text = "Screen Applicant";
            btnScreen.UseVisualStyleBackColor = true;
            btnScreen.Click += btnScreen_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(12, 163);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(200, 29);
            btnSchedule.TabIndex = 10;
            btnSchedule.Text = "Schedule Interview";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(12, 229);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(200, 29);
            btnEvaluate.TabIndex = 11;
            btnEvaluate.Text = "Interview Evaluation";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // btnDecide
            // 
            btnDecide.Location = new Point(12, 290);
            btnDecide.Name = "btnDecide";
            btnDecide.Size = new Size(200, 29);
            btnDecide.TabIndex = 12;
            btnDecide.Text = "Hiring Decision";
            btnDecide.UseVisualStyleBackColor = true;
            btnDecide.Click += btnDecide_Click;
            // 
            // pnlOtherForms
            // 
            pnlOtherForms.BorderStyle = BorderStyle.FixedSingle;
            pnlOtherForms.Controls.Add(label1);
            pnlOtherForms.Controls.Add(btnScreen);
            pnlOtherForms.Controls.Add(btnBack);
            pnlOtherForms.Controls.Add(btnDecide);
            pnlOtherForms.Controls.Add(btnSchedule);
            pnlOtherForms.Controls.Add(btnEvaluate);
            pnlOtherForms.Dock = DockStyle.Left;
            pnlOtherForms.Location = new Point(0, 0);
            pnlOtherForms.Name = "pnlOtherForms";
            pnlOtherForms.Size = new Size(225, 621);
            pnlOtherForms.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 42);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 13;
            label1.Text = "HR Panel";
            // 
            // lblAppliedJobs
            // 
            lblAppliedJobs.AutoSize = true;
            lblAppliedJobs.Font = new Font("Segoe UI", 10.2F);
            lblAppliedJobs.Location = new Point(279, 141);
            lblAppliedJobs.Name = "lblAppliedJobs";
            lblAppliedJobs.Size = new Size(178, 23);
            lblAppliedJobs.TabIndex = 14;
            lblAppliedJobs.Text = "Applied Job Vacancies";
            // 
            // dgvAppliedJobs
            // 
            dgvAppliedJobs.AllowUserToAddRows = false;
            dgvAppliedJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppliedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppliedJobs.Location = new Point(279, 164);
            dgvAppliedJobs.Name = "dgvAppliedJobs";
            dgvAppliedJobs.ReadOnly = true;
            dgvAppliedJobs.RowHeadersWidth = 51;
            dgvAppliedJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppliedJobs.Size = new Size(574, 126);
            dgvAppliedJobs.TabIndex = 15;
            // 
            // dgvDocuments
            // 
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(279, 321);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.Size = new Size(574, 126);
            dgvDocuments.TabIndex = 17;
            // 
            // lblApplicantDocuments
            // 
            lblApplicantDocuments.AutoSize = true;
            lblApplicantDocuments.Font = new Font("Segoe UI", 10.2F);
            lblApplicantDocuments.Location = new Point(279, 298);
            lblApplicantDocuments.Name = "lblApplicantDocuments";
            lblApplicantDocuments.Size = new Size(101, 23);
            lblApplicantDocuments.TabIndex = 16;
            lblApplicantDocuments.Text = "Documents:";
            // 
            // ApplicantReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 621);
            Controls.Add(dgvDocuments);
            Controls.Add(lblApplicantDocuments);
            Controls.Add(dgvAppliedJobs);
            Controls.Add(lblAppliedJobs);
            Controls.Add(pnlOtherForms);
            Controls.Add(btnSave);
            Controls.Add(txtRemarks);
            Controls.Add(cmbStatus);
            Controls.Add(lblRemarks);
            Controls.Add(lblStatus);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "ApplicantReview";
            Text = "Applicant Review";
            Load += ApplicantReview_Load;
            pnlOtherForms.ResumeLayout(false);
            pnlOtherForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppliedJobs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblEmail;
        private Label lblStatus;
        private Label lblRemarks;
        private ComboBox cmbStatus;
        private TextBox txtRemarks;
        private Button btnSave;
        private Button btnBack;
        private Button btnScreen;
        private Button btnSchedule;
        private Button btnEvaluate;
        private Button btnDecide;
        private Panel pnlOtherForms;
        private Label label1;
        private Label lblAppliedJobs;
        private DataGridView dgvAppliedJobs;
        private DataGridView dgvDocuments;
        private Label lblApplicantDocuments;
    }
}