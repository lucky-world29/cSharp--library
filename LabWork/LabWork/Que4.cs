using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class Que4
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter a week Day (1 to 7): ");
            int w_day  = Convert.ToInt32(Console.ReadLine());

            switch (w_day) {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2: 
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                    case 4:
                    Console.WriteLine("Wednesday");
                    break;
                    case 5:
                    Console.WriteLine("Thursday");
                    break;
                    case 6:
                    Console.WriteLine("Friday");
                    break;
                    case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
