using System;

namespace PraktineUzduots
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kintamieji: s - plotas, v - turis, r - spindulys, a/b/c trikampio krastines

            double a, b, c, x;

            a = 10;
            b = 15;

            // Istrizaines ilgis

            x = a * a + b * b;
            c = Math.Sqrt(x);
            Console.WriteLine($"Staciojo trikampio izambines ilgis: {c}");

        }
    }
}
