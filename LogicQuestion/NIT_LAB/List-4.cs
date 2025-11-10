using System;
using System.Collections.Generic;

namespace NIT_LAB
{
    internal class List_4
    {
        static void Main()
        {
            List<string> studentList = new List<string>();

            // Step 1: Read the name to insert later
            string newName = Console.ReadLine();  // e.g., Gita

            // Step 2: Read number of students
            int n = Convert.ToInt32(Console.ReadLine());

            // Step 3: Read student names
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                studentList.Add(name);
            }

            // Step 4: Display Original List
            Console.Write("Original List: [");
            Console.Write(string.Join(", ", studentList));
            Console.WriteLine("]");

            // Step 5: Read position to insert
            int position = Convert.ToInt32(Console.ReadLine());

            // Step 6: Insert newName at given position (1-based index)
            studentList.Insert(position, newName);

            // Step 7: Display Updated List
            Console.Write("Updated List: [");
            Console.Write(string.Join(", ", studentList));
            Console.WriteLine("]");
        }
    }
}
