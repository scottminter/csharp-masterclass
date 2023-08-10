using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V105ArraysAsParams
    {
        public static void Lesson()
        {
            int[] grades = new int[] {100, 100, 100, 99, 65, 12, 70, 85, 90 };

            var average = GetAverage(grades);
            Console.WriteLine($"average: {average}\n");



            // Happiness array challenge
            Console.WriteLine("** Original Happiness **\n");

            int[] happiness = new int[] { 7, 5, 3, 4, 8 };

            foreach (int happy in happiness)
            {
                Console.WriteLine(happy);
            }

            Console.WriteLine("\n** Upgrade Complete **\n");

            UpgradeHappiness(happiness);

            foreach(int happy in happiness)
            {
                Console.WriteLine(happy);
            }
        }

        private static void UpgradeHappiness(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }

        private static double GetAverage(int[] gradesArray)
        {
            double average = 0.0;
            int sum = 0;

            foreach (int grade in gradesArray)
            {
                sum += grade;
            }

            if (gradesArray.Length > 0)
            {
                average = (double) sum / gradesArray.Length;
            }

            return Math.Round(average, 2);
        }
    }
}
