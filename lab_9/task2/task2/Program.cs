using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basaigru = { "назва гри", "вартість", "жанр", "к-сть рiвнiв" };
            List<string> basa = new List<string>();
            foreach (string el in basaigru)
            {
                Console.Write($"{el} = ");
                basa.Add(Convert.ToString(Console.ReadLine()));
            }
            for (int i = 0; i < basa.Count; i++)
            {
                Console.Write("[{0}:{1}]", basaigru[i], basa[i]);
            }

        }
    }
}
