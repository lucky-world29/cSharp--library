using System.Diagnostics;

namespace NIT_LAB
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base Constructor");
            Show();   // virtual call
        }

        public virtual void Show()
        {
            Console.WriteLine("Base Show");
        }
    }

    class Derived : Base
    {
        int x = 42;  // field initializer
        public Derived()
        {
            Console.WriteLine("Derived Constructor");
        }

        public override void Show()
        {
            Console.WriteLine("Derived Show, x = " + x);
        }
    }

    public class Program
    {
        static void Main(string[] args) {
            Derived obj = new Derived();
        }
    }
}
