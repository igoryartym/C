using System;
using System.Collections.Generic;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n, m;
            Console.Write("К-ть рядкiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("К-ть стовцiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }*/
            List<int> list = new List<int>();
            int[,] A = { { 5, 2, 8, 7 }, { 9, 87, 2, 64 }, { 84, 624, 464, 762 } };

           for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    Console.WriteLine($"[{A[i,j]}]");
                }
            }

        }
    }
}
