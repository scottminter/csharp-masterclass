using System;
namespace S9InheritanceAndOOP.V133InheritanceChallenge
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "No Name Given";
            FirstName = "No First Name Given";
            Salary = 0;
        }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I am doing work.");
        }

        public virtual void Pause()
        {
            Console.WriteLine("I am pausing work.");
        }

        public override string ToString()
        {
            return String.Format($"Name: {Name} - First Name: {FirstName} - Salary: {Salary}");
        }
    }
}

