using FinalsHRApplicantProcessWindowsApplication.Forms.Applicant;

namespace FinalsHRApplicantProcessWindowsApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new ApplicantLogin());  
        }
    }
}