using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a5, a10, a20, a50, a100, a200,sum;            
            Console.Write("Enter number of 5: ");
            a5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of 10: ");
            a10 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of 20: ");
            a20 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of 50: ");
            a50 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of 100: ");
            a100 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of 200: ");
            a200 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount you want to withdraw: ");
            sum = Convert.ToInt32(Console.ReadLine());
            TBankomat bank = new TBankomat(a5, a10, a20, a50, a100, a200,sum);
            Console.WriteLine("Min = {0}"+"\n"+"Max = {1}",bank.Minsum(),bank.Maxsum());
            Console.WriteLine("Cash = {0}",bank.Amount());

        }
    }
}
