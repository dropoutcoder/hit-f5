using HitF5.Factorial;
using System;
using System.Threading.Tasks;

namespace HitF5.Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            var calculator = new FactorialCalculator();

            do
            {
                if (Int32.TryParse(line, out var value))
                {
                    var result = calculator.Calculate(value);

                    Console.WriteLine($"Faktoriál hodnoty {value} je {result}!");
                }

                Console.WriteLine($"Zadejte hodnotu pro výpočet faktoriálu:");
                line = Console.ReadLine();
            } while (line.ToLower() != "y");
        }
    }
}
