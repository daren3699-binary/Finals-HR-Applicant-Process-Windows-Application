using System;

namespace FinalsHRApplicantProcessWindowsApplication.Models

{
    public class JobVacancyModel
    {
        public int JobVacancyID { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentID { get; set; }
        public string Description { get; set; }
        public string Qualifications { get; set; }
        public string EmploymentType { get; set; }
        public string Status { get; set; }
    }
}