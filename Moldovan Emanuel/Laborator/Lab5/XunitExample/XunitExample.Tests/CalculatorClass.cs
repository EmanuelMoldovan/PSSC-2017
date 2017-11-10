using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitExample.Tests
{
    public class CalculatorClass
    {
        private Mock<IExternalItem> _externalItemMock;
        public CalculatorClass()
        {
            _externalItemMock = new Mock<IExternalItem>();
            _externalItemMock.Setup(m => m.GetSomeExternalStuff()).Returns(5);
        }

        [Fact]
        public void ShouldComputeCorrectArithmeticSum()
        {
            // arrange
            var calculator = new Calculator();
            var testInput = new List<int>(){2, 3, 5, 5};

            // act
            var testResult = calculator.ComputeAritmeticSum(testInput, _externalItemMock.Object);

            // assert
            Assert.Equal(testResult, 5); // success
        }

        [Fact]
        public void ShouldThrowNullException()
        {
            // arrange
            var calculator = new Calculator();
            var nrContainer = new NumbersContainer();

            // act & assert
            Assert.Throws<NullReferenceException>(() => calculator.ComputeSpecialSum(nrContainer));
        }
    }
}
