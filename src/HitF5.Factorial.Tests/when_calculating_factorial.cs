using NUnit.Framework;
using Shouldly;

namespace HitF5.Factorial.Tests
{
    [TestFixture]
    public class when_calculating_factorial
    {
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void factorial_is_calculated_correctly(int value, int expectedFactorialValue)
        {
            var factorial = new FactorialCalculator().Calculate(value);

            factorial.ShouldBe(expectedFactorialValue);
        }
    }
}