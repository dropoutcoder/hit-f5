using System;
using System.Numerics;

namespace HitF5.Factorial
{
    public class FactorialCalculator : IFactorialCalculator
    {
        public BigInteger Calculate(int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Value has to be non-negative.");

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
