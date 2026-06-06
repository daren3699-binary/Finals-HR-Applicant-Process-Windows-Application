namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class HRDashboard
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
            lblWelcome = new Label();
            lblTotalApplicants = new Label();
            lblPending = new Label();
            lblInterviews = new Label();
            btnApplicantList = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(36, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(85, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // lblTotalApplicants
            // 
            lblTotalApplicants.AutoSize = true;
            lblTotalApplicants.Location = new Point(54, 120);
            lblTotalApplicants.Name = "lblTotalApplicants";
            lblTotalApplicants.Size = new Size(131, 20);
            lblTotalApplicants.TabIndex = 1;
            lblTotalApplicants.Text = "Total Applicants: 0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(54, 189);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(128, 20);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending Review: 0";
            // 
            // lblInterviews
            // 
            lblInterviews.AutoSize = true;
            lblInterviews.Location = new Point(54, 258);
            lblInterviews.Name = "lblInterviews";
            lblInterviews.Size = new Size(163, 20);
            lblInterviews.TabIndex = 3;
            lblInterviews.Text = "Scheduled Interviews: 0";
            // 
            // btnApplicantList
            // 
            btnApplicantList.Location = new Point(543, 67);
            btnApplicantList.Name = "btnApplicantList";
            btnApplicantList.Size = new Size(153, 29);
            btnApplicantList.TabIndex = 4;
            btnApplicantList.Text = "View Applicants";
            btnApplicantList.UseVisualStyleBackColor = true;
            btnApplicantList.Click += btnApplicantList_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(554, 364);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(104, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(543, 32);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(153, 29);
            btnReports.TabIndex = 6;
            btnReports.Text = "View Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 421);
            Controls.Add(btnReports);
            Controls.Add(btnLogout);
            Controls.Add(btnApplicantList);
            Controls.Add(lblInterviews);
            Controls.Add(lblPending);
            Controls.Add(lblTotalApplicants);
            Controls.Add(lblWelcome);
            Name = "HRDashboard";
            Text = "HR Dashboard";
            Load += HRDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblTotalApplicants;
        private Label lblPending;
        private Label lblInterviews;
        private Button btnApplicantList;
        private Button btnLogout;
        private Button btnReports;
    }
}