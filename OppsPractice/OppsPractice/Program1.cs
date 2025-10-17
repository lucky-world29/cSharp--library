namespace OppsPractice
{
    internal class Program1
    {
        public void Test1() {
            int x = 5;
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{x} * {i} = {x*i}");
            }
        }

        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.Test1();
        }
    }
}
