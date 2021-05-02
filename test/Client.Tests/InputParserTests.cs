namespace Client.Tests
{
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
    }
}
