using System;
using System.Collections.Generic;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories;
using DariusDDD.Domain.Repositories.Interfaces;
using DariusDDD.Domain.Services;
using Moq;
using Xunit;

namespace DariusDDD.Tests
{
    public class ServiceTest
    {
        [Fact]
        public void TestAddCar_success()
        {
            var car = new Car(1000, TypeTransmission.Double, Fuel.Benzine, 2005, "darius", DateTime.Now);
            ICarRepository repository = new CarRepository();
            var service = new Service(repository);
            var cars = service.GetCars(2005);
            
            service.AddCar(car);

            Assert.Equal(cars.Count + 1, service.GetCars(2005).Count);
        }

        [Fact]
        public void TestGetCarsByYear_success()
        {
            var mockRepository = new Mock<ICarRepository>();
            mockRepository.Setup(m => m.QueryCarsByYear(2005)).Returns(new List<Car>());
            var service = new Service(mockRepository.Object);
            var cars = service.GetCars(2005);

            Assert.Empty(cars);
        }

        [Fact]
        public void TestGetCarsByModel_success()
        {
            var car = new Car(1000, TypeTransmission.Double, Fuel.Benzine, 2005, "darius", DateTime.Now){Model = CarModel.Duster};
            var mockRepository = new Mock<ICarRepository>();
            mockRepository.Setup(m => m.QueryCarsByModel(CarModel.Duster)).Returns(new List<Car>(){car});
            var service = new Service(mockRepository.Object);
            var cars = service.GetCars(CarModel.Duster);

            Assert.Single(cars);
        }

        [Fact]
        public void TestGetCarsByPrice_success()
        {
            var car1 = new Car(1000, TypeTransmission.Double, Fuel.Benzine, 2005, "darius", DateTime.Now);
            var car2 = new Car(1500, TypeTransmission.Front, Fuel.Diesel, 2005, "darius", DateTime.Now);
            var mockRepository = new Mock<ICarRepository>();
            mockRepository.Setup(m => m.QueryCarsByPrice(100, 2000)).Returns(new List<Car>(){car1, car2});
            var service = new Service(mockRepository.Object);
            var cars = service.GetCars(100, 2000);

            Assert.Equal(2, cars.Count);
        }
    }
}
