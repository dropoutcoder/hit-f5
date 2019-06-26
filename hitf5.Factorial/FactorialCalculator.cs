using System;
using System.Diagnostics;

namespace hitf5.Factorial
{
    //[DebuggerDisplay("FactorialCalculator s minimem {minimum}.")]
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
                return value * this.Calculate(this.GetNext(value));
            }
        }

        private int GetNext(int value)
        {
            return value - 1;
        }

        //public override string ToString()
        //{
        //    return "ToString";
        //}
    }
}
