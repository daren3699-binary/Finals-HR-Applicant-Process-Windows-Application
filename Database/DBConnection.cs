using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Database
{
    public class DBConnection
    {
        private static string connectionString = "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=Binary_3699;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}   
