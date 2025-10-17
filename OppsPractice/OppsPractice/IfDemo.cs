
namespace OppsPractice
{
    internal class IfDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("1st number is greater than 2nd number");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("2nd number is greater than 1st number");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }

        }
    }
}
