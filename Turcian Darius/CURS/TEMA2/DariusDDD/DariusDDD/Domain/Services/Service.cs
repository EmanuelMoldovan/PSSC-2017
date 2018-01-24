using System;
using System.Collections.Generic;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories.Interfaces;

namespace DariusDDD.Domain.Services
{
    public class Service : IService
    {
        private readonly ICarRepository _carRepository;
        private readonly IEmployerRepository _employerRepository;
        private readonly IOrderRepository _orderRepository;

        public Service(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Service(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public Service(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void AddEmployer(Employer employer)
        {
            _employerRepository.AddEmployer(employer);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }

        public Car GetCar(int id)
        {
            return _carRepository.LoadCarById(id);
        }

        public List<Car> GetCars(CarModel model)
        {
            return _carRepository.QueryCarsByModel(model);
        }

        public List<Car> GetCars(int year)
        {
            return _carRepository.QueryCarsByYear(year);
        }

        public List<Car> GetCars(decimal minPrice, decimal maxPrice)
        {
            return _carRepository.QueryCarsByPrice(minPrice, maxPrice);
        }

        public Employer GetEmployer(Guid guid)
        {
            return _employerRepository.LoadEmployerByGuid(guid);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.QueryOrders();
        }
    }
}
