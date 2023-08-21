using System;
namespace S9InheritanceAndOOP.V133InheritanceChallenge
{
    public class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee()
        {
            WorkingHours = 0;
            SchoolHours = 0;
        }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            // inherited from employee
            Name = name;
            FirstName = firstName;
            Salary = salary;

            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I am learning.");
        }

        public override string ToString()
        {
            return String.Format($"Name: {Name} - First Name: {FirstName} - Working Hours: {WorkingHours} - School Hours: {SchoolHours} - Salary: {Salary}");
        }
    }
}

