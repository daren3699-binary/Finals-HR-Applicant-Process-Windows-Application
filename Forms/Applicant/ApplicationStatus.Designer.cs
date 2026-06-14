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

            pnlStatus4 = new Panel();
            lblStep4Title = new Label();
            lblStep4Desc = new Label();

            pnlStatus5 = new Panel();
            lblStep5Title = new Label();
            lblStep5Desc = new Label();

            pnlStatus6 = new Panel();
            lblStep6Title = new Label();
            lblStep6Desc = new Label();

            pnlInterviewDetails = new Panel();
            lblInterviewHeader = new Label();
            lblInterviewDateLabel = new Label();
            lblInterviewDate = new Label();
            lblInterviewTimeLabel = new Label();
            lblInterviewTime = new Label();
            lblInterviewInterviewerLabel = new Label();
            lblInterviewInterviewer = new Label();
            lblInterviewModeLabel = new Label();
            lblInterviewMode = new Label();

            pnlHRUpdates = new Panel();
            lblHRHeader = new Label();
            txtHRNotes = new TextBox();

            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(40, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Application Tracking";

            pnlTimelineTrack.BackColor = Color.FromArgb(220, 220, 220);
            pnlTimelineTrack.Location = new System.Drawing.Point(65, 120);
            pnlTimelineTrack.Name = "pnlTimelineTrack";
            pnlTimelineTrack.Size = new System.Drawing.Size(4, 520);

            pnlStatus1.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus1.Location = new System.Drawing.Point(57, 130);
            pnlStatus1.Name = "pnlStatus1";
            pnlStatus1.Size = new System.Drawing.Size(20, 20);

            lblStep1Title.AutoSize = true;
            lblStep1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep1Title.Location = new System.Drawing.Point(95, 127);
            lblStep1Title.Name = "lblStep1Title";
            lblStep1Title.Text = "Application Submitted";

            lblStep1Desc.AutoSize = true;
            lblStep1Desc.Font = new Font("Segoe UI", 9F);
            lblStep1Desc.ForeColor = Color.Gray;
            lblStep1Desc.Location = new System.Drawing.Point(95, 152);
            lblStep1Desc.Name = "lblStep1Desc";
            lblStep1Desc.Text = "No application submitted yet.";

            pnlStatus2.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus2.Location = new System.Drawing.Point(57, 210);
            pnlStatus2.Name = "pnlStatus2";
            pnlStatus2.Size = new System.Drawing.Size(20, 20);

            lblStep2Title.AutoSize = true;
            lblStep2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep2Title.Location = new System.Drawing.Point(95, 207);
            lblStep2Title.Name = "lblStep2Title";
            lblStep2Title.Text = "HR Initial Review";

            lblStep2Desc.AutoSize = true;
            lblStep2Desc.Font = new Font("Segoe UI", 9F);
            lblStep2Desc.ForeColor = Color.Gray;
            lblStep2Desc.Location = new System.Drawing.Point(95, 232);
            lblStep2Desc.Name = "lblStep2Desc";
            lblStep2Desc.Text = "Pending submission.";

            pnlStatus3.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus3.Location = new System.Drawing.Point(57, 290);
            pnlStatus3.Name = "pnlStatus3";
            pnlStatus3.Size = new System.Drawing.Size(20, 20);

            lblStep3Title.AutoSize = true;
            lblStep3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep3Title.Location = new System.Drawing.Point(95, 287);
            lblStep3Title.Name = "lblStep3Title";
            lblStep3Title.Text = "Shortlisted";

            lblStep3Desc.AutoSize = true;
            lblStep3Desc.Font = new Font("Segoe UI", 9F);
            lblStep3Desc.ForeColor = Color.Gray;
            lblStep3Desc.Location = new System.Drawing.Point(95, 312);
            lblStep3Desc.Name = "lblStep3Desc";
            lblStep3Desc.Text = "Pending review.";

            pnlStatus4.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus4.Location = new System.Drawing.Point(57, 370);
            pnlStatus4.Name = "pnlStatus4";
            pnlStatus4.Size = new System.Drawing.Size(20, 20);

            lblStep4Title.AutoSize = true;
            lblStep4Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep4Title.Location = new System.Drawing.Point(95, 367);
            lblStep4Title.Name = "lblStep4Title";
            lblStep4Title.Text = "Interview Scheduling";

            lblStep4Desc.AutoSize = true;
            lblStep4Desc.Font = new Font("Segoe UI", 9F);
            lblStep4Desc.ForeColor = Color.Gray;
            lblStep4Desc.Location = new System.Drawing.Point(95, 392);
            lblStep4Desc.Name = "lblStep4Desc";
            lblStep4Desc.Text = "Pending interview scheduling.";

            pnlStatus5.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus5.Location = new System.Drawing.Point(57, 450);
            pnlStatus5.Name = "pnlStatus5";
            pnlStatus5.Size = new System.Drawing.Size(20, 20);

            lblStep5Title.AutoSize = true;
            lblStep5Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep5Title.Location = new System.Drawing.Point(95, 447);
            lblStep5Title.Name = "lblStep5Title";
            lblStep5Title.Text = "Assessment";

            lblStep5Desc.AutoSize = true;
            lblStep5Desc.Font = new Font("Segoe UI", 9F);
            lblStep5Desc.ForeColor = Color.Gray;
            lblStep5Desc.Location = new System.Drawing.Point(95, 472);
            lblStep5Desc.Name = "lblStep5Desc";
            lblStep5Desc.Text = "Pending assessment.";

            pnlStatus6.BackColor = Color.FromArgb(220, 220, 220);
            pnlStatus6.Location = new System.Drawing.Point(57, 530);
            pnlStatus6.Name = "pnlStatus6";
            pnlStatus6.Size = new System.Drawing.Size(20, 20);

            lblStep6Title.AutoSize = true;
            lblStep6Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStep6Title.Location = new System.Drawing.Point(95, 527);
            lblStep6Title.Name = "lblStep6Title";
            lblStep6Title.Text = "Final Decision";

            lblStep6Desc.AutoSize = true;
            lblStep6Desc.Font = new Font("Segoe UI", 9F);
            lblStep6Desc.ForeColor = Color.Gray;
            lblStep6Desc.Location = new System.Drawing.Point(95, 552);
            lblStep6Desc.Name = "lblStep6Desc";
            lblStep6Desc.Text = "Not yet determined.";

            pnlInterviewDetails.BackColor = Color.White;
            pnlInterviewDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlInterviewDetails.Location = new System.Drawing.Point(550, 120);
            pnlInterviewDetails.Name = "pnlInterviewDetails";
            pnlInterviewDetails.Size = new System.Drawing.Size(460, 170);

            lblInterviewHeader.AutoSize = true;
            lblInterviewHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInterviewHeader.Location = new System.Drawing.Point(16, 14);
            lblInterviewHeader.Name = "lblInterviewHeader";
            lblInterviewHeader.Text = "Interview Details";
            pnlInterviewDetails.Controls.Add(lblInterviewHeader);

            lblInterviewDateLabel.AutoSize = true;
            lblInterviewDateLabel.Font = new Font("Segoe UI", 9F);
            lblInterviewDateLabel.ForeColor = Color.Gray;
            lblInterviewDateLabel.Location = new System.Drawing.Point(16, 50);
            lblInterviewDateLabel.Name = "lblInterviewDateLabel";
            lblInterviewDateLabel.Text = "Date";
            pnlInterviewDetails.Controls.Add(lblInterviewDateLabel);

            lblInterviewDate.AutoSize = true;
            lblInterviewDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInterviewDate.Location = new System.Drawing.Point(130, 50);
            lblInterviewDate.Name = "lblInterviewDate";
            lblInterviewDate.Text = "-";
            pnlInterviewDetails.Controls.Add(lblInterviewDate);

            lblInterviewTimeLabel.AutoSize = true;
            lblInterviewTimeLabel.Font = new Font("Segoe UI", 9F);
            lblInterviewTimeLabel.ForeColor = Color.Gray;
            lblInterviewTimeLabel.Location = new System.Drawing.Point(16, 80);
            lblInterviewTimeLabel.Name = "lblInterviewTimeLabel";
            lblInterviewTimeLabel.Text = "Time";
            pnlInterviewDetails.Controls.Add(lblInterviewTimeLabel);

            lblInterviewTime.AutoSize = true;
            lblInterviewTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInterviewTime.Location = new System.Drawing.Point(130, 80);
            lblInterviewTime.Name = "lblInterviewTime";
            lblInterviewTime.Text = "-";
            pnlInterviewDetails.Controls.Add(lblInterviewTime);

            lblInterviewInterviewerLabel.AutoSize = true;
            lblInterviewInterviewerLabel.Font = new Font("Segoe UI", 9F);
            lblInterviewInterviewerLabel.ForeColor = Color.Gray;
            lblInterviewInterviewerLabel.Location = new System.Drawing.Point(16, 110);
            lblInterviewInterviewerLabel.Name = "lblInterviewInterviewerLabel";
            lblInterviewInterviewerLabel.Text = "Interviewer";
            pnlInterviewDetails.Controls.Add(lblInterviewInterviewerLabel);

            lblInterviewInterviewer.AutoSize = true;
            lblInterviewInterviewer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInterviewInterviewer.Location = new System.Drawing.Point(130, 110);
            lblInterviewInterviewer.Name = "lblInterviewInterviewer";
            lblInterviewInterviewer.Text = "-";
            pnlInterviewDetails.Controls.Add(lblInterviewInterviewer);

            lblInterviewModeLabel.AutoSize = true;
            lblInterviewModeLabel.Font = new Font("Segoe UI", 9F);
            lblInterviewModeLabel.ForeColor = Color.Gray;
            lblInterviewModeLabel.Location = new System.Drawing.Point(16, 140);
            lblInterviewModeLabel.Name = "lblInterviewModeLabel";
            lblInterviewModeLabel.Text = "Mode / Location";
            pnlInterviewDetails.Controls.Add(lblInterviewModeLabel);

            lblInterviewMode.AutoSize = true;
            lblInterviewMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInterviewMode.Location = new System.Drawing.Point(130, 140);
            lblInterviewMode.Name = "lblInterviewMode";
            lblInterviewMode.Text = "-";
            pnlInterviewDetails.Controls.Add(lblInterviewMode);

            pnlHRUpdates.BackColor = Color.White;
            pnlHRUpdates.BorderStyle = BorderStyle.FixedSingle;
            pnlHRUpdates.Location = new System.Drawing.Point(550, 310);
            pnlHRUpdates.Name = "pnlHRUpdates";
            pnlHRUpdates.Size = new System.Drawing.Size(460, 260);

            lblHRHeader.AutoSize = true;
            lblHRHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHRHeader.Location = new System.Drawing.Point(16, 14);
            lblHRHeader.Name = "lblHRHeader";
            lblHRHeader.Text = "Official HR Updates & Remarks";
            pnlHRUpdates.Controls.Add(lblHRHeader);

            txtHRNotes.BackColor = Color.FromArgb(250, 250, 250);
            txtHRNotes.BorderStyle = BorderStyle.None;
            txtHRNotes.Font = new Font("Segoe UI", 10F);
            txtHRNotes.Location = new System.Drawing.Point(16, 50);
            txtHRNotes.Multiline = true;
            txtHRNotes.ReadOnly = true;
            txtHRNotes.ScrollBars = ScrollBars.Vertical;
            txtHRNotes.Size = new System.Drawing.Size(426, 195);
            txtHRNotes.Name = "txtHRNotes";
            txtHRNotes.Text = "";
            pnlHRUpdates.Controls.Add(txtHRNotes);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            Controls.Add(lblTitle);
            Controls.Add(pnlTimelineTrack);
            Controls.Add(pnlStatus1);
            Controls.Add(lblStep1Title);
            Controls.Add(lblStep1Desc);
            Controls.Add(pnlStatus2);
            Controls.Add(lblStep2Title);
            Controls.Add(lblStep2Desc);
            Controls.Add(pnlStatus3);
            Controls.Add(lblStep3Title);
            Controls.Add(lblStep3Desc);
            Controls.Add(pnlStatus4);
            Controls.Add(lblStep4Title);
            Controls.Add(lblStep4Desc);
            Controls.Add(pnlStatus5);
            Controls.Add(lblStep5Title);
            Controls.Add(lblStep5Desc);
            Controls.Add(pnlStatus6);
            Controls.Add(lblStep6Title);
            Controls.Add(lblStep6Desc);
            Controls.Add(pnlInterviewDetails);
            Controls.Add(pnlHRUpdates);
            Name = "ApplicationStatus";
            Size = new System.Drawing.Size(1060, 715);
            pnlInterviewDetails.ResumeLayout(false);
            pnlInterviewDetails.PerformLayout();
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
        private Panel pnlStatus4;
        private Label lblStep4Title;
        private Label lblStep4Desc;
        private Panel pnlStatus5;
        private Label lblStep5Title;
        private Label lblStep5Desc;
        private Panel pnlStatus6;
        private Label lblStep6Title;
        private Label lblStep6Desc;
        private Panel pnlInterviewDetails;
        private Label lblInterviewHeader;
        private Label lblInterviewDateLabel;
        private Label lblInterviewDate;
        private Label lblInterviewTimeLabel;
        private Label lblInterviewTime;
        private Label lblInterviewInterviewerLabel;
        private Label lblInterviewInterviewer;
        private Label lblInterviewModeLabel;
        private Label lblInterviewMode;
        private Panel pnlHRUpdates;
        private Label lblHRHeader;
        private TextBox txtHRNotes;
    }
}
