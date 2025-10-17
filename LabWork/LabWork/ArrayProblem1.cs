using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    class ArrayProblem1
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            // int size = int.Parse(Console.ReadLine());

            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            // print the values 

            for(int i = 0;i < row; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    Console.WriteLine(arr[i,j]);
                }
            }
            Console.WriteLine();
        }
    }
}
