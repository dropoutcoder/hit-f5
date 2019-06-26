using System;
using System.Diagnostics;

namespace hitf5.Factorial
{
    //[DebuggerDisplay("Minimum je {minimum}")]
    public class FactorialCalculator : IFactorialCalculator
    {
        private static readonly int minimum = 1;

        public int Calculate(int value)
        {
            if (value <= minimum)
            {
                return minimum;
            }
            else
            {
                return value * this.Calculate(value - 1);
            }
        }

        public override string ToString()
        {
            return nameof(base.ToString);
        }
    }
}
