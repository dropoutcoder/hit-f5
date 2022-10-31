using Shouldly;

namespace HitF5.Factorial.Tests
{
    [TestFixture]
    public class when_calculating_factorial
    {
        private FactorialCalculator factorialCalculator;
        [SetUp]
        public void Setup()
        {
            factorialCalculator = new FactorialCalculator();
        }

        [Test]
        public void factorial_of_zero_is_one()
        {
            factorialCalculator.Calculate(0).ShouldBe(1);
        }

        [Test]
        public void negative_numbers_are_not_supported()
        {
            Should.Throw<ArgumentOutOfRangeException>(() => factorialCalculator.Calculate(-123));
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        public void factorial_of_positive_number_is_calculated_correctly(int value, int expectedResult)
        {
            var result = factorialCalculator.Calculate(value);
            result.ShouldBe(expectedResult);
        }
    }
}