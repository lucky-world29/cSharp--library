using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablePractice
{
    internal class hashDemo
    {
        static void Main()
        {
            HashSet<int> hs = new HashSet<int>() { 10, 20, 20, 30 };
            Console.WriteLine(hs.Count);
        }
    }
}
