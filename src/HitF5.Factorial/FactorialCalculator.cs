using System.Diagnostics;
using System.Numerics;

namespace HitF5.Factorial
{
    [DebuggerDisplay("FactorialCalculator s minimem {Minimum}.")]
    public class FactorialCalculator : IFactorialCalculator
    {
        private const int Minimum = 1;

        public BigInteger Calculate(int value)
        {
            if (value <= Minimum)
            {
                return Minimum;
            }

            var bi = new BigInteger(1);
            var factorial = value;
            for (var i = 1; i <= factorial; i++)
            {
                bi *= i;
            }

            return bi;
        }
    }
}
