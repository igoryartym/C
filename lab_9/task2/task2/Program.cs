using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> basaigru = new Dictionary<string, string>();
            string[] basaigr = { "назва гри", "вартість", "жанр", "к-сть рiвнiв" };
            foreach (string el in basaigr)
            {
                Console.Write($"{el} = ");
                basaigru[el] = Convert.ToString(Console.ReadLine());
            }
            foreach (KeyValuePair<string, string> el in basaigru)
            {
                Console.WriteLine("Key = {0}, Value = {1}", el.Key, el.Value);
            }


        }
    }
}
