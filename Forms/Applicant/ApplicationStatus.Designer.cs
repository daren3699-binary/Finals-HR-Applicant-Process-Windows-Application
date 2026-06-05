namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class ApplicationStatus
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
            pnlTimelineTrack = new Panel();
            pnlStatus1 = new Panel();
            lblStep1Title = new Label();
            lblStep1Desc = new Label();
            pnlStatus2 = new Panel();
            lblStep2Title = new Label();
            lblStep2Desc = new Label();
            pnlStatus3 = new Panel();
            lblStep3Title = new Label();
            lblStep3Desc = new Label();
            pnlHRUpdates = new Panel();
            lblHRHeader = new Label();
            txtHRNotes = new TextBox();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(40, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Application Tracking";

            // pnlTimelineTrack
            pnlTimelineTrack.BackColor = Color.FromArgb(220, 220, 220);
            pnlTimelineTrack.Location = new System.Drawing.Point(65, 120);
            pnlTimelineTrack.Name = "pnlTimelineTrack";
            pnlTimelineTrack.Size = new System.Drawing.Size(4, 300);

            // pnlStatus1
            pnlStatus1.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus1.Location = new System.Drawing.Point(57, 130);
            pnlStatus1.Name = "pnlStatus1";
            pnlStatus1.Size = new System.Drawing.Size(20, 20);

            // lblStep1Title
            lblStep1Title.AutoSize = true;
            lblStep1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep1Title.Location = new System.Drawing.Point(95, 127);
            lblStep1Title.Name = "lblStep1Title";
            lblStep1Title.Text = "Application Submitted";

            // lblStep1Desc
            lblStep1Desc.AutoSize = true;
            lblStep1Desc.Font = new Font("Segoe UI", 9F);
            lblStep1Desc.ForeColor = Color.Gray;
            lblStep1Desc.Location = new System.Drawing.Point(95, 152);
            lblStep1Desc.Name = "lblStep1Desc";
            lblStep1Desc.Text = "No application submitted yet.";

            // pnlStatus2
            pnlStatus2.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus2.Location = new System.Drawing.Point(57, 230);
            pnlStatus2.Name = "pnlStatus2";
            pnlStatus2.Size = new System.Drawing.Size(20, 20);

            // lblStep2Title
            lblStep2Title.AutoSize = true;
            lblStep2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep2Title.Location = new System.Drawing.Point(95, 227);
            lblStep2Title.Name = "lblStep2Title";
            lblStep2Title.Text = "HR Initial Review";

            // lblStep2Desc
            lblStep2Desc.AutoSize = true;
            lblStep2Desc.Font = new Font("Segoe UI", 9F);
            lblStep2Desc.ForeColor = Color.Gray;
            lblStep2Desc.Location = new System.Drawing.Point(95, 252);
            lblStep2Desc.Name = "lblStep2Desc";
            lblStep2Desc.Text = "Pending submission.";

            // pnlStatus3
            pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus3.Location = new System.Drawing.Point(57, 330);
            pnlStatus3.Name = "pnlStatus3";
            pnlStatus3.Size = new System.Drawing.Size(20, 20);

            // lblStep3Title
            lblStep3Title.AutoSize = true;
            lblStep3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep3Title.Location = new System.Drawing.Point(95, 327);
            lblStep3Title.Name = "lblStep3Title";
            lblStep3Title.Text = "Interview Scheduling";

            // lblStep3Desc
            lblStep3Desc.AutoSize = true;
            lblStep3Desc.Font = new Font("Segoe UI", 9F);
            lblStep3Desc.ForeColor = Color.Gray;
            lblStep3Desc.Location = new System.Drawing.Point(95, 352);
            lblStep3Desc.Name = "lblStep3Desc";
            lblStep3Desc.Text = "Pending submission.";

            // pnlHRUpdates
            pnlHRUpdates.BackColor = Color.White;
            pnlHRUpdates.BorderStyle = BorderStyle.FixedSingle;
            pnlHRUpdates.Controls.Add(lblHRHeader);
            pnlHRUpdates.Controls.Add(txtHRNotes);
            pnlHRUpdates.Location = new System.Drawing.Point(550, 120);
            pnlHRUpdates.Name = "pnlHRUpdates";
            pnlHRUpdates.Size = new System.Drawing.Size(450, 250);

            // lblHRHeader
            lblHRHeader.AutoSize = true;
            lblHRHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHRHeader.Location = new System.Drawing.Point(20, 20);
            lblHRHeader.Name = "lblHRHeader";
            lblHRHeader.Text = "Official HR Updates & Remarks";

            // txtHRNotes
            txtHRNotes.BackColor = Color.FromArgb(250, 250, 250);
            txtHRNotes.BorderStyle = BorderStyle.None;
            txtHRNotes.Font = new Font("Segoe UI", 10F);
            txtHRNotes.Location = new System.Drawing.Point(20, 60);
            txtHRNotes.Multiline = true;
            txtHRNotes.ReadOnly = true;
            txtHRNotes.Size = new System.Drawing.Size(408, 165);
            txtHRNotes.Name = "txtHRNotes";
            txtHRNotes.Text = "";

            // ApplicationStatus UserControl Settings
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            Controls.Add(lblTitle);
            Controls.Add(pnlStatus1);
            Controls.Add(lblStep1Title);
            Controls.Add(lblStep1Desc);
            Controls.Add(pnlStatus2);
            Controls.Add(lblStep2Title);
            Controls.Add(lblStep2Desc);
            Controls.Add(pnlStatus3);
            Controls.Add(lblStep3Title);
            Controls.Add(lblStep3Desc);
            Controls.Add(pnlTimelineTrack);
            Controls.Add(pnlHRUpdates);
            Name = "ApplicationStatus";
            Size = new System.Drawing.Size(1060, 715);
            pnlHRUpdates.ResumeLayout(false);
            pnlHRUpdates.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Panel pnlTimelineTrack;
        private Panel pnlStatus1;
        private Label lblStep1Title;
        private Label lblStep1Desc;
        private Panel pnlStatus2;
        private Label lblStep2Title;
        private Label lblStep2Desc;
        private Panel pnlStatus3;
        private Label lblStep3Title;
        private Label lblStep3Desc;
        private Panel pnlHRUpdates;
        private Label lblHRHeader;
        private TextBox txtHRNotes;
    }
}