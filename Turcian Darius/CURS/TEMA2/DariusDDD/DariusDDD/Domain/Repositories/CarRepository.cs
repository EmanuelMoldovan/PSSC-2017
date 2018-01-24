using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories.Interfaces;

namespace DariusDDD.Domain.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly SqlConnection _conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Work\AC_an4\PSSC\DariusDDD\DariusDDD\Database.mdf;Integrated Security=True");

        //public CarRepository()
        //{
        //    if(_conn.State == ConnectionState.Closed)
        //        _conn.Open();
        //}

        public void AddCar(Car car)
        {
            _conn.Open();
            using (var com = new SqlCommand("INSERT INTO Cars  VALUES (@created, @creator, @price, @color, @power, @trans, @fuel, @year, @model)", _conn))
            {
                com.Parameters.AddWithValue("@created", car.CreatedDate);
                com.Parameters.AddWithValue("@creator", car.Creator);
                com.Parameters.AddWithValue("@price", car.Price);
                com.Parameters.AddWithValue("@color", car.Color);
                com.Parameters.AddWithValue("@power", car.Power);
                com.Parameters.AddWithValue("@trans", ((int)car.Transmission).ToString());
                com.Parameters.AddWithValue("@fuel", ((int)car.Fuel).ToString());
                com.Parameters.AddWithValue("@year", car.Year);
                com.Parameters.AddWithValue("@model", ((int)car.Model).ToString());

                com.ExecuteNonQuery();
                _conn.Close();
            }
        }

        public Car LoadCarById(int id)
        {
            _conn.Open();
            Car car;
            var command = "SELECT * FROM Cars WHERE Id = @id";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@id", id);
                var reader = com.ExecuteReader();
                reader.Read();
                
                var trans = (TypeTransmission)int.Parse(reader["Transmission"].ToString());
                var fuel = (Fuel)int.Parse(reader["Fuel"].ToString());
                var model = (CarModel)int.Parse(reader["Model"].ToString());

                car = new Car((decimal) reader["Price"], trans,
                    fuel, (int) reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                {
                    Color = reader["Color"].ToString(),
                    Power = (int) reader["Power"],
                    CreatedDate = (DateTime)reader["CreatedDate"],
                    Creator = reader["Creator"].ToString(),
                    Model = model
                };
                _conn.Close();
            }

            return car;
        }

        public List<Car> QueryCarsByModel(CarModel model)
        {
            _conn.Open();
            var cars = new List<Car>();
            var command = "SELECT * FROM Cars WHERE Model = @model";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@model", model.ToString());
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var trans = (TypeTransmission)int.Parse(reader["Transmission"].ToString());
                    var fuel = (Fuel)int.Parse(reader["Fuel"].ToString());
                    var modelR = (CarModel)int.Parse(reader["Model"].ToString());

                    var car = new Car((decimal) reader["Price"], trans, fuel,
                        (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                        Power = (int) reader["Power"],
                        CreatedDate = (DateTime) reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = modelR
                    };
                    cars.Add(car);
                }
                _conn.Close();
            }

            return cars;
        }

        public List<Car> QueryCarsByPrice(decimal minPrice, decimal maxPrice)
        {
            _conn.Open();
            var cars = new List<Car>();
            var command = "SELECT * FROM Cars WHERE Price >= @min AND Price <= @max";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@min", minPrice);
                com.Parameters.AddWithValue("@max", maxPrice);
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var trans = (TypeTransmission)int.Parse(reader["Transmission"].ToString());
                    var fuel = (Fuel)int.Parse(reader["Fuel"].ToString());
                    var model = (CarModel)int.Parse(reader["Model"].ToString());

                    var car = new Car((decimal)reader["Price"], trans,
                        fuel, (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                        Power = (int)reader["Power"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = model
                    };
                    cars.Add(car);
                }
                _conn.Close();
            }

            return cars;
        }

        public List<Car> QueryCarsByYear(int year)
        {
            _conn.Open();
            var cars = new List<Car>();
            var command = "SELECT * FROM Cars WHERE Year = @year";
            using (var com = new SqlCommand(command, _conn))
            {
                com.Parameters.AddWithValue("@year", year);
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var price = (decimal)reader["Price"];
                    var trans = (TypeTransmission)int.Parse(reader["Transmission"].ToString());
                    var fuel = (Fuel)int.Parse(reader["Fuel"].ToString());
                    var model = (CarModel)int.Parse(reader["Model"].ToString());
                    var car = new Car(price, trans, fuel, (int)reader["Year"], reader["Creator"].ToString(), (DateTime)reader["CreatedDate"])
                    {
                        Color = reader["Color"].ToString(),
                        Power = (int)reader["Power"],
                        CreatedDate = (DateTime)reader["CreatedDate"],
                        Creator = reader["Creator"].ToString(),
                        Model = model
                    };
                    cars.Add(car);
                }
                _conn.Close();
            }

            return cars;
        }
    }
}
