namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class JobVacancyManagement
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
            dgvVacancies = new DataGridView();
            btnAddNew = new Button();
            btnEdit = new Button();
            btnOpenClose = new Button();
            btnBack = new Button();
            pnlForm = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtQualifications = new TextBox();
            lblQualifications = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            cmbEmploymentType = new ComboBox();
            lblEmploymentType = new Label();
            cmbDepartment = new ComboBox();
            lblDepartment = new Label();
            txtJobTitle = new TextBox();
            lblJobTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).BeginInit();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Job Vacancy Management";
            // 
            // dgvVacancies
            // 
            dgvVacancies.AllowUserToAddRows = false;
            dgvVacancies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVacancies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacancies.Location = new Point(20, 60);
            dgvVacancies.Name = "dgvVacancies";
            dgvVacancies.ReadOnly = true;
            dgvVacancies.RowHeadersWidth = 51;
            dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVacancies.Size = new Size(840, 280);
            dgvVacancies.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(20, 360);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(100, 30);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(130, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnOpenClose
            // 
            btnOpenClose.Location = new Point(240, 360);
            btnOpenClose.Name = "btnOpenClose";
            btnOpenClose.Size = new Size(120, 30);
            btnOpenClose.TabIndex = 4;
            btnOpenClose.Text = "Open / Close";
            btnOpenClose.UseVisualStyleBackColor = true;
            btnOpenClose.Click += btnOpenClose_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(760, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnCancel);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(txtQualifications);
            pnlForm.Controls.Add(lblQualifications);
            pnlForm.Controls.Add(txtDescription);
            pnlForm.Controls.Add(lblDescription);
            pnlForm.Controls.Add(cmbEmploymentType);
            pnlForm.Controls.Add(lblEmploymentType);
            pnlForm.Controls.Add(cmbDepartment);
            pnlForm.Controls.Add(lblDepartment);
            pnlForm.Controls.Add(txtJobTitle);
            pnlForm.Controls.Add(lblJobTitle);
            pnlForm.Location = new Point(20, 405);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(840, 140);
            pnlForm.TabIndex = 6;
            pnlForm.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(739, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(72, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(661, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(72, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtQualifications
            // 
            txtQualifications.Location = new Point(410, 86);
            txtQualifications.Multiline = true;
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(380, 40);
            txtQualifications.TabIndex = 9;
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Location = new Point(410, 68);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(103, 20);
            lblQualifications.TabIndex = 8;
            lblQualifications.Text = "Qualifications:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(15, 86);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(380, 40);
            txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 68);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // cmbEmploymentType
            // 
            cmbEmploymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmploymentType.FormattingEnabled = true;
            cmbEmploymentType.Items.AddRange(new object[] { "Full Time", "Part Time", "Contract", "Internship" });
            cmbEmploymentType.Location = new Point(455, 30);
            cmbEmploymentType.Name = "cmbEmploymentType";
            cmbEmploymentType.Size = new Size(160, 28);
            cmbEmploymentType.TabIndex = 5;
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Location = new Point(455, 12);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(131, 20);
            lblEmploymentType.TabIndex = 4;
            lblEmploymentType.Text = "Employment Type:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(250, 30);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(180, 28);
            cmbDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(250, 12);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(92, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department:";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(15, 30);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(220, 27);
            txtJobTitle.TabIndex = 1;
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(15, 12);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(68, 20);
            lblJobTitle.TabIndex = 0;
            lblJobTitle.Text = "Job Title:";
            // 
            // JobVacancyManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(pnlForm);
            Controls.Add(btnBack);
            Controls.Add(btnOpenClose);
            Controls.Add(btnEdit);
            Controls.Add(btnAddNew);
            Controls.Add(dgvVacancies);
            Controls.Add(lblTitle);
            Name = "JobVacancyManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Vacancy Management";
            Load += JobVacancyManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvVacancies;
        private Button btnAddNew;
        private Button btnEdit;
        private Button btnOpenClose;
        private Button btnBack;
        private Panel pnlForm;
        private Label lblJobTitle;
        private Label lblDepartment;
        private TextBox txtJobTitle;
        private Label lblEmploymentType;
        private ComboBox cmbDepartment;
        private Label lblDescription;
        private ComboBox cmbEmploymentType;
        private TextBox txtQualifications;
        private Label lblQualifications;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnSave;
    }
}