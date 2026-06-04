namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class InterviewSchedule
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
            lblApplicant = new Label();
            dtpInterviewDate = new DateTimePicker();
            lblMode = new Label();
            cmbMode = new ComboBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(132, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Schedule";
            // 
            // lblApplicant
            // 
            lblApplicant.AutoSize = true;
            lblApplicant.Location = new Point(36, 82);
            lblApplicant.Name = "lblApplicant";
            lblApplicant.Size = new Size(80, 20);
            lblApplicant.TabIndex = 1;
            lblApplicant.Text = "Applicant: ";
            // 
            // dtpInterviewDate
            // 
            dtpInterviewDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpInterviewDate.Format = DateTimePickerFormat.Custom;
            dtpInterviewDate.Location = new Point(36, 115);
            dtpInterviewDate.Name = "dtpInterviewDate";
            dtpInterviewDate.Size = new Size(385, 27);
            dtpInterviewDate.TabIndex = 2;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(36, 160);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(55, 20);
            lblMode.TabIndex = 3;
            lblMode.Text = "Mode: ";
            // 
            // cmbMode
            // 
            cmbMode.FormattingEnabled = true;
            cmbMode.Items.AddRange(new object[] { "Face-to-Face", "Online" });
            cmbMode.Location = new Point(36, 183);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(385, 28);
            cmbMode.TabIndex = 4;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(36, 234);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(73, 20);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Location: ";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(36, 266);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(385, 27);
            txtLocation.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(155, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 33);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Schedule";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(32, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 35);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // InterviewSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(cmbMode);
            Controls.Add(lblMode);
            Controls.Add(dtpInterviewDate);
            Controls.Add(lblApplicant);
            Controls.Add(lblTitle);
            Name = "InterviewSchedule";
            Text = "Interview Schedule";
            Load += InterviewSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicant;
        private DateTimePicker dtpInterviewDate;
        private Label lblMode;
        private ComboBox cmbMode;
        private Label lblLocation;
        private TextBox txtLocation;
        private Button btnSave;
        private Button btnBack;
    }
}