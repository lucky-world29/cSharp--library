using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsPractice
{
    internal struct MyStruct
    {
        int x;
        public MyStruct(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("Method defined under a structure: " + x);
        }
        static void Main()
        {
            MyStruct m1 = new MyStruct();
            m1.Display();
            MyStruct m2;
            m2.x = 10; m2.Display();
            MyStruct m3 = new MyStruct(20);
            m3.Display();
            Console.ReadLine();
        }
    }
}
