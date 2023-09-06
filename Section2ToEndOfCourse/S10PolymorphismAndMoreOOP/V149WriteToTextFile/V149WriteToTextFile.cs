using System;
using System.Reflection.Metadata;

namespace S10PolymorphismAndMoreOOP.V149WriteToTextFile
{
    public static class V149WriteToTextFile
    {
        public static void Lesson()
        {
            string filePath = "/Users/sminter/Development/csharp-masterclass/Section2ToEndOfCourse/S10PolymorphismAndMoreOOP/V149WriteToTextFile/UserInputScores.txt";
            List<string> scores = new List<string>();
            // File.WriteAllLines(@filePath, lines);

            string currentScore = string.Empty;
            while (currentScore != "-1")
            {
                Console.Write("Enter a score: ");
                currentScore = Console.ReadLine();
                if (currentScore != null && currentScore != "-1")
                {
                    scores.Add(currentScore);    
                }
            }

            string filePath2 = "/Users/sminter/Development/csharp-masterclass/Section2ToEndOfCourse/S10PolymorphismAndMoreOOP/V149WriteToTextFile/UserInputScores2.txt";
            using (StreamWriter file = new StreamWriter(@filePath2))
            {
                foreach (string score in scores)
                {
                    // Console.WriteLine($"score: {score}");
                    file.WriteLine($"Score: {score}");
                }    
            }

            Console.WriteLine("All Done");
            // File.WriteAllLines(@filePath, scores);
        }
    }
}

