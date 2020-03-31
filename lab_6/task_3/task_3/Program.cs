using System;
using System.Collections.Generic;
using System.Linq;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть len: ");
            int len = int.Parse(Console.ReadLine());
            int[] vect1 = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введiть елем вектора-{i}:");
                vect1[i] = int.Parse(Console.ReadLine());
            }

            int[] vect2 = new int[len];
            for (int k = 0; k < len; k++)
            {
                Console.Write($"Введiть елем вектора1-{k}:");
                vect2[k] = int.Parse(Console.ReadLine());
            }


            double divvect = vect1[0] / vect2[0];
            bool isParallel = false;

            for (int j = 1; j < len; j++)
            {
                if (Math.Abs(divvect - vect1[j] / vect2[j]) < double.Epsilon)
                {
                    isParallel = true;
                    break;
                }
            }
            Console.WriteLine($"Is parallel: {isParallel}");


        }
    }
}
