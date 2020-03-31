using System;

namespace taskk2
{
    class Program
    {
        static int Perpendukylar(int a, int b, int c, int d)
        {
            int skalar = a * b + c * d;
            if (skalar == 0)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] par1 = new int[n];
            int[] par2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter el-{i}: ");
                par1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Enter el-{j}: ");
                par2[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (i + 1 < n)
                {
                    int c = Perpendukylar(par1[i], par1[i + 1], par2[i], par2[i + 1]);
                    count += c;
                }
            }
            Console.Write("Par: {0}",count);
        }
    }
}
