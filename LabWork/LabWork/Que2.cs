using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Question 2) Write a C# program to find the largest of three numbers entered by the user using Ternary Operator.

Input:-
Enter first number: 10
Enter second number: 25
Enter third number: 17

Output:-
Maximum number is: 25


 */
namespace LabWork
{
    internal class Que2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"Maximum number is: {max}");
        }

    }
}
