namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class Reports
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
            lblApplicantFilter = new Label();
            cmbApplicantFilter = new ComboBox();
            btnApplicantExport = new Button();
            btnBack = new Button();
            dgvApplicantReport = new DataGridView();
            tabReports = new TabControl();
            tabApplicantReport = new TabPage();
            tabInterviewReport = new TabPage();
            dgvInterviewsReport = new DataGridView();
            cmbInterviewsFilter = new ComboBox();
            btnInterviewExport = new Button();
            lblInterviewFilter = new Label();
            tabJobVacancyReport = new TabPage();
            dgvVacancyReport = new DataGridView();
            cmbVacancyFilter = new ComboBox();
            btnVacancyExport = new Button();
            lblVacancyFilter = new Label();
            tabReqReport = new TabPage();
            dgvReqReport = new DataGridView();
            cmbReqFilter = new ComboBox();
            btnReqExport = new Button();
            lblReqFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvApplicantReport).BeginInit();
            tabReports.SuspendLayout();
            tabApplicantReport.SuspendLayout();
            tabInterviewReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewsReport).BeginInit();
            tabJobVacancyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacancyReport).BeginInit();
            tabReqReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReqReport).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(22, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            // 
            // lblApplicantFilter
            // 
            lblApplicantFilter.AutoSize = true;
            lblApplicantFilter.Location = new Point(6, 9);
            lblApplicantFilter.Name = "lblApplicantFilter";
            lblApplicantFilter.Size = new Size(109, 20);
            lblApplicantFilter.TabIndex = 1;
            lblApplicantFilter.Text = "Filter by Status:";
            // 
            // cmbApplicantFilter
            // 
            cmbApplicantFilter.FormattingEnabled = true;
            cmbApplicantFilter.Items.AddRange(new object[] { "All", "Submitted", "Under Review", "For Interview", "Accepted", "Rejected" });
            cmbApplicantFilter.Location = new Point(121, 6);
            cmbApplicantFilter.Name = "cmbApplicantFilter";
            cmbApplicantFilter.Size = new Size(473, 28);
            cmbApplicantFilter.TabIndex = 2;
            cmbApplicantFilter.SelectedIndexChanged += cmbApplicantFilter_SelectedIndexChanged;
            // 
            // btnApplicantExport
            // 
            btnApplicantExport.Location = new Point(600, 5);
            btnApplicantExport.Name = "btnApplicantExport";
            btnApplicantExport.Size = new Size(123, 29);
            btnApplicantExport.TabIndex = 4;
            btnApplicantExport.Text = "Export to CSV";
            btnApplicantExport.UseVisualStyleBackColor = true;
            btnApplicantExport.Click += btnApplicantExport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(27, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvApplicantReport
            // 
            dgvApplicantReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvApplicantReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicantReport.Location = new Point(6, 39);
            dgvApplicantReport.Name = "dgvApplicantReport";
            dgvApplicantReport.ReadOnly = true;
            dgvApplicantReport.RowHeadersWidth = 51;
            dgvApplicantReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicantReport.Size = new Size(727, 275);
            dgvApplicantReport.TabIndex = 6;
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabApplicantReport);
            tabReports.Controls.Add(tabInterviewReport);
            tabReports.Controls.Add(tabJobVacancyReport);
            tabReports.Controls.Add(tabReqReport);
            tabReports.Location = new Point(23, 60);
            tabReports.Name = "tabReports";
            tabReports.SelectedIndex = 0;
            tabReports.Size = new Size(747, 353);
            tabReports.TabIndex = 7;
            // 
            // tabApplicantReport
            // 
            tabApplicantReport.Controls.Add(dgvApplicantReport);
            tabApplicantReport.Controls.Add(cmbApplicantFilter);
            tabApplicantReport.Controls.Add(btnApplicantExport);
            tabApplicantReport.Controls.Add(lblApplicantFilter);
            tabApplicantReport.Location = new Point(4, 29);
            tabApplicantReport.Name = "tabApplicantReport";
            tabApplicantReport.Padding = new Padding(3);
            tabApplicantReport.Size = new Size(739, 320);
            tabApplicantReport.TabIndex = 0;
            tabApplicantReport.Text = "Applicants";
            tabApplicantReport.UseVisualStyleBackColor = true;
            // 
            // tabInterviewReport
            // 
            tabInterviewReport.Controls.Add(dgvInterviewsReport);
            tabInterviewReport.Controls.Add(cmbInterviewsFilter);
            tabInterviewReport.Controls.Add(btnInterviewExport);
            tabInterviewReport.Controls.Add(lblInterviewFilter);
            tabInterviewReport.Location = new Point(4, 29);
            tabInterviewReport.Name = "tabInterviewReport";
            tabInterviewReport.Padding = new Padding(3);
            tabInterviewReport.Size = new Size(739, 320);
            tabInterviewReport.TabIndex = 1;
            tabInterviewReport.Text = "Interviews";
            tabInterviewReport.UseVisualStyleBackColor = true;
            // 
            // dgvInterviewsReport
            // 
            dgvInterviewsReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInterviewsReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterviewsReport.Location = new Point(6, 40);
            dgvInterviewsReport.Name = "dgvInterviewsReport";
            dgvInterviewsReport.ReadOnly = true;
            dgvInterviewsReport.RowHeadersWidth = 51;
            dgvInterviewsReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInterviewsReport.Size = new Size(727, 275);
            dgvInterviewsReport.TabIndex = 10;
            // 
            // cmbInterviewsFilter
            // 
            cmbInterviewsFilter.FormattingEnabled = true;
            cmbInterviewsFilter.Items.AddRange(new object[] { "", "All", "Scheduled", "", "Completed", "", "Cancelled" });
            cmbInterviewsFilter.Location = new Point(121, 7);
            cmbInterviewsFilter.Name = "cmbInterviewsFilter";
            cmbInterviewsFilter.Size = new Size(473, 28);
            cmbInterviewsFilter.TabIndex = 8;
            cmbInterviewsFilter.SelectedIndexChanged += cmbInterviewsFilter_SelectedIndexChanged;
            // 
            // btnInterviewExport
            // 
            btnInterviewExport.Location = new Point(600, 6);
            btnInterviewExport.Name = "btnInterviewExport";
            btnInterviewExport.Size = new Size(123, 29);
            btnInterviewExport.TabIndex = 9;
            btnInterviewExport.Text = "Export to CSV";
            btnInterviewExport.UseVisualStyleBackColor = true;
            btnInterviewExport.Click += btnInterviewExport_Click;
            // 
            // lblInterviewFilter
            // 
            lblInterviewFilter.AutoSize = true;
            lblInterviewFilter.Location = new Point(6, 10);
            lblInterviewFilter.Name = "lblInterviewFilter";
            lblInterviewFilter.Size = new Size(109, 20);
            lblInterviewFilter.TabIndex = 7;
            lblInterviewFilter.Text = "Filter by Status:";
            // 
            // tabJobVacancyReport
            // 
            tabJobVacancyReport.Controls.Add(dgvVacancyReport);
            tabJobVacancyReport.Controls.Add(cmbVacancyFilter);
            tabJobVacancyReport.Controls.Add(btnVacancyExport);
            tabJobVacancyReport.Controls.Add(lblVacancyFilter);
            tabJobVacancyReport.Location = new Point(4, 29);
            tabJobVacancyReport.Name = "tabJobVacancyReport";
            tabJobVacancyReport.Padding = new Padding(3);
            tabJobVacancyReport.Size = new Size(739, 320);
            tabJobVacancyReport.TabIndex = 2;
            tabJobVacancyReport.Text = "Job Vacancies";
            tabJobVacancyReport.UseVisualStyleBackColor = true;
            // 
            // dgvVacancyReport
            // 
            dgvVacancyReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVacancyReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacancyReport.Location = new Point(6, 40);
            dgvVacancyReport.Name = "dgvVacancyReport";
            dgvVacancyReport.ReadOnly = true;
            dgvVacancyReport.RowHeadersWidth = 51;
            dgvVacancyReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancyReport.Size = new Size(727, 275);
            dgvVacancyReport.TabIndex = 10;
            // 
            // cmbVacancyFilter
            // 
            cmbVacancyFilter.FormattingEnabled = true;
            cmbVacancyFilter.Items.AddRange(new object[] { "All", "Open", "Closed" });
            cmbVacancyFilter.Location = new Point(121, 7);
            cmbVacancyFilter.Name = "cmbVacancyFilter";
            cmbVacancyFilter.Size = new Size(473, 28);
            cmbVacancyFilter.TabIndex = 8;
            cmbVacancyFilter.SelectedIndexChanged += cmbVacancyFilter_SelectedIndexChanged;
            // 
            // btnVacancyExport
            // 
            btnVacancyExport.Location = new Point(600, 6);
            btnVacancyExport.Name = "btnVacancyExport";
            btnVacancyExport.Size = new Size(123, 29);
            btnVacancyExport.TabIndex = 9;
            btnVacancyExport.Text = "Export to CSV";
            btnVacancyExport.UseVisualStyleBackColor = true;
            btnVacancyExport.Click += btnVacancyExport_Click;
            // 
            // lblVacancyFilter
            // 
            lblVacancyFilter.AutoSize = true;
            lblVacancyFilter.Location = new Point(6, 10);
            lblVacancyFilter.Name = "lblVacancyFilter";
            lblVacancyFilter.Size = new Size(109, 20);
            lblVacancyFilter.TabIndex = 7;
            lblVacancyFilter.Text = "Filter by Status:";
            // 
            // tabReqReport
            // 
            tabReqReport.Controls.Add(dgvReqReport);
            tabReqReport.Controls.Add(cmbReqFilter);
            tabReqReport.Controls.Add(btnReqExport);
            tabReqReport.Controls.Add(lblReqFilter);
            tabReqReport.Location = new Point(4, 29);
            tabReqReport.Name = "tabReqReport";
            tabReqReport.Padding = new Padding(3);
            tabReqReport.Size = new Size(739, 320);
            tabReqReport.TabIndex = 3;
            tabReqReport.Text = "Missing Requirements";
            tabReqReport.UseVisualStyleBackColor = true;
            // 
            // dgvReqReport
            // 
            dgvReqReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReqReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReqReport.Location = new Point(6, 40);
            dgvReqReport.Name = "dgvReqReport";
            dgvReqReport.ReadOnly = true;
            dgvReqReport.RowHeadersWidth = 51;
            dgvReqReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReqReport.Size = new Size(727, 275);
            dgvReqReport.TabIndex = 10;
            // 
            // cmbReqFilter
            // 
            cmbReqFilter.FormattingEnabled = true;
            cmbReqFilter.Items.AddRange(new object[] { "All", "Incomplete", "Complete" });
            cmbReqFilter.Location = new Point(121, 7);
            cmbReqFilter.Name = "cmbReqFilter";
            cmbReqFilter.Size = new Size(473, 28);
            cmbReqFilter.TabIndex = 8;
            cmbReqFilter.SelectedIndexChanged += cmbReqFilter_SelectedIndexChanged;
            // 
            // btnReqExport
            // 
            btnReqExport.Location = new Point(600, 6);
            btnReqExport.Name = "btnReqExport";
            btnReqExport.Size = new Size(123, 29);
            btnReqExport.TabIndex = 9;
            btnReqExport.Text = "Export to CSV";
            btnReqExport.UseVisualStyleBackColor = true;
            btnReqExport.Click += btnReqExport_Click;
            // 
            // lblReqFilter
            // 
            lblReqFilter.AutoSize = true;
            lblReqFilter.Location = new Point(6, 10);
            lblReqFilter.Name = "lblReqFilter";
            lblReqFilter.Size = new Size(109, 20);
            lblReqFilter.TabIndex = 7;
            lblReqFilter.Text = "Filter by Status:";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(tabReports);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicantReport).EndInit();
            tabReports.ResumeLayout(false);
            tabApplicantReport.ResumeLayout(false);
            tabApplicantReport.PerformLayout();
            tabInterviewReport.ResumeLayout(false);
            tabInterviewReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewsReport).EndInit();
            tabJobVacancyReport.ResumeLayout(false);
            tabJobVacancyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVacancyReport).EndInit();
            tabReqReport.ResumeLayout(false);
            tabReqReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReqReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicantFilter;
        private ComboBox cmbApplicantFilter;
        private Button btnApplicantExport;
        private Button btnBack;
        private DataGridView dgvApplicantReport;
        private TabControl tabReports;
        private TabPage tabApplicantReport;
        private TabPage tabInterviewReport;
        private TabPage tabJobVacancyReport;
        private TabPage tabReqReport;
        private DataGridView dgvInterviewsReport;
        private ComboBox cmbInterviewsFilter;
        private Button btnInterviewExport;
        private Label lblInterviewFilter;
        private DataGridView dgvVacancyReport;
        private ComboBox cmbVacancyFilter;
        private Button btnVacancyExport;
        private Label lblVacancyFilter;
        private DataGridView dgvReqReport;
        private ComboBox cmbReqFilter;
        private Button btnReqExport;
        private Label lblReqFilter;
    }
}