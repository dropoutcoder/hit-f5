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
            yield return new TestCaseData(0, new BigInteger(1))
                .SetName("0");
            yield return new TestCaseData(1, new BigInteger(1))
                .SetName("1");
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

        [Test]
        public void exception_is_thrown_for_negative_value()
        {
            var ex = Should.Throw<ArgumentOutOfRangeException>(() => new FactorialCalculator().Calculate(-1));
            
            ex.Message.ShouldBe("Value has to be non-negative. (Parameter 'value')");
        }
    }
}