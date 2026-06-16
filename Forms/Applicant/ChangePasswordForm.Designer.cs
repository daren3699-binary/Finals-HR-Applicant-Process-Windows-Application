namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class ChangePasswordForm
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
            lblChangePasswordHeader = new Label();
            lblChangeEmail = new Label();
            txtChangeEmail = new TextBox();
            lblCurrentPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            btnChangePassword = new Button();
            SuspendLayout();

            lblChangePasswordHeader.AutoSize = true;
            lblChangePasswordHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChangePasswordHeader.Location = new Point(20, 20);
            lblChangePasswordHeader.Name = "lblChangePasswordHeader";
            lblChangePasswordHeader.Text = "Change Password";

            lblChangeEmail.AutoSize = true;
            lblChangeEmail.Font = new Font("Segoe UI", 9F);
            lblChangeEmail.Location = new Point(20, 65);
            lblChangeEmail.Name = "lblChangeEmail";
            lblChangeEmail.Text = "Email Address";

            txtChangeEmail.Font = new Font("Segoe UI", 9F);
            txtChangeEmail.Location = new Point(20, 85);
            txtChangeEmail.Name = "txtChangeEmail";
            txtChangeEmail.Size = new Size(350, 27);
            txtChangeEmail.TabIndex = 0;

            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 9F);
            lblCurrentPassword.Location = new Point(20, 125);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Text = "Current Password";

            txtCurrentPassword.Font = new Font("Segoe UI", 9F);
            txtCurrentPassword.Location = new Point(20, 145);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(350, 27);
            txtCurrentPassword.TabIndex = 1;

            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9F);
            lblNewPassword.Location = new Point(20, 185);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Text = "New Password";

            txtNewPassword.Font = new Font("Segoe UI", 9F);
            txtNewPassword.Location = new Point(20, 205);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(350, 27);
            txtNewPassword.TabIndex = 2;

            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmNewPassword.Location = new Point(20, 245);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Text = "Confirm New Password";

            txtConfirmNewPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmNewPassword.Location = new Point(20, 265);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(350, 27);
            txtConfirmNewPassword.TabIndex = 3;

            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangePassword.Location = new Point(20, 310);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(350, 35);
            btnChangePassword.Text = "Change Password";
            btnChangePassword.BackColor = Color.FromArgb(70, 130, 180);
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 375);
            Controls.Add(lblChangePasswordHeader);
            Controls.Add(lblChangeEmail);
            Controls.Add(txtChangeEmail);
            Controls.Add(lblCurrentPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(btnChangePassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblChangePasswordHeader;
        private Label lblChangeEmail;
        private TextBox txtChangeEmail;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnChangePassword;
    }
}
