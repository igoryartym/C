using System;

namespace task2
{
    class Program
    {
        static double Matrics(int i,int j,int x)
        {
            double a = i * (Math.Sin(i * x) + Math.Cos(j * x));
            return a;
        }
        static void Main(string[] args)
        {
            int n, m, x;
            Console.Write("К-ть рядкiв =");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("К-ть стовпцiв =");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("x =");
            x = Convert.ToInt32(Console.ReadLine());
            Double[,] A = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    A[i, j] = Matrics(i, j, x); 
            }
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                    Console.WriteLine($"{A[i,j]}");
            }
        }
    }
}
