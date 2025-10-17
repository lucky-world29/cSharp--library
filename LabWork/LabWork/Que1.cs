using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Question 1) Write a C# program that accepts an integer from the user and determines whether the number is positive, negative, or zero using the ternary operator (?:). 

Output:-
Enter a number: -8
The number is Negative

Enter a number: 0
The number is Zero

Enter a number: 42
The number is Positive
 */
namespace LabWork
{
    internal class Que1
    {
        public static void Main(string[] args) { 
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number > 0) ? "Positive" : (number < 0) ? "Negative" : "Zero";
            Console.WriteLine($"The number is {result}");
        }
    }
}
