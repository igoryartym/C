using System.Collections.Generic;
using System.Linq;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть елем: ");
            int[] array = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();//Введення через пробіл
            List<int> min_arr = new List<int>();
            foreach (int el in array)
            {
                if (el >= 0)
                    min_arr.Add(el);
            }
            Console.WriteLine(min_arr.Min());
        }
    }
}
