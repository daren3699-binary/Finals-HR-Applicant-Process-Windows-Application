namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class InterviewEvaluation
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
            lblScore = new Label();
            numScore = new NumericUpDown();
            lblResult = new Label();
            cmbResult = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            lblRecommendation = new Label();
            txtRecommendation = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(118, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Evaluation";
            // 
            // lblApplicant
            // 
            lblApplicant.AutoSize = true;
            lblApplicant.Font = new Font("Segoe UI", 9F);
            lblApplicant.Location = new Point(26, 87);
            lblApplicant.Name = "lblApplicant";
            lblApplicant.Size = new Size(76, 20);
            lblApplicant.TabIndex = 1;
            lblApplicant.Text = "Applicant:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 9F);
            lblScore.Location = new Point(26, 130);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(101, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score (0-100):";
            // 
            // numScore
            // 
            numScore.Font = new Font("Segoe UI", 9F);
            numScore.Location = new Point(26, 153);
            numScore.Name = "numScore";
            numScore.Size = new Size(425, 27);
            numScore.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F);
            lblResult.Location = new Point(26, 194);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result:";
            // 
            // cmbResult
            // 
            cmbResult.Font = new Font("Segoe UI", 9F);
            cmbResult.FormattingEnabled = true;
            cmbResult.Items.AddRange(new object[] { "Pass", "Fail" });
            cmbResult.Location = new Point(26, 217);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(425, 28);
            cmbResult.TabIndex = 5;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 9F);
            lblRemarks.Location = new Point(26, 257);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 20);
            lblRemarks.TabIndex = 6;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI", 9F);
            txtRemarks.Location = new Point(26, 280);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(425, 34);
            txtRemarks.TabIndex = 7;
            // 
            // lblRecommendation
            // 
            lblRecommendation.AutoSize = true;
            lblRecommendation.Font = new Font("Segoe UI", 9F);
            lblRecommendation.Location = new Point(26, 334);
            lblRecommendation.Name = "lblRecommendation";
            lblRecommendation.Size = new Size(130, 20);
            lblRecommendation.TabIndex = 8;
            lblRecommendation.Text = "Recommendation:";
            // 
            // txtRecommendation
            // 
            txtRecommendation.Font = new Font("Segoe UI", 10.8F);
            txtRecommendation.Location = new Point(26, 357);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(425, 31);
            txtRecommendation.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(184, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 437);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // InterviewEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 493);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtRecommendation);
            Controls.Add(lblRecommendation);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(cmbResult);
            Controls.Add(lblResult);
            Controls.Add(numScore);
            Controls.Add(lblScore);
            Controls.Add(lblApplicant);
            Controls.Add(lblTitle);
            Name = "InterviewEvaluation";
            Text = "Interview Evaluation";
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicant;
        private Label lblScore;
        private NumericUpDown numScore;
        private Label lblResult;
        private ComboBox cmbResult;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Label lblRecommendation;
        private TextBox txtRecommendation;
        private Button btnSave;
        private Button btnBack;
    }
}