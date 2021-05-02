namespace Core.Tests
{
    using Xunit;

    public class CalculatorTests
    {
        [Fact]
        public void AddShouldReturnExpectedSum()
        {
            // arrange
            var calculator = new Calculator();
            var expected = 8;

            // act
            var actual = calculator.Add(3, 5);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddShouldSetLastResult()
        {
            // arrange
            var calculator = new Calculator();
            var expected = 17;

            // act
            calculator.Add(3, 5);
            calculator.Add(9, 8);

            var actual = calculator.LastResult;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
