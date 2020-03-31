using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, num, rebro;

            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("a of another triangle= ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("b of another triangle= ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter num= ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter rebro of triangle= ");
            rebro = Convert.ToDouble(Console.ReadLine());

            TPTriangle t = new TPTriangle(a, b);
            Console.WriteLine($"Area: {t.Square()}");
            Console.WriteLine($"Perem: {t.Perumeter()}");
            t.IsEqual(c, d);
            Console.WriteLine("+: {0}", a + b);
            Console.WriteLine("-: {0}", a - b);
            Console.WriteLine("*: {0}, {1}", a * num, b * num);
            TPPiramid p = new TPPiramid(rebro);
            Console.WriteLine($"Volume= {p.Volume()}");

        }
    }
}
