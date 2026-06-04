using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class ApplicationStatus : Form
    {
        private int _applicantID;

        public ApplicationStatus(int applicantID)
        {
            InitializeComponent();
            _applicantID = applicantID;
        }

        private void ApplicationStatus_Load(object sender, EventArgs e)
        {
            LoadStatusHistory();
        }

        private void LoadStatusHistory()
        {
            // TODO: Load ApplicationStatusHistory records ordered by ChangedAt ASC
            // Display as a timeline: status, date, remarks
        }
    }
}