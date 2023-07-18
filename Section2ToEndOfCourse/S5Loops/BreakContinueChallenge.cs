using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5Loops
{
    public class BreakContinueChallenge
    {
        public static void Challenge()
        {
            var grades = new List<int>();
            var gradeInput = GetGrade();
            while (gradeInput != -1)
            {
                grades.Add(gradeInput);
                gradeInput = GetGrade();
            }

            var average = GetGradeAverage(grades);
            Console.WriteLine($"Average grade: {average}");
        }

        private static int GetGrade()
        {
            Console.Write("Enter a grade or -1 to get the average: ");
            string? inputGrade = Console.ReadLine();
            int gradeAsInt;
            bool isValid = int.TryParse(inputGrade, out gradeAsInt);
            while (!isValid)
            {
                Console.WriteLine("Invalid input.  Please enter a grade or -1 to complete.");
                Console.Write("Enter a grade or -1 to get the average: ");
                inputGrade = Console.ReadLine();
                isValid = int.TryParse(inputGrade, out gradeAsInt);
            }

            return gradeAsInt;
        }

        private static double GetGradeAverage(List<int> grades)
        {
            int gradeTotal = 0;
            foreach (var grade in grades)
            {
                gradeTotal += grade;
            }

            return (double) gradeTotal / grades.Count;
        }
    }
}
