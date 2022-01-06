using System;

namespace cs06_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs06_paskaita!");

            Console.WriteLine("zemes skritulio plotas");

            double r = 6371;

            double res1 = 4 * Math.PI * Math.Pow(6371, 2);

            Console.WriteLine(res1);

        }
    }
}

