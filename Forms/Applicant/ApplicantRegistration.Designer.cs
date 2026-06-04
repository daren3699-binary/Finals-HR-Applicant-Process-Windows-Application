namespace ApplicantRegistration
{
    partial class ApplicantRegistration
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
            txtFirstName = new TextBox();
            txtSurname = new TextBox();
            txtMiddleInitial = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cmbSex = new ComboBox();
            txtContactInfo = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            lnkLogin = new LinkLabel();
            lblTitle = new Label();
            lblFirstName = new Label();
            lblSurname = new Label();
            lblMiddleInitial = new Label();
            lblDateOfBirth = new Label();
            lblSex = new Label();
            lblContactInfo = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblPersonalInfo = new Label();
            lblAccountInfo = new Label();
            pnlPersonal = new Panel();
            pnlAccount = new Panel();
            pnlSeparator = new Panel();
            pnlPersonal.SuspendLayout();
            pnlAccount.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(15, 35);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(305, 35);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(250, 27);
            txtSurname.TabIndex = 7;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(15, 100);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(250, 27);
            txtMiddleInitial.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(305, 100);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(15, 165);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(250, 28);
            cmbSex.TabIndex = 5;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(305, 165);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(250, 27);
            txtContactInfo.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(540, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(290, 135);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(265, 27);
            txtConfirmPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(15, 185);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(540, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(170, 242);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(233, 20);
            lnkLogin.TabIndex = 8;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Already Registered? Back to login";
            lnkLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(270, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(15, 15);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(305, 15);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Surname";
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.AutoSize = true;
            lblMiddleInitial.Location = new Point(15, 80);
            lblMiddleInitial.Name = "lblMiddleInitial";
            lblMiddleInitial.Size = new Size(169, 20);
            lblMiddleInitial.TabIndex = 2;
            lblMiddleInitial.Text = "Middle Initial (Optional)";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(305, 80);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(94, 20);
            lblDateOfBirth.TabIndex = 8;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(15, 145);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(32, 20);
            lblSex.TabIndex = 4;
            lblSex.Text = "Sex";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(305, 145);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(142, 20);
            lblContactInfo.TabIndex = 10;
            lblContactInfo.Text = "Contact Information";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Address";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(15, 115);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(290, 115);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPersonalInfo.ForeColor = Color.Gray;
            lblPersonalInfo.Location = new Point(237, 70);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(197, 20);
            lblPersonalInfo.TabIndex = 1;
            lblPersonalInfo.Text = "PERSONAL INFORMATION";
            // 
            // lblAccountInfo
            // 
            lblAccountInfo.AutoSize = true;
            lblAccountInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAccountInfo.ForeColor = Color.Gray;
            lblAccountInfo.Location = new Point(15, 15);
            lblAccountInfo.Name = "lblAccountInfo";
            lblAccountInfo.Size = new Size(192, 20);
            lblAccountInfo.TabIndex = 0;
            lblAccountInfo.Text = "ACCOUNT INFORMATION";
            // 
            // pnlPersonal
            // 
            pnlPersonal.BorderStyle = BorderStyle.FixedSingle;
            pnlPersonal.Controls.Add(lblFirstName);
            pnlPersonal.Controls.Add(txtFirstName);
            pnlPersonal.Controls.Add(lblMiddleInitial);
            pnlPersonal.Controls.Add(txtMiddleInitial);
            pnlPersonal.Controls.Add(lblSex);
            pnlPersonal.Controls.Add(cmbSex);
            pnlPersonal.Controls.Add(lblSurname);
            pnlPersonal.Controls.Add(txtSurname);
            pnlPersonal.Controls.Add(lblDateOfBirth);
            pnlPersonal.Controls.Add(dtpDateOfBirth);
            pnlPersonal.Controls.Add(lblContactInfo);
            pnlPersonal.Controls.Add(txtContactInfo);
            pnlPersonal.Location = new Point(60, 100);
            pnlPersonal.Name = "pnlPersonal";
            pnlPersonal.Size = new Size(580, 240);
            pnlPersonal.TabIndex = 2;
            // 
            // pnlAccount
            // 
            pnlAccount.BorderStyle = BorderStyle.FixedSingle;
            pnlAccount.Controls.Add(lblAccountInfo);
            pnlAccount.Controls.Add(lblEmail);
            pnlAccount.Controls.Add(txtEmail);
            pnlAccount.Controls.Add(lblPassword);
            pnlAccount.Controls.Add(txtPassword);
            pnlAccount.Controls.Add(lblConfirmPassword);
            pnlAccount.Controls.Add(txtConfirmPassword);
            pnlAccount.Controls.Add(btnRegister);
            pnlAccount.Controls.Add(lnkLogin);
            pnlAccount.Location = new Point(60, 370);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(580, 300);
            pnlAccount.TabIndex = 4;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.LightGray;
            pnlSeparator.Location = new Point(60, 355);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(580, 2);
            pnlSeparator.TabIndex = 3;
            // 
            // ApplicantRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(700, 700);
            Controls.Add(lblTitle);
            Controls.Add(lblPersonalInfo);
            Controls.Add(pnlPersonal);
            Controls.Add(pnlSeparator);
            Controls.Add(pnlAccount);
            Name = "ApplicantRegistration";
            Text = "Applicant Registration";
            pnlPersonal.ResumeLayout(false);
            pnlPersonal.PerformLayout();
            pnlAccount.ResumeLayout(false);
            pnlAccount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtFirstName;
        private TextBox txtSurname;
        private TextBox txtMiddleInitial;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbSex;
        private TextBox txtContactInfo;
        private Panel pnlSeparator;
        private Panel pnlPersonal;
        private Panel pnlAccount;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private LinkLabel lnkLogin;
        private Label lblTitle;
        private Label lblFirstName;
        private Label lblSurname;
        private Label lblMiddleInitial;
        private Label lblDateOfBirth;
        private Label lblSex;
        private Label lblContactInfo;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblPersonalInfo;
        private Label lblAccountInfo;
    }
}