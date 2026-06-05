namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class MyApplication
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
            lblTitle = new Label();
            pnlCard = new Panel();
            lblFieldJob = new Label();
            lblJobTitle = new Label();
            lblFieldStatus = new Label();
            lblStatus = new Label();
            lblFieldDate = new Label();
            lblDateApplied = new Label();
            lblFieldQual = new Label();
            txtQualifications = new TextBox();
            lblLockNote = new Label();
            btnWithdraw = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(40, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "My Application";

            // pnlCard
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Location = new System.Drawing.Point(40, 100);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(600, 420);
            pnlCard.Controls.Add(lblFieldJob);
            pnlCard.Controls.Add(lblJobTitle);
            pnlCard.Controls.Add(lblFieldStatus);
            pnlCard.Controls.Add(lblStatus);
            pnlCard.Controls.Add(lblFieldDate);
            pnlCard.Controls.Add(lblDateApplied);
            pnlCard.Controls.Add(lblFieldQual);
            pnlCard.Controls.Add(txtQualifications);
            pnlCard.Controls.Add(lblLockNote);
            pnlCard.Controls.Add(btnWithdraw);

            // lblFieldJob
            lblFieldJob.AutoSize = true;
            lblFieldJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFieldJob.Location = new System.Drawing.Point(25, 25);
            lblFieldJob.Name = "lblFieldJob";
            lblFieldJob.Text = "Position Applied:";

            // lblJobTitle
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 9F);
            lblJobTitle.Location = new System.Drawing.Point(25, 47);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Text = "N/A";

            // lblFieldStatus
            lblFieldStatus.AutoSize = true;
            lblFieldStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFieldStatus.Location = new System.Drawing.Point(25, 85);
            lblFieldStatus.Name = "lblFieldStatus";
            lblFieldStatus.Text = "Current Status:";

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.Location = new System.Drawing.Point(25, 107);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "N/A";

            // lblFieldDate
            lblFieldDate.AutoSize = true;
            lblFieldDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFieldDate.Location = new System.Drawing.Point(25, 145);
            lblFieldDate.Name = "lblFieldDate";
            lblFieldDate.Text = "Date Applied:";

            // lblDateApplied
            lblDateApplied.AutoSize = true;
            lblDateApplied.Font = new Font("Segoe UI", 9F);
            lblDateApplied.Location = new System.Drawing.Point(25, 167);
            lblDateApplied.Name = "lblDateApplied";
            lblDateApplied.Text = "N/A";

            // lblFieldQual
            lblFieldQual.AutoSize = true;
            lblFieldQual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFieldQual.Location = new System.Drawing.Point(25, 205);
            lblFieldQual.Name = "lblFieldQual";
            lblFieldQual.Text = "Job Qualifications:";

            // txtQualifications
            txtQualifications.BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            txtQualifications.BorderStyle = BorderStyle.FixedSingle;
            txtQualifications.Font = new Font("Segoe UI", 9F);
            txtQualifications.Location = new System.Drawing.Point(25, 227);
            txtQualifications.Multiline = true;
            txtQualifications.ReadOnly = true;
            txtQualifications.Size = new System.Drawing.Size(548, 80);
            txtQualifications.Name = "txtQualifications";

            // lblLockNote
            lblLockNote.AutoSize = false;
            lblLockNote.Size = new System.Drawing.Size(548, 35);
            lblLockNote.Font = new Font("Segoe UI", 8.5F);
            lblLockNote.ForeColor = System.Drawing.Color.Gray;
            lblLockNote.Location = new System.Drawing.Point(25, 320);
            lblLockNote.Name = "lblLockNote";
            lblLockNote.Text = "";

            // btnWithdraw
            btnWithdraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWithdraw.ForeColor = System.Drawing.Color.White;
            btnWithdraw.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.Location = new System.Drawing.Point(25, 368);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new System.Drawing.Size(160, 32);
            btnWithdraw.Text = "Withdraw Application";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;

            // MyApplication UserControl
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            Controls.Add(lblTitle);
            Controls.Add(pnlCard);
            Name = "MyApplication";
            Size = new System.Drawing.Size(1060, 715);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Panel pnlCard;
        private Label lblFieldJob;
        private Label lblJobTitle;
        private Label lblFieldStatus;
        private Label lblStatus;
        private Label lblFieldDate;
        private Label lblDateApplied;
        private Label lblFieldQual;
        private TextBox txtQualifications;
        private Label lblLockNote;
        private Button btnWithdraw;
    }
}