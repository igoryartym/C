using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введіть число:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0 && x < 5)
                Console.WriteLine("y= 1");
            else if (x >= 5 && x <= 8)
                Console.WriteLine("y= 2");
            else if (x < 0)
                Console.WriteLine("y= 3");
            else if (x >= 8)
                Console.WriteLine("y= 4");
            else
                Console.WriteLine("Такого значення немає");
        }
    }
}
