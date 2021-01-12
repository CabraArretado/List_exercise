using System;
namespace List_exercises
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee id: {Id}. Name: {Name}. Salary: {Salary.ToString("F2")}";
        }

        public void Raise(double percent)
        {
            Salary *= (percent * 0.01 + 1);
        }
    }
}