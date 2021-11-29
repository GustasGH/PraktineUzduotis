using System;

namespace PraktineUzduots
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // s - plotas, v - turis, r - spindulys, a/b/c trikampio krastines
            double pi = Math.PI;
            double s;
            double r = 6371;
            double v;


            //Plotas 

            s = 4 * pi * (Math.Pow(r, 2));
            v = (4 * pi * (Math.Pow(r, 3)) / 3);

            Console.WriteLine($"Plotas :{Math.Round(s)}");
            Console.WriteLine($"Turis :{Math.Round(v)}");



        }
    }
}
