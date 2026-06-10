using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Forms.HR;
using FinalsHRApplicantProcessWindowsApplication.Forms.Applicant;
using FinalsHRApplicantProcessWindowsApplication.Helpers;

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
            int savedID = SessionManager.LoadSession();

            if (savedID != -1)
            {
                ApplicantDashboard dashboard = new ApplicantDashboard(savedID);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                ApplicantLogin applicantLogin = new ApplicantLogin();
                applicantLogin.Show();
                this.Hide();
            }
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HRLogin hrLogin = new HRLogin();
            hrLogin.Show();
            this.Hide();
        }
    }
}
