using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("The largest number is: " + num1);
            else if (num2 > num3) 
                Console.WriteLine("The largest number is: " + num2);
            else
                Console.WriteLine("The largest number is: " + num3);
        }

    }
}
