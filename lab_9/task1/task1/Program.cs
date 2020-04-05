using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> basadanix = new Dictionary<string, string>();
            string[] basadan = { "паспортнi данi", "освiта", "спецiальнiсть", "посада", "оклад" };
            foreach (string el in basadan)
            {
                Console.Write($"{el} = ");
                basadanix[el] = Convert.ToString(Console.ReadLine());
            }
            
            foreach (KeyValuePair<string,string> el in basadanix)
            {
                Console.WriteLine("Key = {0}, Value = {1}",el.Key,el.Value);
            }
        }
    }
}
