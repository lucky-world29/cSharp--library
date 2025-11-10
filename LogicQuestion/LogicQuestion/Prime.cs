using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestion
{
    internal class Prime
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            for (int i = 2; i <=num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("not A prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
            //if(count == 1)
            //{
            //    Console.WriteLine("P");
            //}
            //else
            //{
            //    Console.WriteLine("Not p");
            //}
        }
    }
}
