using System;
namespace S9InheritanceAndOOP.V133InheritanceChallenge
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {
            CompanyCar = "No Car info provided";
        }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            // Props from Employee
            Name = name;
            FirstName = firstName;
            Salary = salary;

            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I am a boss and I am leading.");
        }

        public override string ToString()
        {
            return String.Format($"Name: {Name} - First Name: {FirstName} - Company Car: {CompanyCar} - Salary: ${Salary}");
        }
    }
}

