using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class InterviewSchedule : Form
    {
        private int _applicationID;

        public InterviewSchedule(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }

        private void InterviewSchedule_Load(object sender, EventArgs e)
        {
            // TODO: Load applicant information
            // TODO: Populate available interviewers
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            // TODO: Validate interview schedule inputs
            // TODO: Insert interview record into Interviews table
            // TODO: Update application status to 'Interview Scheduled'
            // TODO: Log status change into ApplicationStatusHistory
            // TODO: Notify applicant about interview schedule
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: Close form without saving changes
        }
    }
}
