using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestion
{
    internal class CountVowelsConsonants
    {
        static void Main(string[] args)
        {
            string name = "Lucky";
            int Ccount = 0;
            int VCount = 0;
            for(int i=0; i < name.Length; i++)
            {
                if(name[i] =='a'||name[i] == 'A' || name[i] == 'e' || name[i]=='E'|| name[i] == 'i' || name[i] == 'I' || name[i] == 'o' || name[i] == 'O' || name[i] == 'u' || name[i] == 'U')
                {
                    VCount++;
                }
                else
                {
                    Ccount++;
                }
            }

            Console.WriteLine("V" + VCount);
            Console.WriteLine("C" + Ccount);
        }
    }
}
