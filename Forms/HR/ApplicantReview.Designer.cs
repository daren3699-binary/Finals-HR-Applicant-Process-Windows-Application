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
            btnSchedule = new Button();
            btnEvaluate = new Button();
            btnDecide = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(134, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 31);
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
            lblStatus.Location = new Point(35, 167);
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
            cmbStatus.Location = new Point(174, 164);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(255, 28);
            cmbStatus.TabIndex = 5;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(113, 216);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(316, 125);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(334, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(113, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnScreen
            // 
            btnScreen.Location = new Point(24, 430);
            btnScreen.Name = "btnScreen";
            btnScreen.Size = new Size(200, 29);
            btnScreen.TabIndex = 9;
            btnScreen.Text = "Screen Applicant";
            btnScreen.UseVisualStyleBackColor = true;
            btnScreen.Click += btnScreen_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(24, 465);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(200, 29);
            btnSchedule.TabIndex = 10;
            btnSchedule.Text = "Schedule Interview";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(244, 430);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(200, 29);
            btnEvaluate.TabIndex = 11;
            btnEvaluate.Text = "Interview Evaluation";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // btnDecide
            // 
            btnDecide.Location = new Point(244, 465);
            btnDecide.Name = "btnDecide";
            btnDecide.Size = new Size(200, 29);
            btnDecide.TabIndex = 12;
            btnDecide.Text = "Hiring Decision";
            btnDecide.UseVisualStyleBackColor = true;
            btnDecide.Click += btnDecide_Click;
            // 
            // ApplicantReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 533);
            Controls.Add(btnDecide);
            Controls.Add(btnEvaluate);
            Controls.Add(btnSchedule);
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
        private Button btnSchedule;
        private Button btnEvaluate;
        private Button btnDecide;
    }
}