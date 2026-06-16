using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using FinalsHRApplicantProcessWindowsApplication.Database;

namespace FinalsHRApplicantProcessWindowsApplication.Helpers
{
    public static class AuditLogger
    {
        public static void Log(string userType, int userID, string action, string affectedTable, int affectedID)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO AuditTrail 
                                    (UserType, UserID, Action, AffectedTable, AffectedID)
                                    VALUES (@ut, @uid, @action, @table, @aid)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ut", userType);
                        cmd.Parameters.AddWithValue("@uid", userID);
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@table", affectedTable);
                        cmd.Parameters.AddWithValue("@aid", affectedID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { /* audit failure should never crash the app */ }
        }
    }
}
