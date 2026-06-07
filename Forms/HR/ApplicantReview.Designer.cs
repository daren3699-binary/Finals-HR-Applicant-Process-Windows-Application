namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class ApplicantReview
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
            lblTitle = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblStatus = new Label();
            lblRemarks = new Label();
            cmbStatus = new ComboBox();
            txtRemarks = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            btnScreen = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(145, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Applicant Review";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(24, 167);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(133, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Application Status:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(35, 219);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(72, 20);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks: ";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Submitted", "Under Review", "For Interview", "Hired", "Rejected" });
            cmbStatus.Location = new Point(183, 164);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(246, 28);
            cmbStatus.TabIndex = 5;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(183, 216);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(246, 125);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(233, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(24, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnScreen
            // 
            btnScreen.Location = new Point(233, 392);
            btnScreen.Name = "btnScreen";
            btnScreen.Size = new Size(136, 29);
            btnScreen.TabIndex = 9;
            btnScreen.Text = "Screen Applicant";
            btnScreen.UseVisualStyleBackColor = true;
            btnScreen.Click += btnScreen_Click;
            // 
            // ApplicantReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 442);
            Controls.Add(btnScreen);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtRemarks);
            Controls.Add(cmbStatus);
            Controls.Add(lblRemarks);
            Controls.Add(lblStatus);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "ApplicantReview";
            Text = "Applicant Review";
            Load += ApplicantReview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblEmail;
        private Label lblStatus;
        private Label lblRemarks;
        private ComboBox cmbStatus;
        private TextBox txtRemarks;
        private Button btnSave;
        private Button btnBack;
        private Button btnScreen;
    }
}