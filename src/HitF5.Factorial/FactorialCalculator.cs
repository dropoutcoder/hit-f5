using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HitF5.Factorial
{
    [DebuggerDisplay("FactorialCalculator s minimem {minimum}.")]
    public class FactorialCalculator : IFactorialCalculator
    {
        private static readonly int minimum = 1;

        public int Calculate(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            if (value <= minimum)
            {
                return minimum;
            }
            else
            {
                return value * this.Calculate(this.GetNext(value));
            }
        }

        private int GetNext(int value)
        {
            return value - 1;
        }
    }
}
