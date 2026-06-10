    namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class Screening
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
            lblApplicantName = new Label();
            lblJobTitle = new Label();
            rbQualified = new RadioButton();
            rbNotQualified = new RadioButton();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Screening Evaluation";
            // 
            // lblApplicantName
            // 
            lblApplicantName.AutoSize = true;
            lblApplicantName.Font = new Font("Segoe UI", 10.8F);
            lblApplicantName.Location = new Point(30, 101);
            lblApplicantName.Name = "lblApplicantName";
            lblApplicantName.Size = new Size(91, 25);
            lblApplicantName.TabIndex = 1;
            lblApplicantName.Text = "Applicant:";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 10.8F);
            lblJobTitle.Location = new Point(30, 150);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(79, 25);
            lblJobTitle.TabIndex = 2;
            lblJobTitle.Text = "Position:";
            // 
            // rbQualified
            // 
            rbQualified.AutoSize = true;
            rbQualified.Font = new Font("Segoe UI", 10.8F);
            rbQualified.Location = new Point(30, 191);
            rbQualified.Name = "rbQualified";
            rbQualified.Size = new Size(104, 29);
            rbQualified.TabIndex = 3;
            rbQualified.TabStop = true;
            rbQualified.Text = "Qualified";
            rbQualified.UseVisualStyleBackColor = true;
            // 
            // rbNotQualified
            // 
            rbNotQualified.AutoSize = true;
            rbNotQualified.Font = new Font("Segoe UI", 10.8F);
            rbNotQualified.Location = new Point(30, 221);
            rbNotQualified.Name = "rbNotQualified";
            rbNotQualified.Size = new Size(139, 29);
            rbNotQualified.TabIndex = 4;
            rbNotQualified.TabStop = true;
            rbNotQualified.Text = "Not Qualified";
            rbNotQualified.UseVisualStyleBackColor = true;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.8F);
            lblRemarks.Location = new Point(35, 258);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(83, 25);
            lblRemarks.TabIndex = 5;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(30, 288);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(475, 27);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(207, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(207, 389);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Screening
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(rbNotQualified);
            Controls.Add(rbQualified);
            Controls.Add(lblJobTitle);
            Controls.Add(lblApplicantName);
            Controls.Add(lblTitle);
            Name = "Screening";
            Text = "Screening";
            Load += Screening_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicantName;
        private Label lblJobTitle;
        private RadioButton rbQualified;
        private RadioButton rbNotQualified;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnSave;
        private Button btnBack;
    }
}