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
            btnApplicantList = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnJobVacancy = new Button();
            lblInterviews = new Label();
            lblPending = new Label();
            lblTotalApplicants = new Label();
            grpbxRecruitSummary = new GroupBox();
            grpbxRecruitSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(121, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // btnApplicantList
            // 
            btnApplicantList.Location = new Point(537, 131);
            btnApplicantList.Name = "btnApplicantList";
            btnApplicantList.Size = new Size(172, 29);
            btnApplicantList.TabIndex = 4;
            btnApplicantList.Text = "View Applicants";
            btnApplicantList.UseVisualStyleBackColor = true;
            btnApplicantList.Click += btnApplicantList_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(569, 360);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(104, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(537, 74);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(172, 29);
            btnReports.TabIndex = 6;
            btnReports.Text = "View Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnJobVacancy
            // 
            btnJobVacancy.Location = new Point(537, 191);
            btnJobVacancy.Name = "btnJobVacancy";
            btnJobVacancy.Size = new Size(172, 29);
            btnJobVacancy.TabIndex = 7;
            btnJobVacancy.Text = "Manage Job Vacancies";
            btnJobVacancy.UseVisualStyleBackColor = true;
            btnJobVacancy.Click += btnJobVacancy_Click;
            // 
            // lblInterviews
            // 
            lblInterviews.AutoSize = true;
            lblInterviews.Location = new Point(24, 159);
            lblInterviews.Name = "lblInterviews";
            lblInterviews.Size = new Size(229, 28);
            lblInterviews.TabIndex = 3;
            lblInterviews.Text = "Scheduled Interviews: 0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(24, 106);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(178, 28);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending Review: 0";
            // 
            // lblTotalApplicants
            // 
            lblTotalApplicants.AutoSize = true;
            lblTotalApplicants.Location = new Point(23, 62);
            lblTotalApplicants.Name = "lblTotalApplicants";
            lblTotalApplicants.Size = new Size(177, 28);
            lblTotalApplicants.TabIndex = 1;
            lblTotalApplicants.Text = "Total Applicants: 0";
            // 
            // grpbxRecruitSummary
            // 
            grpbxRecruitSummary.Controls.Add(lblTotalApplicants);
            grpbxRecruitSummary.Controls.Add(lblPending);
            grpbxRecruitSummary.Controls.Add(lblInterviews);
            grpbxRecruitSummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbxRecruitSummary.Location = new Point(12, 56);
            grpbxRecruitSummary.Name = "grpbxRecruitSummary";
            grpbxRecruitSummary.Size = new Size(516, 286);
            grpbxRecruitSummary.TabIndex = 8;
            grpbxRecruitSummary.TabStop = false;
            grpbxRecruitSummary.Text = "Recruitment Summary";
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(718, 421);
            Controls.Add(grpbxRecruitSummary);
            Controls.Add(btnJobVacancy);
            Controls.Add(btnReports);
            Controls.Add(btnLogout);
            Controls.Add(btnApplicantList);
            Controls.Add(lblWelcome);
            Name = "HRDashboard";
            Text = "HR Dashboard";
            Load += HRDashboard_Load;
            grpbxRecruitSummary.ResumeLayout(false);
            grpbxRecruitSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnApplicantList;
        private Button btnLogout;
        private Button btnReports;
        private Button btnJobVacancy;
        private Label lblInterviews;
        private Label lblPending;
        private Label lblTotalApplicants;
        private GroupBox grpbxRecruitSummary;
    }
}