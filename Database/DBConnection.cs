using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FinalsHRApplicantProcessWindowsApplication.Database
{
    public class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["HRAppDB"].ConnectionString;
            return new MySqlConnection(connStr);
        }
    }
}   
