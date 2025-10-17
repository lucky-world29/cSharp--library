
namespace LabWork
{
    internal class Que6
    {
        static void Main(string[] arg) { 
            Console.WriteLine("Enter the number of natural numbers to sum:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int m= n;
            while (n != 0) {
                sum += n;
                n--;
            }
            Console.WriteLine("The sum of the first " + m + " natural numbers is: " + sum);

        }
    }
}
