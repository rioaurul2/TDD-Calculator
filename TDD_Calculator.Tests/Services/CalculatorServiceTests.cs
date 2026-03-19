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
            var calculatorService = new CalculatorService();

            //act + assert
            Assert.Throws<OverflowException>(() => calculatorService.Add(int.MaxValue, 2));
        }

        [Fact]
        public void Subtract_ShouldReturnDifference_WhenTwoNumbersAreProvided()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Subtract(5, 2);

            //assert
            Assert.Equal(3, result);
        }


        [Fact]
        public void Subtract_ShouldReturnSameNumber_WhenSecondNumberIsZero()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Subtract(5, 0);

            //assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldThrowOverflowException_WhenResultExceedsIntMaxValue()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act + assert
            Assert.Throws<OverflowException>(() => calculatorService.Subtract(5, int.MinValue));
        }

        [Fact]
        public void Subtract_ShouldReturnNegative_WhenSecondNumberIsGreater()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Subtract(2, 5);

            //assert
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Multiply_ShouldReturnProduct_WhenTwoNumbersAreProvided()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Multiply(2, 5);

            //assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Multiply_ShouldReturnZero_WhenOneOfTheNumbersIsZero()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Multiply(2, 0);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_ShouldThrowOverflowException_WhenResultExceedsIntMaxValue()
        {
            //arrange
            var calculatorService = new CalculatorService();
          
            //act + assert
            Assert.Throws<OverflowException>(() => calculatorService.Multiply(int.MaxValue, 2));
        }

        [Fact]
        public void Divide_ShouldReturnQuotient_WhenTwoNumbersAreProvided()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Divide(4, 2);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ShouldReturnZero_WhenTheNumeratorIsZero()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act
            var result = calculatorService.Divide(0, 2);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException_WhenTheDenominatorIsZero()
        {
            //arrange
            var calculatorService = new CalculatorService();

            //act + assert
            Assert.Throws<DivideByZeroException>(() => calculatorService.Divide(10, 0));
        }
    }
}
