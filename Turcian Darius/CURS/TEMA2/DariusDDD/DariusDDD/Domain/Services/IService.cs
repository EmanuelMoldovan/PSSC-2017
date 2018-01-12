using System;
using System.Collections.Generic;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Services
{
    public interface IService
    {
        void AddCar(Car car);
        Car GetCar(int id);
        List<Car> GetCars(CarModel model);
        List<Car> GetCars(int year);
        List<Car> GetCars(decimal minPrice, decimal maxPrice);

        Employer GetEmployer(Guid guid);
        void AddEmployer(Employer employer);

        void AddOrder(Order order);
        List<Order> GetOrders();
    }
}
