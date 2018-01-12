using System;

namespace DariusDDD.Infrastructure
{
    public class CalculatorManager
    {
        private readonly decimal _fuelValue;
        private readonly decimal _powerValue;
        private readonly decimal _yearValue;
        private readonly decimal _price;

        public CalculatorManager(decimal price, int power, int year, string fuel)
        {
            _price = price;
            _fuelValue = (fuel == "diesel") ? 2.5m : (fuel == "benzine") ? 1 : -1;
            if(_fuelValue == -1) throw new Exception("Fuel Error");
            _powerValue = Convert.ToDecimal(power / 10);
            _yearValue = Convert.ToDecimal((DateTime.Now.Year - year) / 3);
        }

        public decimal CalculateTax()
        {
            return (2m / 100 * _price) * _fuelValue + (4m / 100 * _price) * _yearValue + _powerValue;
        }
    }
}
