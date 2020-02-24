using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min_bc, max_ab;
            Console.Write("Введіть число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведіть число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведіть число:");
            c = Convert.ToInt32(Console.ReadLine());
            max_ab = Math.Max(a, b);
            min_bc = Math.Min(b, c);
            Console.WriteLine($"Результат: {(max_ab * min_bc * min_bc)}");
        }
    }
}
