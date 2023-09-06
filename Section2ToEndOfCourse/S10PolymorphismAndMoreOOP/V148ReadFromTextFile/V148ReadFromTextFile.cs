using System;
namespace S10PolymorphismAndMoreOOP.V148ReadFromTextFile
{
    public class V148ReadFromTextFile
    {
        public static void Lesson()
        {
            var file = "/Users/sminter/Development/csharp-masterclass/Section2ToEndOfCourse/S10PolymorphismAndMoreOOP/V148ReadFromTextFile/TextFile.txt";

            // Example 1 - reading text
            string fileText = System.IO.File.ReadAllText(@file);

            Console.WriteLine($"Text file contains: {fileText}");

            // Example 2 - read each line
            string[] lines = System.IO.File.ReadAllLines(@file);

            Console.WriteLine("Contents in TextFile.txt");
            var i = 0;
            foreach (var line in lines)
            {
                Console.WriteLine($"\n{i}: {line}");
                i++;
            }
        }
    }
}

