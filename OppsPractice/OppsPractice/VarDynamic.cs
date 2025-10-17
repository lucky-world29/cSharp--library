using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsPractice
{
    public class VarDynamic
    {
         public  int x { get; set; } = 9; // private by default
        static void Main(string[] args)
        {
            VarDynamic v = new VarDynamic();
            Console.Write(v.x);
            //var x = 2;
            //Console.WriteLine(x.GetType());//System.Int32
            dynamic y = 3;
            Console.WriteLine(y.GetType());//System.Int32
            int n = 2;
            Console.WriteLine(n.GetType());//System.Int32

            float f = 8.89F;
            Console.WriteLine(f.GetType());//System.Single

            double dob = 4.564;
            Console.WriteLine(dob.GetType());
            long log  = 456789;
            Console.WriteLine(log.GetType());


        }

    }
}
