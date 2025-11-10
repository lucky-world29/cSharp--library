using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestion
{
    internal class PalindromeCheck
    {
        static void Main()
        {
            string s1 = Console.ReadLine();
            string s2 = "";
            //for (int i = s1.Length - 1; i >= 0; i--) 
            //{

            //}
            char[] s3 = s1. ToCharArray();
            for (int i = 0; i < s3.Length/2; i++)
            {
                if (s3[i] != s3[s3.Length-i -1])
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }
            }
            Console.WriteLine("Palindrome");

            // /*if (s1.ToLower()==s2.ToLower()) */ //=>A man, a plan, a canal: Panama it will not work 
            //    if(s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine("Palindrom");
            //    }
            //else
            //   {
            //        Console.WriteLine("Not Pali");
            //    }
        }
    }
}
