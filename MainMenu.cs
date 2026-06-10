using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Forms.HR;
using FinalsHRApplicantProcessWindowsApplication.Forms.Applicant;

namespace FinalsHRApplicantProcessWindowsApplication
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            ApplicantLogin applicantLogin = new ApplicantLogin();
            applicantLogin.Show();
            this.Hide();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HRLogin hrLogin = new HRLogin();
            hrLogin.Show();
            this.Hide();
        }
    }
}
