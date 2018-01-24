using DariusDDD.Infrastructure;
using System;
using Xunit;

namespace DariusDDD.Tests
{
    public class CalculatorManagerTest
    {
        [Fact]
        public void TestConstructor_success()
        {
            var expextedTax = 1477m;
            var calculator = new CalculatorManager(7000, 75, 2005, "diesel");

            var result = calculator.CalculateTax();

            Assert.Equal(expextedTax, result);
        }
        [Fact]
        public void TestConstructor_failed()
        {
            var expextedException = new Exception("Fuel Error");
            Exception e = null;
            try
            {
                var calculator = new CalculatorManager(7000, 75, 2005, "-");
            }
            catch (Exception ex)
            {
                e = ex;
            }

            Assert.NotNull(e);
            Assert.Equal(expextedException.Message, e.Message);
        }
    }
}
