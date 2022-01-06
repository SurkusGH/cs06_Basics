using System;

namespace cs06_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            double res2 = 0;

            res2 = (double)(4.0 / 3 * Math.PI * 6371 * 6371 * 6371);

            Console.WriteLine(res2);



            double a = 10;
            double b = 15;

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);
            double res3 = Math.Sqrt(c);
            Console.WriteLine(c);

            Console.WriteLine($"4: {(res1 + res2 + res3) / 3}");

        }
    }
}

