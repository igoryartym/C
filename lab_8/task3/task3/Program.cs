using System;

namespace task3
{
    class Program
    {
        static int Recur(int a)
        {
            if (a == 0)
                return 0;
            else if (a == 1)
                return 9;
            else
                return 2 * Recur(a - 1) + 3 * Recur(a - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int recur = Recur(n);
            Console.WriteLine($"Recur = {recur}");
        }
    }
}