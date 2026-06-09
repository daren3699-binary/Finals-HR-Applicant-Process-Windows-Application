namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class HiringDecision
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
            lblWarning = new Label();
            lblDecision = new Label();
            cmbDecision = new ComboBox();
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
            lblTitle.Location = new Point(115, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Final Hiring Decision";
            // 
            // lblApplicant
            // 
            lblApplicant.AutoSize = true;
            lblApplicant.Location = new Point(26, 103);
            lblApplicant.Name = "lblApplicant";
            lblApplicant.Size = new Size(76, 20);
            lblApplicant.TabIndex = 1;
            lblApplicant.Text = "Applicant:";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWarning.Location = new Point(86, 297);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(293, 20);
            lblWarning.TabIndex = 2;
            lblWarning.Text = "⚠ Only HR Manager/Admin can accept.";
            // 
            // lblDecision
            // 
            lblDecision.AutoSize = true;
            lblDecision.Location = new Point(26, 143);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(69, 20);
            lblDecision.TabIndex = 3;
            lblDecision.Text = "Decision:";
            // 
            // cmbDecision
            // 
            cmbDecision.FormattingEnabled = true;
            cmbDecision.Items.AddRange(new object[] { "Accepted", "Rejected", "On - Hold" });
            cmbDecision.Location = new Point(26, 166);
            cmbDecision.Name = "cmbDecision";
            cmbDecision.Size = new Size(404, 28);
            cmbDecision.TabIndex = 4;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(26, 211);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 20);
            lblRemarks.TabIndex = 5;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(26, 248);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(404, 34);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(181, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // HiringDecision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 462);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(cmbDecision);
            Controls.Add(lblDecision);
            Controls.Add(lblWarning);
            Controls.Add(lblApplicant);
            Controls.Add(lblTitle);
            Name = "HiringDecision";
            Text = "Hiring Decision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicant;
        private Label lblWarning;
        private Label lblDecision;
        private ComboBox cmbDecision;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnSave;
        private Button btnBack;
    }
}