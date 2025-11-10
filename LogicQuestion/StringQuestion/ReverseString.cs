using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestion
{
    internal class ReverseString
    {
        static void Main()
        {
            string s = "abcdefgh";

            for(int i = s.Length-1; i >=0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
