using System.Collections.Generic;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Car LoadCarById(int id);
        void AddCar(Car car);

        List<Car> QueryCarsByModel(CarModel model);
        List<Car> QueryCarsByYear(int year);
        List<Car> QueryCarsByPrice(decimal minPrice, decimal maxPrice);
    }
}
