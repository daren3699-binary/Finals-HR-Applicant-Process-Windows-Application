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
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(30, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.Location = new Point(30, 360);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(330, 32);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Don't have an account? Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Sign in";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(30, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(30, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(330, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(30, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(30, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // chkKeepSignedIn
            // 
            chkKeepSignedIn.AutoSize = true;
            chkKeepSignedIn.Font = new Font("Segoe UI", 9F);
            chkKeepSignedIn.Location = new Point(30, 245);
            chkKeepSignedIn.Name = "chkKeepSignedIn";
            chkKeepSignedIn.Size = new Size(154, 24);
            chkKeepSignedIn.TabIndex = 9;
            chkKeepSignedIn.Text = "Keep me signed in";
            chkKeepSignedIn.UseVisualStyleBackColor = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.Location = new Point(30, 215);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F);
            lnkForgotPassword.Location = new Point(30, 278);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(125, 20);
            lnkForgotPassword.TabIndex = 10;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(400, 420);
            panel1.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.Location = new Point(30, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(330, 32);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ApplicantLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Name = "ApplicantLogin";
            Text = "Applicant Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
<<<<<<< HEAD
            PerformLayout();
=======

>>>>>>> 98e7a5106b7988c15022176cad42018b8410658d
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
        private Panel panel1;
    }
}