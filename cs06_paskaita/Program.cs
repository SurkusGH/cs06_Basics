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


<<<<<<< Updated upstream
=======
            //Julius
            Console.WriteLine("Zemes Skritulio Plotas");

            double r = 6371;

            double res1 = 4 * Math.PI * Math.Pow(6371, 2);

            Console.WriteLine(res1);
>>>>>>> Stashed changes

            double a = 10;
            double b = 15;

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);
            double res3 = Math.Sqrt(c);
            Console.WriteLine(c);

            Console.WriteLine($"4: {(res1 + res2 + res3) / 3}");

            Console.WriteLine("zemes skritulio plotas");

            double r = 6371;

            double res1 = 4 * Math.PI * Math.Pow(6371, 2);

            Console.WriteLine(res1);

        }
    }
}

