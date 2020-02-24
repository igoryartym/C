using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x1, y1, x2, y2;
            double a, b, c;
            Console.WriteLine("Введіть координати x,y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведіть координати x1,y1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведіть координати x2,y2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            a = Math.Sqrt(x * x + y * y);
            b = Math.Sqrt(x1 * x1 + y1 * y1);
            c = Math.Sqrt(x2 * x2 + y2 * y2);
            if (a == b && b == c)
                Console.WriteLine("\nTrue");
            else
                Console.WriteLine("\nFalse");
        }
    }
}
