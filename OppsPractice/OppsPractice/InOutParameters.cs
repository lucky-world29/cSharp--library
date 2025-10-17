
namespace OppsPractice
{
    internal class InOutParameters
    {
        //public void AddParams(params double[] args) { 

        //}
        //public static void WriteLine(string format, params object[] args) { 

        //}
        public static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //Swap(ref a, ref b);
            //Console.WriteLine($"a={a}, b={b}");
            DateTime dt=DateTime.Now.AddMinutes(1);
            Console.WriteLine(dt.ToShortDateString());
        }
    }
}
