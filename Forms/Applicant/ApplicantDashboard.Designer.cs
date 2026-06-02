namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class ApplicantDashboard
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
            lblStatus = new Label();
            lblStatusValue = new Label();
            lblMissingDocs = new Label();
            lstMissingDocs = new ListBox();
            lblInterview = new Label();
            lblInterviewValue = new Label();
            pnlSeparator1 = new Panel();
            pnlSeparator2 = new Panel();
            SuspendLayout();
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Applicant Dashboard";
            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(20, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "APPLICATION STATUS";
            // lblStatusValue
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI", 12F);
            lblStatusValue.ForeColor = Color.SteelBlue;
            lblStatusValue.Location = new Point(20, 95);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Text = "Loading...";
            // pnlSeparator1
            pnlSeparator1.BackColor = Color.LightGray;
            pnlSeparator1.Location = new Point(20, 130);
            pnlSeparator1.Name = "pnlSeparator1";
            pnlSeparator1.Size = new Size(440, 2);
            // lblMissingDocs
            lblMissingDocs.AutoSize = true;
            lblMissingDocs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMissingDocs.ForeColor = Color.Gray;
            lblMissingDocs.Location = new Point(20, 145);
            lblMissingDocs.Name = "lblMissingDocs";
            lblMissingDocs.Text = "MISSING DOCUMENTS";
            // lstMissingDocs
            lstMissingDocs.Location = new Point(20, 170);
            lstMissingDocs.Name = "lstMissingDocs";
            lstMissingDocs.Size = new Size(440, 120);
            // pnlSeparator2
            pnlSeparator2.BackColor = Color.LightGray;
            pnlSeparator2.Location = new Point(20, 305);
            pnlSeparator2.Name = "pnlSeparator2";
            pnlSeparator2.Size = new Size(440, 2);
            // lblInterview
            lblInterview.AutoSize = true;
            lblInterview.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInterview.ForeColor = Color.Gray;
            lblInterview.Location = new Point(20, 320);
            lblInterview.Name = "lblInterview";
            lblInterview.Text = "INTERVIEW SCHEDULE";
            // lblInterviewValue
            lblInterviewValue.AutoSize = true;
            lblInterviewValue.Font = new Font("Segoe UI", 10F);
            lblInterviewValue.Location = new Point(20, 345);
            lblInterviewValue.Name = "lblInterviewValue";
            lblInterviewValue.Text = "Loading...";
            // ApplicantDashboard
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 420);
            Controls.Add(lblTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusValue);
            Controls.Add(pnlSeparator1);
            Controls.Add(lblMissingDocs);
            Controls.Add(lstMissingDocs);
            Controls.Add(pnlSeparator2);
            Controls.Add(lblInterview);
            Controls.Add(lblInterviewValue);
            Name = "ApplicantDashboard";
            Text = "Applicant Dashboard";
            Load += ApplicantDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblStatus;
        private Label lblStatusValue;
        private Label lblMissingDocs;
        private ListBox lstMissingDocs;
        private Label lblInterview;
        private Label lblInterviewValue;
        private Panel pnlSeparator1;
        private Panel pnlSeparator2;
    }
}