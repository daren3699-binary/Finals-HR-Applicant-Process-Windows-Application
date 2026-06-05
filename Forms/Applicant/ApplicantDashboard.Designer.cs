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
            pnlHeader = new Panel();
            lblLogo = new Label();
            btnProfileMenu = new Button();
            pnlSidebar = new Panel();
            pnlSidebarBottom = new Panel();
            btnMyDocuments = new Button();
            btnMyApplication = new Button();
            btnJobVacancies = new Button();
            btnAppStatus = new Button();
            btnHome = new Button();
            lblSidebarUser = new Label();
            pnlContent = new Panel();
            lblSubWelcome = new Label();
            lblWelcome = new Label();

            // Hardcoded Toolbox UI Components
            pnlLine = new Panel();
            cardStatus = new Panel();
            accentStatus = new Panel();
            lblTitleStatus = new Label();
            lblValueStatus = new Label();
            cardDate = new Panel();
            accentDate = new Panel();
            lblTitleDate = new Label();
            lblValueDate = new Label();
            cardPosition = new Panel();
            accentPosition = new Panel();
            lblTitlePosition = new Label();
            lblValuePosition = new Label();
            cardMissing = new Panel();
            accentMissing = new Panel();
            lblTitleMissing = new Label();
            lblValueMissing = new Label();
            cardInterview = new Panel();
            accentInterview = new Panel();
            lblTitleInterview = new Label();
            lblValueInterview = new Label();
            lblActivityHeader = new Label();
            pnlActivity = new Panel();
            lblActivityNote = new Label();
            lblActivityNote2 = new Label();
            lblActionsHeader = new Label();
            btnGoApplication = new Button();
            btnGoStatus = new Button();
            btnGoJobs = new Button();

            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            cardStatus.SuspendLayout();
            cardDate.SuspendLayout();
            cardPosition.SuspendLayout();
            cardMissing.SuspendLayout();
            cardInterview.SuspendLayout();
            pnlActivity.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.None;
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Controls.Add(btnProfileMenu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = SystemColors.Highlight;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 20, 0);
            pnlHeader.Size = new Size(1280, 65);
            pnlHeader.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(30, 30, 30);
            lblLogo.Location = new Point(25, 17);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(206, 35);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Applicant Portal";
            // 
            // btnProfileMenu
            // 
            btnProfileMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfileMenu.BackColor = Color.FromArgb(245, 245, 245);
            btnProfileMenu.Cursor = Cursors.Hand;
            btnProfileMenu.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnProfileMenu.FlatStyle = FlatStyle.Flat;
            btnProfileMenu.Font = new Font("Segoe UI", 9F);
            btnProfileMenu.ForeColor = Color.FromArgb(60, 60, 60);
            btnProfileMenu.Location = new Point(1090, 18);
            btnProfileMenu.Name = "btnProfileMenu";
            btnProfileMenu.Size = new Size(160, 30);
            btnProfileMenu.TabIndex = 1;
            btnProfileMenu.Text = "User  v";
            btnProfileMenu.TextAlign = ContentAlignment.MiddleCenter;
            btnProfileMenu.UseVisualStyleBackColor = false;
            btnProfileMenu.Click += btnProfileMenu_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(250, 250, 250);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnMyDocuments);
            pnlSidebar.Controls.Add(btnMyApplication);
            pnlSidebar.Controls.Add(btnJobVacancies);
            pnlSidebar.Controls.Add(btnAppStatus);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(lblSidebarUser);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 65);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(0, 10, 0, 0);
            pnlSidebar.Size = new Size(220, 715);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlSidebarBottom
            // 
            pnlSidebarBottom.BackColor = Color.FromArgb(230, 230, 230);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 714);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(220, 1);
            pnlSidebarBottom.TabIndex = 0;
            // 
            // btnMyDocuments
            // 
            btnMyDocuments.BackColor = Color.Transparent;
            btnMyDocuments.Cursor = Cursors.Hand;
            btnMyDocuments.FlatAppearance.BorderSize = 0;
            btnMyDocuments.FlatStyle = FlatStyle.Flat;
            btnMyDocuments.Font = new Font("Segoe UI", 10F);
            btnMyDocuments.ForeColor = Color.FromArgb(30, 30, 30);
            btnMyDocuments.Location = new Point(0, 220);
            btnMyDocuments.Name = "btnMyDocuments";
            btnMyDocuments.Size = new Size(220, 45);
            btnMyDocuments.TabIndex = 1;
            btnMyDocuments.Text = "   My Documents";
            btnMyDocuments.TextAlign = ContentAlignment.MiddleLeft;
            btnMyDocuments.UseVisualStyleBackColor = false;
            btnMyDocuments.Click += btnMyDocuments_Click;
            // 
            // btnMyApplication
            // 
            btnMyApplication.BackColor = Color.Transparent;
            btnMyApplication.Cursor = Cursors.Hand;
            btnMyApplication.FlatAppearance.BorderSize = 0;
            btnMyApplication.FlatStyle = FlatStyle.Flat;
            btnMyApplication.Font = new Font("Segoe UI", 10F);
            btnMyApplication.ForeColor = Color.FromArgb(30, 30, 30);
            btnMyApplication.Location = new Point(0, 175);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(220, 45);
            btnMyApplication.TabIndex = 2;
            btnMyApplication.Text = "   My Application";
            btnMyApplication.TextAlign = ContentAlignment.MiddleLeft;
            btnMyApplication.UseVisualStyleBackColor = false;
            btnMyApplication.Click += btnMyApplication_Click;
            // 
            // btnJobVacancies
            // 
            btnJobVacancies.BackColor = Color.Transparent;
            btnJobVacancies.Cursor = Cursors.Hand;
            btnJobVacancies.FlatAppearance.BorderSize = 0;
            btnJobVacancies.FlatStyle = FlatStyle.Flat;
            btnJobVacancies.Font = new Font("Segoe UI", 10F);
            btnJobVacancies.ForeColor = Color.FromArgb(30, 30, 30);
            btnJobVacancies.Location = new Point(0, 130);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(220, 45);
            btnJobVacancies.TabIndex = 3;
            btnJobVacancies.Text = "   Job Vacancies";
            btnJobVacancies.TextAlign = ContentAlignment.MiddleLeft;
            btnJobVacancies.UseVisualStyleBackColor = false;
            btnJobVacancies.Click += btnJobVacancies_Click;
            // 
            // btnAppStatus
            // 
            btnAppStatus.BackColor = Color.Transparent;
            btnAppStatus.Cursor = Cursors.Hand;
            btnAppStatus.FlatAppearance.BorderSize = 0;
            btnAppStatus.FlatStyle = FlatStyle.Flat;
            btnAppStatus.Font = new Font("Segoe UI", 10F);
            btnAppStatus.ForeColor = Color.FromArgb(30, 30, 30);
            btnAppStatus.Location = new Point(0, 85);
            btnAppStatus.Name = "btnAppStatus";
            btnAppStatus.Size = new Size(220, 45);
            btnAppStatus.TabIndex = 4;
            btnAppStatus.Text = "   Application Status";
            btnAppStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnAppStatus.UseVisualStyleBackColor = false;
            btnAppStatus.Click += btnAppStatus_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F);
            btnHome.ForeColor = Color.FromArgb(30, 30, 30);
            btnHome.Location = new Point(0, 40);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 45);
            btnHome.TabIndex = 5;
            btnHome.Text = "   Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblSidebarUser
            // 
            lblSidebarUser.AutoSize = true;
            lblSidebarUser.Font = new Font("Segoe UI", 9F);
            lblSidebarUser.ForeColor = Color.Gray;
            lblSidebarUser.Location = new Point(20, 15);
            lblSidebarUser.Name = "lblSidebarUser";
            lblSidebarUser.Size = new Size(51, 20);
            lblSidebarUser.TabIndex = 6;
            lblSidebarUser.Text = "MENU";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(247, 248, 250);
            pnlContent.Controls.Add(lblSubWelcome);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(pnlLine);
            pnlContent.Controls.Add(cardStatus);
            pnlContent.Controls.Add(cardDate);
            pnlContent.Controls.Add(cardPosition);
            pnlContent.Controls.Add(cardMissing);
            pnlContent.Controls.Add(cardInterview);
            pnlContent.Controls.Add(lblActivityHeader);
            pnlContent.Controls.Add(pnlActivity);
            pnlContent.Controls.Add(lblActionsHeader);
            pnlContent.Controls.Add(btnGoApplication);
            pnlContent.Controls.Add(btnGoStatus);
            pnlContent.Controls.Add(btnGoJobs);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40);
            pnlContent.Size = new Size(1060, 715);
            pnlContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 30, 30);
            lblWelcome.Location = new Point(40, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(267, 50);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Hello, User!";
            // 
            // lblSubWelcome
            // 
            lblSubWelcome.AutoSize = true;
            lblSubWelcome.Font = new Font("Segoe UI", 10F);
            lblSubWelcome.ForeColor = Color.Gray;
            lblSubWelcome.Location = new Point(40, 85);
            lblSubWelcome.Name = "lblSubWelcome";
            lblSubWelcome.Size = new Size(320, 23);
            lblSubWelcome.TabIndex = 0;
            lblSubWelcome.Text = "Here\'s an overview of your application.";
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.FromArgb(220, 220, 220);
            pnlLine.Location = new Point(40, 118);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(1000, 1);
            pnlLine.TabIndex = 2;
            // 
            // cardStatus
            // 
            cardStatus.BackColor = Color.White;
            cardStatus.BorderStyle = BorderStyle.FixedSingle;
            cardStatus.Controls.Add(accentStatus);
            cardStatus.Controls.Add(lblTitleStatus);
            cardStatus.Controls.Add(lblValueStatus);
            cardStatus.Location = new Point(40, 135);
            cardStatus.Name = "cardStatus";
            cardStatus.Size = new Size(240, 120);
            cardStatus.TabIndex = 3;
            // 
            // accentStatus
            // 
            accentStatus.BackColor = Color.FromArgb(255, 193, 7);
            accentStatus.Location = new Point(0, 0);
            accentStatus.Name = "accentStatus";
            accentStatus.Size = new Size(6, 120);
            accentStatus.TabIndex = 0;
            // 
            // lblTitleStatus
            // 
            lblTitleStatus.AutoSize = true;
            lblTitleStatus.Font = new Font("Segoe UI", 8F);
            lblTitleStatus.ForeColor = Color.Gray;
            lblTitleStatus.Location = new Point(18, 18);
            lblTitleStatus.Name = "lblTitleStatus";
            lblTitleStatus.Size = new Size(137, 19);
            lblTitleStatus.Text = "APPLICATION STATUS";
            // 
            // lblValueStatus
            // 
            lblValueStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValueStatus.ForeColor = Color.FromArgb(30, 30, 30);
            lblValueStatus.Location = new Point(18, 45);
            lblValueStatus.Name = "lblValueStatus";
            lblValueStatus.Size = new Size(210, 60);
            lblValueStatus.Text = "Pending";
            // 
            // cardDate
            // 
            cardDate.BackColor = Color.White;
            cardDate.BorderStyle = BorderStyle.FixedSingle;
            cardDate.Controls.Add(accentDate);
            cardDate.Controls.Add(lblTitleDate);
            cardDate.Controls.Add(lblValueDate);
            cardDate.Location = new Point(310, 135);
            cardDate.Name = "cardDate";
            cardDate.Size = new Size(240, 120);
            cardDate.TabIndex = 4;
            // 
            // accentDate
            // 
            accentDate.BackColor = Color.FromArgb(70, 130, 180);
            accentDate.Location = new Point(0, 0);
            accentDate.Name = "accentDate";
            accentDate.Size = new Size(6, 120);
            accentDate.TabIndex = 0;
            // 
            // lblTitleDate
            // 
            lblTitleDate.AutoSize = true;
            lblTitleDate.Font = new Font("Segoe UI", 8F);
            lblTitleDate.ForeColor = Color.Gray;
            lblTitleDate.Location = new Point(18, 18);
            lblTitleDate.Name = "lblTitleDate";
            lblTitleDate.Size = new Size(97, 19);
            lblTitleDate.Text = "DATE APPLIED";
            // 
            // lblValueDate
            // 
            lblValueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValueDate.ForeColor = Color.FromArgb(30, 30, 30);
            lblValueDate.Location = new Point(18, 45);
            lblValueDate.Name = "lblValueDate";
            lblValueDate.Size = new Size(210, 60);
            lblValueDate.Text = "N/A";
            // 
            // cardPosition
            // 
            cardPosition.BackColor = Color.White;
            cardPosition.BorderStyle = BorderStyle.FixedSingle;
            cardPosition.Controls.Add(accentPosition);
            cardPosition.Controls.Add(lblTitlePosition);
            cardPosition.Controls.Add(lblValuePosition);
            cardPosition.Location = new Point(580, 135);
            cardPosition.Name = "cardPosition";
            cardPosition.Size = new Size(240, 120);
            cardPosition.TabIndex = 5;
            // 
            // accentPosition
            // 
            accentPosition.BackColor = Color.FromArgb(111, 66, 193);
            accentPosition.Location = new Point(0, 0);
            accentPosition.Name = "accentPosition";
            accentPosition.Size = new Size(6, 120);
            accentPosition.TabIndex = 0;
            // 
            // lblTitlePosition
            // 
            lblTitlePosition.AutoSize = true;
            lblTitlePosition.Font = new Font("Segoe UI", 8F);
            lblTitlePosition.ForeColor = Color.Gray;
            lblTitlePosition.Location = new Point(18, 18);
            lblTitlePosition.Name = "lblTitlePosition";
            lblTitlePosition.Size = new Size(131, 19);
            lblTitlePosition.Text = "POSITION APPLIED";
            // 
            // lblValuePosition
            // 
            lblValuePosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValuePosition.ForeColor = Color.FromArgb(30, 30, 30);
            lblValuePosition.Location = new Point(18, 45);
            lblValuePosition.Name = "lblValuePosition";
            lblValuePosition.Size = new Size(210, 60);
            lblValuePosition.Text = "N/A";
            // 
            // cardMissing
            // 
            cardMissing.BackColor = Color.White;
            cardMissing.BorderStyle = BorderStyle.FixedSingle;
            cardMissing.Controls.Add(accentMissing);
            cardMissing.Controls.Add(lblTitleMissing);
            cardMissing.Controls.Add(lblValueMissing);
            cardMissing.Location = new Point(40, 285);
            cardMissing.Name = "cardMissing";
            cardMissing.Size = new Size(240, 120);
            cardMissing.TabIndex = 6;
            // 
            // accentMissing
            // 
            accentMissing.BackColor = Color.FromArgb(92, 184, 92);
            accentMissing.Location = new Point(0, 0);
            accentMissing.Name = "accentMissing";
            accentMissing.Size = new Size(6, 120);
            accentMissing.TabIndex = 0;
            // 
            // lblTitleMissing
            // 
            lblTitleMissing.AutoSize = true;
            lblTitleMissing.Font = new Font("Segoe UI", 8F);
            lblTitleMissing.ForeColor = Color.Gray;
            lblTitleMissing.Location = new Point(18, 18);
            lblTitleMissing.Name = "lblTitleMissing";
            lblTitleMissing.Size = new Size(170, 19);
            lblTitleMissing.Text = "MISSING REQUIREMENTS";
            // 
            // lblValueMissing
            // 
            lblValueMissing.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValueMissing.ForeColor = Color.FromArgb(30, 30, 30);
            lblValueMissing.Location = new Point(18, 45);
            lblValueMissing.Name = "lblValueMissing";
            lblValueMissing.Size = new Size(210, 60);
            lblValueMissing.Text = "None";
            // 
            // cardInterview
            // 
            cardInterview.BackColor = Color.White;
            cardInterview.BorderStyle = BorderStyle.FixedSingle;
            cardInterview.Controls.Add(accentInterview);
            cardInterview.Controls.Add(lblTitleInterview);
            cardInterview.Controls.Add(lblValueInterview);
            cardInterview.Location = new Point(310, 285);
            cardInterview.Name = "cardInterview";
            cardInterview.Size = new Size(310, 120);
            cardInterview.TabIndex = 7;
            // 
            // accentInterview
            // 
            accentInterview.BackColor = Color.FromArgb(150, 150, 150);
            accentInterview.Location = new Point(0, 0);
            accentInterview.Name = "accentInterview";
            accentInterview.Size = new Size(6, 120);
            accentInterview.TabIndex = 0;
            // 
            // lblTitleInterview
            // 
            lblTitleInterview.AutoSize = true;
            lblTitleInterview.Font = new Font("Segoe UI", 8F);
            lblTitleInterview.ForeColor = Color.Gray;
            lblTitleInterview.Location = new Point(18, 18);
            lblTitleInterview.Name = "lblTitleInterview";
            lblTitleInterview.Size = new Size(153, 19);
            lblTitleInterview.Text = "INTERVIEW SCHEDULE";
            // 
            // lblValueInterview
            // 
            lblValueInterview.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValueInterview.ForeColor = Color.FromArgb(30, 30, 30);
            lblValueInterview.Location = new Point(18, 42);
            lblValueInterview.Name = "lblValueInterview";
            lblValueInterview.Size = new Size(280, 70);
            lblValueInterview.Text = "Not scheduled";
            // 
            // lblActivityHeader
            // 
            lblActivityHeader.AutoSize = true;
            lblActivityHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActivityHeader.ForeColor = Color.FromArgb(30, 30, 30);
            lblActivityHeader.Location = new Point(40, 460);
            lblActivityHeader.Name = "lblActivityHeader";
            lblActivityHeader.Size = new Size(152, 28);
            lblActivityHeader.Text = "Recent Activity";
            // 
            // pnlActivity
            // 
            pnlActivity.BackColor = Color.White;
            pnlActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlActivity.Controls.Add(lblActivityNote);
            pnlActivity.Controls.Add(lblActivityNote2);
            pnlActivity.Location = new Point(40, 492);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(1000, 100);
            pnlActivity.TabIndex = 8;
            // 
            // lblActivityNote
            // 
            lblActivityNote.AutoSize = true;
            lblActivityNote.Font = new Font("Segoe UI", 9F);
            lblActivityNote.ForeColor = Color.Gray;
            lblActivityNote.Location = new Point(15, 15);
            lblActivityNote.Name = "lblActivityNote";
            lblActivityNote.Size = new Size(462, 20);
            lblActivityNote.Text = "No application submitted yet. Go to My Application to get started.";
            // 
            // lblActivityNote2
            // 
            lblActivityNote2.AutoSize = true;
            lblActivityNote2.Font = new Font("Segoe UI", 9F);
            lblActivityNote2.ForeColor = Color.Gray;
            lblActivityNote2.Location = new Point(15, 45);
            lblActivityNote2.Name = "lblActivityNote2";
            lblActivityNote2.Size = new Size(158, 20);
            lblActivityNote2.Text = "Current status: Pending";
            // 
            // lblActionsHeader
            // 
            lblActionsHeader.AutoSize = true;
            lblActionsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActionsHeader.ForeColor = Color.FromArgb(30, 30, 30);
            lblActionsHeader.Location = new System.Drawing.Point(40, 615); lblActionsHeader.Name = "lblActionsHeader";
            lblActionsHeader.Size = new Size(141, 28);
            lblActionsHeader.Text = "Quick Actions";
            // 
            // btnGoApplication
            // 
            btnGoApplication.BackColor = Color.White;
            btnGoApplication.Cursor = Cursors.Hand;
            btnGoApplication.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            btnGoApplication.FlatStyle = FlatStyle.Flat;
            btnGoApplication.Font = new Font("Segoe UI", 9F);
            btnGoApplication.ForeColor = Color.FromArgb(70, 130, 180);
            btnGoApplication.Location = new Point(40, 650);
            btnGoApplication.Name = "btnGoApplication";
            btnGoApplication.Size = new Size(180, 38);
            btnGoApplication.TabIndex = 9;
            btnGoApplication.Text = "View My Application";
            btnGoApplication.UseVisualStyleBackColor = false;
            btnGoApplication.Click += btnMyApplication_Click;
            // 
            // btnGoStatus
            // 
            btnGoStatus.BackColor = Color.White;
            btnGoStatus.Cursor = Cursors.Hand;
            btnGoStatus.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            btnGoStatus.FlatStyle = FlatStyle.Flat;
            btnGoStatus.Font = new Font("Segoe UI", 9F);
            btnGoStatus.ForeColor = Color.FromArgb(70, 130, 180);
            btnGoStatus.Location = new Point(230, 650);
            btnGoStatus.Name = "btnGoStatus";
            btnGoStatus.Size = new Size(180, 38);
            btnGoStatus.TabIndex = 10;
            btnGoStatus.Text = "Check Application Status";
            btnGoStatus.UseVisualStyleBackColor = false;
            btnGoStatus.Click += btnAppStatus_Click;
            // 
            // btnGoJobs
            // 
            btnGoJobs.BackColor = Color.White;
            btnGoJobs.Cursor = Cursors.Hand;
            btnGoJobs.FlatAppearance.BorderColor = Color.FromArgb(70, 130, 180);
            btnGoJobs.FlatStyle = FlatStyle.Flat;
            btnGoJobs.Font = new Font("Segoe UI", 9F);
            btnGoJobs.ForeColor = Color.FromArgb(70, 130, 180);
            btnGoJobs.Location = new Point(440, 650);
            btnGoJobs.Name = "btnGoJobs";
            btnGoJobs.Size = new Size(180, 38);
            btnGoJobs.TabIndex = 11;
            btnGoJobs.Text = "Browse Job Vacancies";
            btnGoJobs.UseVisualStyleBackColor = false;
            btnGoJobs.Click += btnJobVacancies_Click;
            // 
            // ApplicantDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 780);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "ApplicantDashboard";
            Text = "Applicant Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += ApplicantDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            cardStatus.ResumeLayout(false);
            cardStatus.PerformLayout();
            cardDate.ResumeLayout(false);
            cardDate.PerformLayout();
            cardPosition.ResumeLayout(false);
            cardPosition.PerformLayout();
            cardMissing.ResumeLayout(false);
            cardMissing.PerformLayout();
            cardInterview.ResumeLayout(false);
            cardInterview.PerformLayout();
            pnlActivity.ResumeLayout(false);
            pnlActivity.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblLogo;
        private Button btnProfileMenu;
        private Panel pnlSidebar;
        private Button btnHome;
        private Button btnAppStatus;
        private Button btnJobVacancies;
        private Button btnMyApplication;
        private Button btnMyDocuments;
        private Panel pnlSidebarBottom;
        private Label lblSidebarUser;
        private Panel pnlContent;
        private Label lblWelcome;
        private Label lblSubWelcome;

        // Form Designer Controls declared as proper fields
        private Panel pnlLine;
        private Panel cardStatus;
        private Panel accentStatus;
        private Label lblTitleStatus;
        private Label lblValueStatus;
        private Panel cardDate;
        private Panel accentDate;
        private Label lblTitleDate;
        private Label lblValueDate;
        private Panel cardPosition;
        private Panel accentPosition;
        private Label lblTitlePosition;
        private Label lblValuePosition;
        private Panel cardMissing;
        private Panel accentMissing;
        private Label lblTitleMissing;
        private Label lblValueMissing;
        private Panel cardInterview;
        private Panel accentInterview;
        private Label lblTitleInterview;
        private Label lblValueInterview;
        private Label lblActivityHeader;
        private Panel pnlActivity;
        private Label lblActivityNote;
        private Label lblActivityNote2;
        private Label lblActionsHeader;
        private Button btnGoApplication;
        private Button btnGoStatus;
        private Button btnGoJobs;
    }
}