namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CheckSumTwoNumbers()
        {
            checkSumTwoNumbers(5, 5);
            checkSumTwoNumbers(10, 20);
        }

        [Fact]
        public void CheckSubtractionTwoNumbers()
        {
            checkSubtractionTwoNumbers(5, 5);
            checkSubtractionTwoNumbers(20, 10);
            checkSubtractionTwoNumbers(10, 20);
        }

        private void checkSumTwoNumbers(int a, int b)
        {
            // Arrange
            string expression = $"{a}+{b}";
            Calculator calculator = new Calculator();
            int expected = a + b;

            // Act
            int result = calculator.Calculate(expression);

            // Assert
            Assert.Equal(expected, result);
        }

        private void checkSubtractionTwoNumbers(int a, int b)
        {
            // Arrange
            string expression = $"{a}-{b}";
            Calculator calculator = new Calculator();
            int expected = a - b;

            // Act
            int result = calculator.Calculate(expression);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}