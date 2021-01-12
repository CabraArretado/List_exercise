using System;
using System.Linq;
using System.Collections.Generic;

namespace List_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int? n = int.Parse(Console.ReadLine());
            var fs = new List<Employees>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1}");

                Console.Write("Id? ");
                int myId = int.Parse(Console.ReadLine());

                Console.Write("Name? ");
                string myName = Console.ReadLine();

                Console.Write("Salary? ");
                double mySalary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                fs.Add(new Employees(myId, myName, mySalary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            var in_id = int.Parse(Console.ReadLine());

            var my_func = fs.Find(x => in_id == x.Id);
            if (my_func == null) {
                Console.WriteLine("Employee not found.");
            } else
            {
                Console.Write("Enter the percentage: ");
                my_func.Raise(double.Parse(Console.ReadLine()));
                Console.WriteLine(my_func);
            }
        }
    }
}
