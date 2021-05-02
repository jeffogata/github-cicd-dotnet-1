namespace Client.Tests
{
    using System;
    using Xunit;

    public class InputParserTests
    {
        [Fact]
        public void ParseInputWithAddInputParsesToExpectedResult()
        {
            // arrange
            var parser = new InputParser();
            var input = "add 123 456";
            var expected = new CalculatorInput(Operation.Add, 123, 456);

            // act
            var actual = parser.ParseInput(input);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseInputWithSubtractInputParsesToExpectedResult()
        {
            // arrange
            var parser = new InputParser();
            var input = "sub 25 10";
            var expected = new CalculatorInput(Operation.Subtract, 25, 10);

            // act
            var actual = parser.ParseInput(input);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseInputSetsLastInput()
        {
            // arrange
            var parser = new InputParser();
            var expected = "add 123 456";

            // act
            parser.ParseInput(expected);
            var actual = parser.LastInput;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ParseInputWithEmptyStringThrowsArgumentException()
        {
            // arrange
            var parser = new InputParser();

            // act
            var exception = Assert.Throws<ArgumentException>(() => parser.ParseInput(string.Empty));

            // assert
            Assert.NotNull(exception);
        }
    }
}
