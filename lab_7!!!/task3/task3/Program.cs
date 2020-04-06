using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m,k=-1;
            Console.Write("К-ть рядкiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("К-ть стовцiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            int[] Vect = new int[m];
            int[,] B = new int[m, n];
            int[] Answer = new int[m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введiть вект:{i}= ");
                Vect[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    B[j, i] = A[i, j];
            }
            for (int i = 0; i < m; i++)
            {
                k++;
                if (k == m) break;
                for (int j = 0; j < n; j++)
                    Answer[i] = Vect[k] * B[j, i];
            }
            for (int i = 0; i < m; i++)
                Console.WriteLine(Answer[i]);
        }
    }
}