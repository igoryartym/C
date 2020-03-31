using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, num;
            Console.Write("Enter radius1: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter radius2: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter num: ");
            num = Convert.ToDouble(Console.ReadLine());
            TCirle tcirle = new TCirle(r1, r2);
            Console.WriteLine("Area: {0}", tcirle.Area());
            Console.WriteLine("Len circle: {0}", tcirle.Len());
            Console.WriteLine("r1>r2: {0}", tcirle.Diff());
            Console.WriteLine("+: {0}",r1 + r2);
            Console.WriteLine("-: {0}",r1 - r2);
            Console.WriteLine("*: {0}",r1 * num);
        }
    }
}
