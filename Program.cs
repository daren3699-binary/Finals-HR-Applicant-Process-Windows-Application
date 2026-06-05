using System;
using System.Windows.Forms;

namespace FinalsHRApplicantProcessWindowsApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            int savedID = SessionManager.LoadSession();
            if (savedID != -1)
            {
                Application.Run(new Forms.Applicant.ApplicantDashboard(savedID));
            }
            else
            {
                Application.Run(new Forms.Applicant.ApplicantLogin());
            }
        }
    }
}