using System;
using System.Windows.Forms;
using FinalsHRApplicantProcessWindowsApplication.Helpers;

namespace FinalsHRApplicantProcessWindowsApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}