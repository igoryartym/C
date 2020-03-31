using System;
using System.Collections.Generic;
using System.Linq;
namespace C_
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть елем b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть елем i: ");
            int i = Convert.ToInt32(Console.ReadLine());
            List<double> arr = new List<double>();
            List<double> arr1 = new List<double>();
            List<double> vect = new List<double>();
            double sum = 0,a;

            for (int e = 1; e <= i; e++)
            {
                sum += Math.Round(Factorial(e) * Math.Sin(e * b), 4);
                arr.Add(sum);
            }
            
            foreach (double el in arr)
                Console.Write(el + " ");
            
            for (int el = 1; el < arr.Count; el++)
            {
                a = arr[el - 1] * arr[el];
                vect.Add(arr[el - 1] * arr[el]);
                Console.WriteLine("\n" + a);
            }
            Console.WriteLine($"Min ={vect.Min()}");
        }   


    }
}
