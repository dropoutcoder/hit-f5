using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HitF5.Factorial
{
    [DebuggerDisplay("FactorialCalculator s minimem {minimum}.")]
    public class FactorialCalculator : IFactorialCalculator
    {
        public int Calculate(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            return Enumerable
                .Range(1, value)
                .Aggregate(1, (acc, cur) => acc *= cur);
        }
    }
}
