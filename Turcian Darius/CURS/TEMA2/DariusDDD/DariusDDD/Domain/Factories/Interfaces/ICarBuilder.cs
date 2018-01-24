using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Factories.Interfaces
{
    public interface ICarBuilder
    {
        void SetModel(CarModel model);
        void SetPrice(decimal price);
        void SetColor(string color);
        void SetPower(int power);
        void SetTransmission(TypeTransmission transmission);
        void SetFuel(Fuel fuel);
        void SetYear(int year);

        Car Build();
    }
}
