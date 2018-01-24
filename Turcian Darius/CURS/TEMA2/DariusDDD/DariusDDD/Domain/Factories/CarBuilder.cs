using System;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Factories.Interfaces;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Factories
{
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car;

        public CarBuilder(decimal price, TypeTransmission transmission, Fuel fuel, int year, string employer, DateTime createdDate)
        {
            if(year < 1990) throw new Exception("Year Error");
            _car = new Car(price, transmission, fuel, year, employer, createdDate);
        }

        public Car Build()
        {
            return _car;
        }

        public void SetColor(string color)
        {
            _car.Color = color;
        }

        public void SetFuel(Fuel fuel)
        {
            _car.Fuel = fuel;
        }

        public void SetModel(CarModel model)
        {
            _car.Model = model;
        }

        public void SetPower(int power)
        {
            _car.Power = power;
        }

        public void SetPrice(decimal price)
        {
            _car.Price = price;
        }

        public void SetTransmission(TypeTransmission transmission)
        {
            _car.Transmission = transmission;
        }

        public void SetYear(int year)
        {
            _car.Year = year;
        }
    }
}
