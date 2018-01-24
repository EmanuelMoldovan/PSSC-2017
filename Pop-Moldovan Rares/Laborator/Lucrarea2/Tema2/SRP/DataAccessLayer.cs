using System;
using System.Data.SqlClient;

namespace Examples.SRP
{
    public class DataAccessLayer
    {
        public void StoreUserInfo(string encPassword, string encUserName)
        {
            using (SqlConnection sql = new SqlConnection("connection-string"))
            {
                sql.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO ... ";
                command.Parameters.Add(encPassword);
                command.Parameters.Add(encUserName);
                command.BeginExecuteNonQuery();
            }
        }
    }
}