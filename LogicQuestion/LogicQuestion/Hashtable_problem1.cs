using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicQuestion
{
    internal class Hashtable_problem1
    {
        static void Main()
        {
            Hashtable CityState = new Hashtable();
            Console.WriteLine("Enter number of pair u want darling ..");
            int cityNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i< cityNumber; i++)
            {
                Console.WriteLine("Enter ur city baby ");
                string? city  = Console.ReadLine();
                Console.WriteLine("Now your state sweetheart ");
                string? state = Console.ReadLine();
                CityState.Add(city, state);
            }
            foreach(var i in CityState)
            {
                Console.WriteLine("So your address is "+i);
            }
            Console.ReadLine();
        }
    }
}
