using System;
using System.Data;
using System.Data.SqlClient;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories.Interfaces;

namespace DariusDDD.Domain.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly SqlConnection _conn = new SqlConnection("Data Source = Database.mdf");

        //public EmployerRepository()
        //{
        //    if(_conn.State == ConnectionState.Closed)
        //        _conn.Open();
        //}

        public void AddEmployer(Employer employer)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Employers  VALUES (@guid, @name, @phone)", _conn))
            {
                com.Parameters.AddWithValue("@guid", Guid.NewGuid());
                com.Parameters.AddWithValue("@name", employer.Name);
                com.Parameters.AddWithValue("@phone", employer.Phone);

                com.ExecuteNonQuery();
                _conn.Close();
            }
        }

        public Employer LoadEmployerByGuid(Guid guid)
        {
            _conn.Open();
            Employer employer;
            var command = "SELECT * FROM Employers WHERE EmployerGuid = @guid";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@guid", guid);
                var reader = com.ExecuteReader();
                reader.Read();
                employer = new Employer(reader["Name"].ToString())
                {
                    EmployerGuid = (Guid)reader["EmployerGuid"],
                    Phone = reader["Phone"].ToString()
                };
                _conn.Close();
            }

            return employer;
        }
    }
}
