namespace FinalsHRApplicantProcessWindowsApplication
{
    partial class MainMenu
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
            lblSubtitle = new Label();
            btnApplicant = new Button();
            btnHR = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(220, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HR  Applicant System";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(242, 83);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(276, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome! Please click your destination ↓\r\n\r\n";
            // 
            // btnApplicant
            // 
            btnApplicant.BackColor = Color.SteelBlue;
            btnApplicant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplicant.ForeColor = SystemColors.ControlText;
            btnApplicant.Location = new Point(12, 126);
            btnApplicant.Name = "btnApplicant";
            btnApplicant.Size = new Size(738, 55);
            btnApplicant.TabIndex = 3;
            btnApplicant.Text = "Applicant Portal";
            btnApplicant.UseVisualStyleBackColor = false;
            btnApplicant.Click += btnApplicant_Click;
            // 
            // btnHR
            // 
            btnHR.BackColor = Color.Maroon;
            btnHR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHR.Location = new Point(12, 228);
            btnHR.Name = "btnHR";
            btnHR.Size = new Size(738, 56);
            btnHR.TabIndex = 4;
            btnHR.Text = "HR Portal";
            btnHR.UseVisualStyleBackColor = false;
            btnHR.Click += btnHR_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 392);
            Controls.Add(btnHR);
            Controls.Add(btnApplicant);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "MainMenu";
            Text = "HR Applicant System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnApplicant;
        private Button btnHR;
    }
}