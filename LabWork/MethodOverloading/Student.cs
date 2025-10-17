using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{

    public class Student
    {
        public string Name;
        public int Age;

        public Student(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Student[] stAr = new Student[5];
            Student s1 = new Student("Alice", 20);
            Student s2 = new Student("Bob", 22);

            DisplayService displayService = new DisplayService();
            displayService.Display(s1);

        }
    }

    public class DisplayService
    {
        
        public void Display(Student s1)
        {
            Console.WriteLine($"Name is {s1.Name} and Age is {s1.Age}");
        }

        public void Display(Student[] stAr)
        {
            foreach (Student b in stAr)
                Console.WriteLine($"Name : {b.Name} and Age is {b.Age}");
        }

        
    }
}
