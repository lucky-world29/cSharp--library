using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Calculator
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Sum of 2 and 3: " + calc.Add(2, 3));
            Console.WriteLine("Sum of 2, 3 and 4: " + calc.Add(2, 3, 4));
        }

    }

}
