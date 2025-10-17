
namespace SecondProj
{
    using System;
    using System.Xml.Linq;

    class Employee
    {
        protected int EmpID;
        protected string Name;
        protected double Salary;

        public Employee(int empid, string name, double salary)
        {
            EmpID = empid;
            Name = name;
            Salary = salary;
        }

    }

    class Manager : Employee
    {
        protected string Department;

        public Manager(int empid, string name, double salary, string dept) : base(empid, name, salary)
        {
            Department = dept;
        }
    }

    class Director : Manager
    {
        protected double Bonus;

        public Director(int empid, string name, double salary, string dept, double bonus) : base(empid, name, salary, dept)
        {
            Bonus = bonus;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Director Details : ->");
            Console.WriteLine("EmpID :" + EmpID);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Department :" + Department);
            Console.WriteLine("Bonus :" + Bonus);
        }

       
    }

    class Yo1A
    {
        static void Main()
        {
            Console.WriteLine("Output : - ");

            Console.Write("Enter Employee ID: ");
            int EmpID = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Console.Write("Enter Bonus: ");
            double bonus = double.Parse(Console.ReadLine());

            Director dir1 = new Director(EmpID, name, salary, dept, bonus);
            dir1.PrintDetails();
        }
    }
}
