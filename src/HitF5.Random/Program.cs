using HitF5.Factorial;
using System;
using System.Collections.Generic;

namespace HitF5.Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            var calculator = new FactorialCalculator();

            while (true)
            {
                var value = random.Next(1, 10);

                var result = calculator.Calculate(value);

                Console.WriteLine($"Faktoriál hodnoty {value} je {result}!");
            }
        }
    }
}
