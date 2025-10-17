namespace Delegate
{
    internal class Program
    {
        public static void AddNums1(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public delegate void AddDel(int x, int y);// delegate declaration
        //AddDel ad = new AddDel(AddNums1);  // delegate instantiation
        AddDel ad = AddNums1;               // delegate instantiation
        private ad(10, 20);// delegate calling
        public  void AddNums(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        //public delegate void AddDel(int x, int y);// delegate declaration
        //AddDel ad = new AddDel(AddNums);

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        public delegate string SayDell(string name);//delagaate decalration 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
