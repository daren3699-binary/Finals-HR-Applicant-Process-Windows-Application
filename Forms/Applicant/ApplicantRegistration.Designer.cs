namespace ApplicationRegistration
{
    partial class ApplicationRegistration
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
            pnlSeparator = new Panel();
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
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(20, 115);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(440, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(20, 175);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(440, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(20, 235);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(440, 27);
            txtMiddleInitial.TabIndex = 2;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(20, 295);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(440, 27);
            dtpDateOfBirth.TabIndex = 3;
            // 
            // cmbSex
            // 
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.Items.AddRange(new object[] { "Male", "Female" });
            cmbSex.Location = new Point(20, 355);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(440, 28);
            cmbSex.TabIndex = 4;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(20, 415);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(440, 27);
            txtContactInfo.TabIndex = 5;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.LightGray;
            pnlSeparator.Location = new Point(20, 460);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(440, 2);
            pnlSeparator.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 525);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 585);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(440, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(20, 645);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(440, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 690);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(440, 40);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(124, 751);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(233, 20);
            lnkLogin.TabIndex = 13;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Already Registered? Back to login";
            lnkLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(168, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(20, 155);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Surname";
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.AutoSize = true;
            lblMiddleInitial.Location = new Point(20, 215);
            lblMiddleInitial.Name = "lblMiddleInitial";
            lblMiddleInitial.Size = new Size(169, 20);
            lblMiddleInitial.TabIndex = 4;
            lblMiddleInitial.Text = "Middle Initial (Optional)";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(20, 275);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(94, 20);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(20, 335);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(32, 20);
            lblSex.TabIndex = 6;
            lblSex.Text = "Sex";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(20, 395);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(142, 20);
            lblContactInfo.TabIndex = 7;
            lblContactInfo.Text = "Contact Information";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 505);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email Address";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 565);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(20, 625);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPersonalInfo.ForeColor = Color.Gray;
            lblPersonalInfo.Location = new Point(146, 55);
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
            lblAccountInfo.Location = new Point(20, 475);
            lblAccountInfo.Name = "lblAccountInfo";
            lblAccountInfo.Size = new Size(192, 20);
            lblAccountInfo.TabIndex = 9;
            lblAccountInfo.Text = "ACCOUNT INFORMATION";
            // 
            // Form1
            // 
            AutoScroll = true;
            AutoScaleMode = AutoScaleMode.Font;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 780);
            Controls.Add(lblTitle);
            Controls.Add(lblPersonalInfo);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblSurname);
            Controls.Add(txtSurname);
            Controls.Add(lblMiddleInitial);
            Controls.Add(txtMiddleInitial);
            Controls.Add(lblDateOfBirth);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblSex);
            Controls.Add(cmbSex);
            Controls.Add(lblContactInfo);
            Controls.Add(txtContactInfo);
            Controls.Add(pnlSeparator);
            Controls.Add(lblAccountInfo);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(lnkLogin);
            Name = "Form1";
            Text = "Application Registration";
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPersonalInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSurname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMiddleInitial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblContactInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAccountInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSurname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMiddleInitial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContactInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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