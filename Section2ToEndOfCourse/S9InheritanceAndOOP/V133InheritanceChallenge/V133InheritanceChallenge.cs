using System;
namespace S9InheritanceAndOOP.V133InheritanceChallenge
{
    public class V133InheritanceChallenge
    {
        public static void Lesson()
        {
            Console.WriteLine("Inheritance Challenge");

            // Employee Base Class
            // - Properties
            // -- Name
            // -- FirstName
            // -- Salary
            // - Methods
            // -- Work
            // -- Pause
            var emp1 = new Employee();
            Console.WriteLine($"emp1: {emp1.ToString()}");
            var emp2 = new Employee("Minter", "Scott", 150000);
            emp2.Work();
            emp2.Pause();
            Console.WriteLine($"emp2: {emp2.ToString()}");

            // Boss Class
            // - inherits from Employee
            // - Properties
            // -- CompanyCar
            // - Method
            // -- Lead
            var boss1 = new Boss();
            Console.WriteLine($"boss1: {boss1.ToString()}");
            var boss2 = new Boss("Leader", "Dirk D.", 850000, "Honda Accord");
            boss2.Work();
            boss2.Pause();
            boss2.Lead();
            Console.WriteLine($"boss2: {boss2.ToString()}");

            // Trainee Class
            // - inherits form Employee
            // - properties
            // -- WorkingHours
            // -- SchoolHours
            // - Mehod
            // -- Learn
            var tr1 = new Trainee();
            Console.WriteLine($"tr1: {tr1.ToString()}");
            var tr2 = new Trainee("Trainee", "Tim D.", 30000, 20, 35);
            tr2.Work();
            tr2.Learn();
            Console.WriteLine($"tr2: {tr2.ToString()}");
        }
    }
}

