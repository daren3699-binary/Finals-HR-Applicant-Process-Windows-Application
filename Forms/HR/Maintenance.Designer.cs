namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    partial class Maintenance
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
            tabControl1 = new TabControl();
            tabDepartments = new TabPage();
            btnDeleteDept = new Button();
            btnAddDept = new Button();
            txtDeptName = new TextBox();
            dgvDepartments = new DataGridView();
            tabRequirements = new TabPage();
            btnDeleteReq = new Button();
            btnAddReq = new Button();
            txtReqName = new TextBox();
            dgvRequirements = new DataGridView();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            tabRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(22, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Maintenance";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDepartments);
            tabControl1.Controls.Add(tabRequirements);
            tabControl1.Location = new Point(23, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(747, 353);
            tabControl1.TabIndex = 1;
            // 
            // tabDepartments
            // 
            tabDepartments.Controls.Add(btnDeleteDept);
            tabDepartments.Controls.Add(btnAddDept);
            tabDepartments.Controls.Add(txtDeptName);
            tabDepartments.Controls.Add(dgvDepartments);
            tabDepartments.Location = new Point(4, 29);
            tabDepartments.Name = "tabDepartments";
            tabDepartments.Padding = new Padding(3);
            tabDepartments.Size = new Size(739, 320);
            tabDepartments.TabIndex = 0;
            tabDepartments.Text = "Departments";
            tabDepartments.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDept
            // 
            btnDeleteDept.Location = new Point(639, 5);
            btnDeleteDept.Name = "btnDeleteDept";
            btnDeleteDept.Size = new Size(94, 29);
            btnDeleteDept.TabIndex = 3;
            btnDeleteDept.Text = "Delete";
            btnDeleteDept.UseVisualStyleBackColor = true;
            btnDeleteDept.Click += btnDeleteDept_Click;
            // 
            // btnAddDept
            // 
            btnAddDept.Location = new Point(539, 5);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(94, 29);
            btnAddDept.TabIndex = 2;
            btnAddDept.Text = "Add";
            btnAddDept.UseVisualStyleBackColor = true;
            btnAddDept.Click += btnAddDept_Click;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(6, 6);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.PlaceholderText = "Type Department name...";
            txtDeptName.Size = new Size(527, 27);
            txtDeptName.TabIndex = 1;
            // 
            // dgvDepartments
            // 
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Location = new Point(6, 39);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(727, 275);
            dgvDepartments.TabIndex = 0;
            // 
            // tabRequirements
            // 
            tabRequirements.Controls.Add(btnDeleteReq);
            tabRequirements.Controls.Add(btnAddReq);
            tabRequirements.Controls.Add(txtReqName);
            tabRequirements.Controls.Add(dgvRequirements);
            tabRequirements.Location = new Point(4, 29);
            tabRequirements.Name = "tabRequirements";
            tabRequirements.Padding = new Padding(3);
            tabRequirements.Size = new Size(739, 320);
            tabRequirements.TabIndex = 1;
            tabRequirements.Text = "Requirement Types";
            tabRequirements.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReq
            // 
            btnDeleteReq.Location = new Point(639, 7);
            btnDeleteReq.Name = "btnDeleteReq";
            btnDeleteReq.Size = new Size(94, 29);
            btnDeleteReq.TabIndex = 3;
            btnDeleteReq.Text = "Delete";
            btnDeleteReq.UseVisualStyleBackColor = true;
            btnDeleteReq.Click += btnDeleteReq_Click;
            // 
            // btnAddReq
            // 
            btnAddReq.Location = new Point(539, 7);
            btnAddReq.Name = "btnAddReq";
            btnAddReq.Size = new Size(94, 29);
            btnAddReq.TabIndex = 2;
            btnAddReq.Text = "Add";
            btnAddReq.UseVisualStyleBackColor = true;
            btnAddReq.Click += btnAddReq_Click;
            // 
            // txtReqName
            // 
            txtReqName.Location = new Point(6, 7);
            txtReqName.Name = "txtReqName";
            txtReqName.PlaceholderText = "Type Requirement type...";
            txtReqName.Size = new Size(527, 27);
            txtReqName.TabIndex = 1;
            // 
            // dgvRequirements
            // 
            dgvRequirements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequirements.Location = new Point(6, 40);
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.RowHeadersWidth = 51;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(727, 285);
            dgvRequirements.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(27, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            Name = "Maintenance";
            Text = "Maintenance";
            Load += Maintenance_Load;
            tabControl1.ResumeLayout(false);
            tabDepartments.ResumeLayout(false);
            tabDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            tabRequirements.ResumeLayout(false);
            tabRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tabDepartments;
        private TabPage tabRequirements;
        private DataGridView dgvDepartments;
        private TextBox txtDeptName;
        private Button btnDeleteDept;
        private Button btnAddDept;
        private Button btnDeleteReq;
        private Button btnAddReq;
        private TextBox txtReqName;
        private DataGridView dgvRequirements;
        private Button btnBack;
    }
}