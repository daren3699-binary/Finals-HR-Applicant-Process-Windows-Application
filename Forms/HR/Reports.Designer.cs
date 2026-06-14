namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class Reports
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
            lblFilter = new Label();
            cmbFilter = new ComboBox();
            btnExport = new Button();
            btnBack = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(96, 95);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(109, 20);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Filter by Status:";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Submitted", "Under Review", "For Interview", "Accepted", "Rejected" });
            cmbFilter.Location = new Point(211, 91);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(352, 28);
            cmbFilter.TabIndex = 2;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(569, 91);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(123, 29);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export to CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 91);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(12, 139);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(680, 299);
            dgvReport.TabIndex = 6;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(dgvReport);
            Controls.Add(btnBack);
            Controls.Add(btnExport);
            Controls.Add(cmbFilter);
            Controls.Add(lblFilter);
            Controls.Add(lblTitle);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFilter;
        private ComboBox cmbFilter;
        private Button btnExport;
        private Button btnBack;
        private DataGridView dgvReport;
    }
}