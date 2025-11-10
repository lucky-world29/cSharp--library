using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestion
{
    internal class Hashtable_problem2
    {
        static void Main()
        {
            Hashtable hihi = new Hashtable();

            int k = Convert.ToInt32(Console.ReadLine());
            string  v = Console.ReadLine();

            hihi.Add(k, v);

            foreach (DictionaryEntry fe in hihi.Cast<DictionaryEntry>().OrderByDescending(e => e.Key))
            {
                Console.WriteLine($"Key: {fe.Key}, Value: {fe.Value}");
            }
        }
    }
}
