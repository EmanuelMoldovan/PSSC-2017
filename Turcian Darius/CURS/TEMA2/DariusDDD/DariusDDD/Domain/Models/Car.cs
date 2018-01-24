using System;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Services.Entities;

namespace DariusDDD.Domain.Models
{
    public class Car : CarEntity
    {
        public Car(decimal price, TypeTransmission transmission, Fuel fuel, int year, string employerName, DateTime createdDate):base(createdDate, employerName)
        {
            Price = price;
            Transmission = transmission;
            Fuel = fuel;
            Year = year;

            Color = "White";
            Power = 75;
        }

        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public TypeTransmission Transmission { get; set; }
        public Fuel Fuel { get; set; }
        public int Year { get; set; }
        public CarModel Model { get; set; }
    }
}
