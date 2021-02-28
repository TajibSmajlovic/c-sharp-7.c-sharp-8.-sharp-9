using System;

namespace _4_LocalFunctions
{
    public class EquationSolver
    {
        public static (double, double) SolveQuadratic(double a, double b, double c)
        {
            double CalculateDiscriminant() => b * b - 4 * a * c;

            var disc = CalculateDiscriminant();
            var rootDisc = Math.Sqrt(disc);

            return ((-b - rootDisc) / (2 * a), (-b + rootDisc) / (2 * a));
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var sl = EquationSolver.SolveQuadratic(1, 10, 16);

            Console.WriteLine(sl);
        }
    }
}