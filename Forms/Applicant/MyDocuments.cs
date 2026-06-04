using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Database;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    public partial class MyDocuments : Form
    {
        private int _applicantID;

        public MyDocuments(int applicantID)
        {
            InitializeComponent();
            _applicantID = applicantID;
        }

        private void MyDocuments_Load(object sender, EventArgs e)
        {
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            // TODO: Load uploaded documents for current applicant
            // Display Document Type, File Name, Upload Date
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // TODO: Open file dialog
            // Upload selected document
            // Save document information to database
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Delete selected document
            // Remove file record from database
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // TODO: Open selected document
            // Display file for viewing
        }
    }
}