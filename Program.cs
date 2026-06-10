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
            Application.Run(new MainMenu());
        }
    }
}