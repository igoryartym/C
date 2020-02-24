using System;
//Обчислити площу та периметр квадрата, якщо задано довжину діагоналі цього квадрата.
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            Console.Write("Введіть діагональ:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Squar is: {Math.Round(0.5 * (d * d), 2)}");
            Console.WriteLine($"Perim is : {Math.Round(Math.Sqrt(8) * d, 2)}");
        }
    }
}