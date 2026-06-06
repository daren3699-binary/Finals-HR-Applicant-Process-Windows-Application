using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace FinalsHRApplicantProcessWindowsApplication.Helpers
{
    public static class SessionManager
    {
        private const string RegKey = @"SOFTWARE\HRApplicantApp";

        public static void SaveSession(int applicantAccountID)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(RegKey);
                key?.SetValue("ApplicantAccountID", applicantAccountID);
                key?.Close();
            }
            catch { }
        }

        public static int LoadSession()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey);
                if (key != null)
                {
                    object val = key.GetValue("ApplicantAccountID");
                    key.Close();
                    if (val != null) return Convert.ToInt32(val);
                }
            }
            catch { }
            return -1;
        }

        public static void ClearSession()
        {
            try
            {
                Registry.CurrentUser.DeleteSubKey(RegKey, false);
            }
            catch { }
        }
    }
}
