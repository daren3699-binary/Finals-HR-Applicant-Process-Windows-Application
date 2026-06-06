using System;

namespace FinalsHRApplicantProcessWindowsApplication.Models
{
    public class ApplicantModel
    {
        public int ApplicantID { get; set; }
        public int ApplicantAccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }
}