using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class JobVacancies : Form
    {
        private int _applicantID;

        public JobVacancies(int applicantID)
        {
            InitializeComponent();
            _applicantID = applicantID;
        }

        private void JobVacancies_Load(object sender, EventArgs e)
        {
            LoadJobVacancies();
        }

        private void LoadJobVacancies()
        {
            // TODO: Load active job vacancies from JobVacancies table
            // Display Job Title, Department, Description, Requirements
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // TODO: Create application record for selected vacancy
            // Save ApplicantID and VacancyID
            // Set initial status to "Pending"
        }
    }
}