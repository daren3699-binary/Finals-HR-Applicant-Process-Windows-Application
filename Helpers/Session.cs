using System;
using System.Collections.Generic;
using System.Text;

namespace FinalsHRApplicantProcessWindowsApplication.Helpers
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentRole { get; set; }
    }
}
