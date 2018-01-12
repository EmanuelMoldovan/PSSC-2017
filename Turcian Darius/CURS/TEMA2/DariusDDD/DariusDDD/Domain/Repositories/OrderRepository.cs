using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories.Interfaces;

namespace DariusDDD.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SqlConnection _conn = new SqlConnection("Data Source = Database.mdf");

        //public OrderRepository()
        //{
        //    if (_conn.State == ConnectionState.Closed)
        //        _conn.Open();
        //}

        public void AddOrder(Order order)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Cars  VALUES (@name, @email, @phone, @carId, @address, @date)", _conn))
            {
                com.Parameters.AddWithValue("@name", order.ClientName);
                com.Parameters.AddWithValue("@email", order.Email);
                com.Parameters.AddWithValue("@phone", order.Phone);
                com.Parameters.AddWithValue("@carId", order.CarId);
                com.Parameters.AddWithValue("@address", order.Address);
                com.Parameters.AddWithValue("@date", order.Date);

                com.ExecuteNonQuery();
                _conn.Close();
            }
        }

        public List<Order> QueryOrders()
        {
            _conn.Open();
            var cars = new List<Order>();
            var command = "SELECT * FROM Orders";
            using (var com = new SqlCommand(command, _conn))
            {
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var car = new Order(reader["ClientName"].ToString(), reader["Email"].ToString(), reader["Phone"].ToString(), (int)reader["CarId"], (DateTime)reader["Date"])
                    {
                        Id = (int)reader["Id"],
                        Address = reader["Address"].ToString(),
                        Date = (DateTime)reader["Date"]
                    };
                    cars.Add(car);
                }
                _conn.Close();
            }

            return cars;
        }
    }
}
