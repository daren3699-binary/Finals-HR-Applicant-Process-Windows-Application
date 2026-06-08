using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using FinalsHRApplicantProcessWindowsApplication.Helpers;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.HR
{
    public partial class InterviewEvaluation : Form
    {
        private int _interviewID;

        public InterviewEvaluation(int interviewID)
        {
            InitializeComponent();
            _interviewID = interviewID;
        }

        private void InterviewEvaluation_Load(object sender, EventArgs e)
        {
            // TODO: Load interview details for reference
            // TODO: Display applicant and interview information
        }

        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            // TODO: Validate evaluation inputs and score
            // TODO: Insert evaluation record into InterviewEvaluations table
            // TODO: Update interview status to 'Completed'
            // TODO: Update application status to 'For Final Review'
            // TODO: Log status change into ApplicationStatusHistory
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: Close form without saving evaluation
        }
    }
}
