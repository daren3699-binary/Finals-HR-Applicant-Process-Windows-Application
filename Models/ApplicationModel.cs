using System;

namespace FinalsHRApplicantProcessWindowsApplication.Models
{
    public class ApplicationModel
    {
        public int ApplicationID { get; set; }
        public int ApplicantID { get; set; }
        public int JobVacancyID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
    }
}