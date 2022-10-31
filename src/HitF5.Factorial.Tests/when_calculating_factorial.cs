using System.Numerics;
using NUnit.Framework;
using Shouldly;

namespace HitF5.Factorial.Tests
{
    [TestFixture]
    public class when_calculating_factorial
    {
        protected static IEnumerable<TestCaseData> FactorialIsCalculatedCorrectlyTestCases()
        {
            yield return new TestCaseData(2, new BigInteger(2))
                .SetName("2");
            yield return new TestCaseData(3, new BigInteger(6))
                .SetName("3");
            yield return new TestCaseData(4, new BigInteger(24))
                .SetName("4");
            yield return new TestCaseData(50, BigInteger.Parse("30414093201713378043612608166064768844377641568960512000000000000"))
                .SetName("50");
        }
        [TestCaseSource(nameof(FactorialIsCalculatedCorrectlyTestCases))]
        public void factorial_is_calculated_correctly(int value, BigInteger expectedFactorialValue)
        {
            var factorial = new FactorialCalculator().Calculate(value);

            factorial.ShouldBe(expectedFactorialValue);
        }

        [TestCase(1)]
        [TestCase(0)]
        public void factorial_is_calculated_correctly_for_values_less_or_equal_to_one(int value)
        {
            var factorial = new FactorialCalculator().Calculate(value);
        
            factorial.ShouldBe(1);
        }
    }
}