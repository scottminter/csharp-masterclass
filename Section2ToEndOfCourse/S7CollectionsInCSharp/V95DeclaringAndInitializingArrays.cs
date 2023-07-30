using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V95DeclaringAndInitializingArrays
    {
        private int[] _grades = new int[5];

        public V95DeclaringAndInitializingArrays()
        {
            for (int i = 0; i < _grades.Length; i++)
            {
                _grades[i] = 0;
            }
        }

        public void Lesson()
        {
            DisplayGrades();

            Console.WriteLine("Enter Grades =>\n");

            SetGrades();

            DisplayGrades();
        }

        private void SetGrades()
        {
            for (int i = 0; i < _grades.Length; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");

                var gradeInput = Console.ReadLine();
                var isInputParseable = Int32.TryParse(gradeInput, out int gradeAsInt);

                if (isInputParseable)
                {
                    _grades[i] = gradeAsInt;
                }
            }
        }

        private void DisplayGrades()
        {
            var gradesSum = 0;
            for (int i = 0; i < _grades.Length; i++)
            {
                gradesSum += _grades[i];
            }

            Console.WriteLine($"Grade for class: {gradesSum / _grades.Length}%");
        }
    }
}
