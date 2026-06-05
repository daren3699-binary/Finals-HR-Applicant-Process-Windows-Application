namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class JobVacancies
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            flpJobsContainer = new FlowLayoutPanel();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(40, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(298, 41);
            lblTitle.Text = "Available Vacancies";

            // txtSearch
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(40, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(350, 30);

            // btnSearch
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(405, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 32);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // flpJobsContainer
            flpJobsContainer.AutoScroll = true;
            flpJobsContainer.Location = new System.Drawing.Point(40, 150);
            flpJobsContainer.Name = "flpJobsContainer";
            flpJobsContainer.Size = new System.Drawing.Size(980, 520);

            // JobVacancies Configuration
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(flpJobsContainer);
            Name = "JobVacancies";
            Size = new System.Drawing.Size(1060, 715);
            Load += JobVacancies_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnSearch;
        private FlowLayoutPanel flpJobsContainer;
    }
}