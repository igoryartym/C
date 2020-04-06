using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] xn = new double[3];
            double[] yn = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter x{0}: ", i + 1);
                xn[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter y{0}: ", i + 1);
                yn[i] = Convert.ToInt32(Console.ReadLine());
            }
            TTriangle tr = new TTriangle(xn, yn);
            Console.WriteLine("a = {0}, b ={1}, c = {2}", tr.A, tr.B, tr.C);
            Console.WriteLine("Area: {0}" + "\n" + "Perum: {1}", tr.Square(), tr.Perum());
        }
    }
}