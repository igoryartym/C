using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basadanix = { "паспортнi данi", "освiта", "спецiальнiсть", "посада", "оклад" };
            List<string> basa = new List<string>();
            foreach (string el in basadanix)
            {
                Console.Write($"{el} = ");
                basa.Add(Convert.ToString(Console.ReadLine()));
            }
            for (int i = 0; i < basa.Count; i++)
            {
                Console.Write("[{0}:{1}]",basadanix[i],basa[i]);
            }
        }
    }
}
