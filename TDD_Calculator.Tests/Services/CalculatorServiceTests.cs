using System.Diagnostics.CodeAnalysis;
using TDD_Calculator.Services;

namespace TDD_Calculator.Tests.Services
{
    [ExcludeFromCodeCoverage]
    public class CalculatorServiceTests
    {
        [Fact]
        //public void Add_ShouldReturnResult_When_ValidInputsInserted()
        public void Add_ShouldReturnSum_WhenTwoNumbersAreProvided()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act

            var result = calculatorService.Add(2, 3);

            //assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ShouldReturnSum_WhenNegativeNumbersAreProvided()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Add(2, -3);

            //assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Add_ShouldReturnSum_WhenOneNumberIsZero()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Add(0, 2);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_ShouldHandleOverflow_WhenNumbersAreTooLarge()
        {
            //arrange
            var calculationService = new CalculatorService();

            //act + assert
            Assert.Throws<OverflowException>(() => calculationService.Add(int.MaxValue, 2));
        }
    }
}
