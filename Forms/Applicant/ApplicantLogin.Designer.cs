namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class ApplicantLogin
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            lblTitle = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            chkKeepSignedIn = new CheckBox();
            chkShowPassword = new CheckBox();
            lnkForgotPassword = new LinkLabel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();

            // panel1
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 420);
            panel1.Location = new Point(20, 20);
            panel1.TabIndex = 7;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Padding = new Padding(20);

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(340, 45);
            lblTitle.Location = new Point(30, 25);
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Sign in";

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 5;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Text = "Email:";

            // txtEmail
            txtEmail.Location = new Point(30, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 3;
            txtEmail.Font = new Font("Segoe UI", 9F);

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.TabIndex = 6;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Text = "Password:";

            // txtPassword
            txtPassword.Location = new Point(30, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(330, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Font = new Font("Segoe UI", 9F);

            // chkShowPassword
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(30, 215);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // chkKeepSignedIn
            chkKeepSignedIn.AutoSize = true;
            chkKeepSignedIn.Location = new Point(30, 245);
            chkKeepSignedIn.Name = "chkKeepSignedIn";
            chkKeepSignedIn.TabIndex = 9;
            chkKeepSignedIn.Font = new Font("Segoe UI", 9F);
            chkKeepSignedIn.Text = "Keep me signed in";
            chkKeepSignedIn.UseVisualStyleBackColor = true;

            // lnkForgotPassword
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Location = new Point(30, 278);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.TabIndex = 10;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F);
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;

            // btnLogin
            btnLogin.Location = new Point(30, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Sign In";
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            // btnRegister
            btnRegister.Location = new Point(30, 360);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(330, 32);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Don't have an account? Register";
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(chkKeepSignedIn);
            panel1.Controls.Add(lnkForgotPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);

            // ApplicantLogin
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Name = "ApplicantLogin";
            Text = "Applicant Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            // btnBack
            btnBack = new Button();
            btnBack.Location = new Point(30, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(330, 32);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back to Main Menu";
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
        }


        #endregion
        private Button btnLogin;
        private Button btnRegister;
        private Label lblTitle;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private CheckBox chkKeepSignedIn;
        private CheckBox chkShowPassword;
        private LinkLabel lnkForgotPassword;
        private Button btnBack;
        private Panel panel1;
    }
}