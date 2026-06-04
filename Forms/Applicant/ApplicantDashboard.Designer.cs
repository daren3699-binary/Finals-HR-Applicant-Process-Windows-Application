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
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
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
            btnProfileMenu.Text = "Account  v";
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
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40);
            pnlContent.Size = new Size(1060, 715);
            pnlContent.TabIndex = 0;
            // 
            // lblSubWelcome
            // 
            lblSubWelcome.AutoSize = true;
            lblSubWelcome.Font = new Font("Segoe UI", 11F);
            lblSubWelcome.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubWelcome.Location = new Point(40, 100);
            lblSubWelcome.Name = "lblSubWelcome";
            lblSubWelcome.Size = new Size(518, 25);
            lblSubWelcome.TabIndex = 0;
            lblSubWelcome.Text = "Welcome back. Use the sidebar to navigate your application.";
            lblSubWelcome.Click += lblSubWelcome_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 30, 30);
            lblWelcome.Location = new Point(40, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(267, 60);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Hello, User!";
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
    }
}