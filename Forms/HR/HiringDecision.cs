using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class HiringDecision : Form
    {
        private int _applicationID;

        public HiringDecision(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }

        private void HiringDecision_Load(object sender, EventArgs e)
        {
            // TODO: Load applicant profile
            // TODO: Load interview evaluation results
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // TODO: Validate hiring decision requirements
            // TODO: Update application status to 'Hired'
            // TODO: Create employee record if required
            // TODO: Log status change into ApplicationStatusHistory
            // TODO: Notify applicant of hiring result
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            // TODO: Validate rejection remarks
            // TODO: Update application status to 'Rejected'
            // TODO: Log status change into ApplicationStatusHistory
            // TODO: Notify applicant of rejection result
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: Close form without saving decision
        }
    }
}
