using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first numb of progresion: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter difference: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter numb to find: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Arifmetic result = new Arifmetic();
            Console.WriteLine($"Find {c} of progresion = {result.Progress(a, b, c)}");
            Console.WriteLine($"Find sum = {result.Sumprogres(a,b,c)}");
        }
    }
}
