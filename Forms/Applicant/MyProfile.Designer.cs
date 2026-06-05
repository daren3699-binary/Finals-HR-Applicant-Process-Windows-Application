namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    partial class MyProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnSave = new Button();
            pnlDivider = new Panel();
            pnlScrollWrapper = new Panel();

            // --- Personal Information ---
            grpPersonal = new GroupBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblCivilStatus = new Label();
            cmbCivilStatus = new ComboBox();
            lblNationality = new Label();
            txtNationality = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();

            // --- Address ---
            grpAddress = new GroupBox();
            lblStreet = new Label();
            txtStreet = new TextBox();
            lblBarangay = new Label();
            txtBarangay = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblProvince = new Label();
            txtProvince = new TextBox();
            lblZipCode = new Label();
            txtZipCode = new TextBox();

            // --- Education ---
            grpEducation = new GroupBox();
            lblSchool = new Label();
            txtSchool = new TextBox();
            lblDegree = new Label();
            txtDegree = new TextBox();
            lblYearGraduated = new Label();
            txtYearGraduated = new TextBox();

            // --- Skills ---
            grpSkills = new GroupBox();
            lblSkills = new Label();
            txtSkills = new TextBox();

            // --- Work Experience ---
            grpWorkExp = new GroupBox();
            lblCompany = new Label();
            txtCompany = new TextBox();
            lblJobTitle = new Label();
            txtJobTitle = new TextBox();
            lblWorkFrom = new Label();
            txtWorkFrom = new TextBox();
            lblWorkTo = new Label();
            txtWorkTo = new TextBox();
            lblWorkRemarks = new Label();
            txtWorkRemarks = new TextBox();

            pnlHeader.SuspendLayout();
            grpPersonal.SuspendLayout();
            grpAddress.SuspendLayout();
            grpEducation.SuspendLayout();
            grpSkills.SuspendLayout();
            grpWorkExp.SuspendLayout();
            SuspendLayout();

            // -------------------------------------------------------
            // pnlHeader
            // -------------------------------------------------------
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.None;
            pnlHeader.Controls.Add(btnSave);
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(40, 0, 40, 0);
            pnlHeader.Size = new Size(1060, 80);
            pnlHeader.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(40, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Profile";

            // lblSubTitle
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(42, 50);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "View and update your personal information.";

            // btnSave
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(70, 130, 180);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(920, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // -------------------------------------------------------
            // pnlDivider
            // -------------------------------------------------------
            pnlDivider.BackColor = Color.FromArgb(220, 220, 220);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 80);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(1060, 1);
            pnlDivider.TabIndex = 1;

            // -------------------------------------------------------
            // pnlScrollWrapper
            // -------------------------------------------------------
            pnlScrollWrapper.AutoScroll = true;
            pnlScrollWrapper.BackColor = Color.FromArgb(247, 248, 250);
            pnlScrollWrapper.Dock = DockStyle.Fill;
            pnlScrollWrapper.Location = new Point(0, 81);
            pnlScrollWrapper.Name = "pnlScrollWrapper";
            pnlScrollWrapper.Padding = new Padding(40, 20, 40, 20);
            pnlScrollWrapper.TabIndex = 2;

            // -------------------------------------------------------
            // grpPersonal - Personal Information
            // -------------------------------------------------------
            grpPersonal.BackColor = Color.White;
            grpPersonal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPersonal.ForeColor = Color.FromArgb(70, 130, 180);
            grpPersonal.Location = new Point(40, 20);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Padding = new Padding(20, 10, 20, 10);
            grpPersonal.Size = new Size(960, 260);
            grpPersonal.TabIndex = 0;
            grpPersonal.Text = "Personal Information";

            int col1 = 20, col2 = 330, col3 = 640;
            int row1 = 35, row2 = 100, row3 = 165, row4 = 220;

            // Row 1
            SetLabel(lblFirstName, "First Name", col1, row1, grpPersonal);
            SetTextBox(txtFirstName, "txtFirstName", col1, row1 + 22, 280, grpPersonal, 0);

            SetLabel(lblLastName, "Last Name", col2, row1, grpPersonal);
            SetTextBox(txtLastName, "txtLastName", col2, row1 + 22, 280, grpPersonal, 1);

            SetLabel(lblMiddleName, "Middle Name", col3, row1, grpPersonal);
            SetTextBox(txtMiddleName, "txtMiddleName", col3, row1 + 22, 280, grpPersonal, 2);

            // Row 2
            SetLabel(lblDateOfBirth, "Date of Birth", col1, row2, grpPersonal);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(col1, row2 + 22);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(280, 28);
            dtpDateOfBirth.TabIndex = 3;
            grpPersonal.Controls.Add(dtpDateOfBirth);

            SetLabel(lblGender, "Gender", col2, row2, grpPersonal);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            cmbGender.Location = new Point(col2, row2 + 22);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(280, 28);
            cmbGender.TabIndex = 4;
            cmbGender.Font = new Font("Segoe UI", 10F);
            grpPersonal.Controls.Add(cmbGender);

            SetLabel(lblCivilStatus, "Civil Status", col3, row2, grpPersonal);
            cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Widowed", "Separated" });
            cmbCivilStatus.Location = new Point(col3, row2 + 22);
            cmbCivilStatus.Name = "cmbCivilStatus";
            cmbCivilStatus.Size = new Size(280, 28);
            cmbCivilStatus.TabIndex = 5;
            cmbCivilStatus.Font = new Font("Segoe UI", 10F);
            grpPersonal.Controls.Add(cmbCivilStatus);

            // Row 3
            SetLabel(lblNationality, "Nationality", col1, row3, grpPersonal);
            SetTextBox(txtNationality, "txtNationality", col1, row3 + 22, 280, grpPersonal, 6);

            SetLabel(lblPhone, "Phone Number", col2, row3, grpPersonal);
            SetTextBox(txtPhone, "txtPhone", col2, row3 + 22, 280, grpPersonal, 7);

            SetLabel(lblEmail, "Email Address", col3, row3, grpPersonal);
            SetTextBox(txtEmail, "txtEmail", col3, row3 + 22, 280, grpPersonal, 8);
            txtEmail.ReadOnly = true;
            txtEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtEmail.ForeColor = Color.Gray;

            // -------------------------------------------------------
            // grpAddress - Address
            // -------------------------------------------------------
            grpAddress.BackColor = Color.White;
            grpAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAddress.ForeColor = Color.FromArgb(70, 130, 180);
            grpAddress.Location = new Point(40, 300);
            grpAddress.Name = "grpAddress";
            grpAddress.Padding = new Padding(20, 10, 20, 10);
            grpAddress.Size = new Size(960, 170);
            grpAddress.TabIndex = 1;
            grpAddress.Text = "Address";

            int aRow1 = 35, aRow2 = 100;

            SetLabel(lblStreet, "Street / House No.", col1, aRow1, grpAddress);
            SetTextBox(txtStreet, "txtStreet", col1, aRow1 + 22, 580, grpAddress, 9);

            SetLabel(lblZipCode, "Zip Code", col3, aRow1, grpAddress);
            SetTextBox(txtZipCode, "txtZipCode", col3, aRow1 + 22, 280, grpAddress, 10);

            SetLabel(lblBarangay, "Barangay", col1, aRow2, grpAddress);
            SetTextBox(txtBarangay, "txtBarangay", col1, aRow2 + 22, 280, grpAddress, 11);

            SetLabel(lblCity, "City / Municipality", col2, aRow2, grpAddress);
            SetTextBox(txtCity, "txtCity", col2, aRow2 + 22, 280, grpAddress, 12);

            SetLabel(lblProvince, "Province", col3, aRow2, grpAddress);
            SetTextBox(txtProvince, "txtProvince", col3, aRow2 + 22, 280, grpAddress, 13);

            // -------------------------------------------------------
            // grpEducation - Education
            // -------------------------------------------------------
            grpEducation.BackColor = Color.White;
            grpEducation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEducation.ForeColor = Color.FromArgb(70, 130, 180);
            grpEducation.Location = new Point(40, 490);
            grpEducation.Name = "grpEducation";
            grpEducation.Padding = new Padding(20, 10, 20, 10);
            grpEducation.Size = new Size(960, 110);
            grpEducation.TabIndex = 2;
            grpEducation.Text = "Educational Background";

            SetLabel(lblSchool, "School / University", col1, 35, grpEducation);
            SetTextBox(txtSchool, "txtSchool", col1, 57, 580, grpEducation, 14);

            SetLabel(lblDegree, "Degree / Course", col3, 35, grpEducation);
            SetTextBox(txtDegree, "txtDegree", col3, 57, 280, grpEducation, 15);

            SetLabel(lblYearGraduated, "Year Graduated", col1, 95, grpEducation);
            // reposition year graduated below school
            lblYearGraduated.Location = new Point(col1, 95);
            txtYearGraduated.Location = new Point(col1, 117);
            txtYearGraduated.Name = "txtYearGraduated";
            txtYearGraduated.Size = new Size(180, 28);
            txtYearGraduated.TabIndex = 16;
            txtYearGraduated.Font = new Font("Segoe UI", 10F);
            grpEducation.Controls.Add(lblYearGraduated);
            grpEducation.Controls.Add(txtYearGraduated);
            grpEducation.Size = new Size(960, 165);

            // -------------------------------------------------------
            // grpSkills - Skills
            // -------------------------------------------------------
            grpSkills.BackColor = Color.White;
            grpSkills.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSkills.ForeColor = Color.FromArgb(70, 130, 180);
            grpSkills.Location = new Point(40, 675);
            grpSkills.Name = "grpSkills";
            grpSkills.Padding = new Padding(20, 10, 20, 10);
            grpSkills.Size = new Size(960, 110);
            grpSkills.TabIndex = 3;
            grpSkills.Text = "Skills";

            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Segoe UI", 9F);
            lblSkills.ForeColor = Color.Gray;
            lblSkills.Location = new Point(col1, 30);
            lblSkills.Text = "List your skills (comma-separated, e.g. C#, MySQL, Excel)";
            grpSkills.Controls.Add(lblSkills);

            txtSkills.Location = new Point(col1, 52);
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(900, 28);
            txtSkills.TabIndex = 17;
            txtSkills.Font = new Font("Segoe UI", 10F);
            grpSkills.Controls.Add(txtSkills);

            // -------------------------------------------------------
            // grpWorkExp - Work Experience
            // -------------------------------------------------------
            grpWorkExp.BackColor = Color.White;
            grpWorkExp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpWorkExp.ForeColor = Color.FromArgb(70, 130, 180);
            grpWorkExp.Location = new Point(40, 805);
            grpWorkExp.Name = "grpWorkExp";
            grpWorkExp.Padding = new Padding(20, 10, 20, 10);
            grpWorkExp.Size = new Size(960, 175);
            grpWorkExp.TabIndex = 4;
            grpWorkExp.Text = "Work Experience (Most Recent)";

            SetLabel(lblCompany, "Company Name", col1, 35, grpWorkExp);
            SetTextBox(txtCompany, "txtCompany", col1, 57, 580, grpWorkExp, 18);

            SetLabel(lblJobTitle, "Job Title / Position", col3, 35, grpWorkExp);
            SetTextBox(txtJobTitle, "txtJobTitle", col3, 57, 280, grpWorkExp, 19);

            SetLabel(lblWorkFrom, "From (Year)", col1, 100, grpWorkExp);
            SetTextBox(txtWorkFrom, "txtWorkFrom", col1, 122, 180, grpWorkExp, 20);

            SetLabel(lblWorkTo, "To (Year / Present)", col2 - 130, 100, grpWorkExp);
            lblWorkTo.Location = new Point(col1 + 200, 100);
            txtWorkTo.Location = new Point(col1 + 200, 122);
            txtWorkTo.Name = "txtWorkTo";
            txtWorkTo.Size = new Size(180, 28);
            txtWorkTo.TabIndex = 21;
            txtWorkTo.Font = new Font("Segoe UI", 10F);
            grpWorkExp.Controls.Add(lblWorkTo);
            grpWorkExp.Controls.Add(txtWorkTo);

            SetLabel(lblWorkRemarks, "Remarks", col3, 100, grpWorkExp);
            SetTextBox(txtWorkRemarks, "txtWorkRemarks", col3, 122, 280, grpWorkExp, 22);

            // -------------------------------------------------------
            // Add groups to scroll wrapper
            // -------------------------------------------------------
            pnlScrollWrapper.Controls.Add(grpPersonal);
            pnlScrollWrapper.Controls.Add(grpAddress);
            pnlScrollWrapper.Controls.Add(grpEducation);
            pnlScrollWrapper.Controls.Add(grpSkills);
            pnlScrollWrapper.Controls.Add(grpWorkExp);

            // -------------------------------------------------------
            // MyProfile Form
            // -------------------------------------------------------
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 250);
            ClientSize = new Size(1060, 715);
            Controls.Add(pnlScrollWrapper);
            Controls.Add(pnlDivider);
            Controls.Add(pnlHeader);
            Name = "MyProfile";
            Text = "My Profile";
            Load += MyProfile_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            grpEducation.ResumeLayout(false);
            grpEducation.PerformLayout();
            grpSkills.ResumeLayout(false);
            grpSkills.PerformLayout();
            grpWorkExp.ResumeLayout(false);
            grpWorkExp.PerformLayout();
            ResumeLayout(false);
        }

        // Helper: set label properties and add to parent
        private void SetLabel(Label lbl, string text, int x, int y, Control parent)
        {
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9F);
            lbl.ForeColor = Color.FromArgb(80, 80, 80);
            lbl.Location = new Point(x, y);
            lbl.Text = text;
            parent.Controls.Add(lbl);
        }

        // Helper: set textbox properties and add to parent
        private void SetTextBox(TextBox txt, string name, int x, int y, int width, Control parent, int tabIndex)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10F);
            txt.Location = new Point(x, y + 2);
            txt.Name = name;
            txt.Size = new Size(width, 28);
            txt.TabIndex = tabIndex;
            parent.Controls.Add(txt);
        }

        // --- Field declarations ---
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubTitle;
        private Button btnSave;
        private Panel pnlDivider;
        private Panel pnlScrollWrapper;

        private GroupBox grpPersonal;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblCivilStatus;
        private ComboBox cmbCivilStatus;
        private Label lblNationality;
        private TextBox txtNationality;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;

        private GroupBox grpAddress;
        private Label lblStreet;
        private TextBox txtStreet;
        private Label lblBarangay;
        private TextBox txtBarangay;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblProvince;
        private TextBox txtProvince;
        private Label lblZipCode;
        private TextBox txtZipCode;

        private GroupBox grpEducation;
        private Label lblSchool;
        private TextBox txtSchool;
        private Label lblDegree;
        private TextBox txtDegree;
        private Label lblYearGraduated;
        private TextBox txtYearGraduated;

        private GroupBox grpSkills;
        private Label lblSkills;
        private TextBox txtSkills;

        private GroupBox grpWorkExp;
        private Label lblCompany;
        private TextBox txtCompany;
        private Label lblJobTitle;
        private TextBox txtJobTitle;
        private Label lblWorkFrom;
        private TextBox txtWorkFrom;
        private Label lblWorkTo;
        private TextBox txtWorkTo;
        private Label lblWorkRemarks;
        private TextBox txtWorkRemarks;
    }
}
