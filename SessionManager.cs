using System;
using System.IO;

namespace FinalsHRApplicantProcessWindowsApplication
{
    public static class SessionManager
    {
        private static readonly string SessionFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "HRApplicant", "session.dat"
        );

        public static void SaveSession(int accountID)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(SessionFile));
            File.WriteAllText(SessionFile, accountID.ToString());
        }

        public static int LoadSession()
        {
            if (!File.Exists(SessionFile)) return -1;
            if (int.TryParse(File.ReadAllText(SessionFile), out int id)) return id;
            return -1;
        }

        public static void ClearSession()
        {
            if (File.Exists(SessionFile)) File.Delete(SessionFile);
        }
    }
}