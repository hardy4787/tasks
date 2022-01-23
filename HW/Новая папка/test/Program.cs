using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажи радиус окружности  ");
            double r = double.Parse(Console.ReadLine());
            const double P = 3.14;
            double square = Math.Pow(r, 2) * P;
            double lenghtSirkl = 2 * r * P;
            Console.WriteLine("Длина окружности равна {0} м., а площаь равна {1} м2", Math.Round(lenghtSirkl, 2), square);
            Console.ReadKey();
        }
       
    }
}
