using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5Loops
{
    public static class V68BasicLoops
    {
        public static void Lesson()
        {
            ForLoop();

            DoWhile();

            WhileLoop();
        }

        private static void ForLoop()
        {
            Console.WriteLine("\nFor Loops");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i: {i}");
            }
        }

        private static void DoWhile()
        {
            Console.WriteLine("\nDo While");

            string? friendName;
            do
            {
                Console.Write("Enter the name of a friend: ");

                friendName = Console.ReadLine();
                // if string is null then assign empty string 
                friendName ??= String.Empty;

                Console.WriteLine($"friend name: {friendName} is {friendName.Length} chars long");

            } while (friendName.Length < 10);
        }

        private static void WhileLoop()
        {
            Console.WriteLine("\nWhile Loop");

            int myAge = 42;
            int guessedAgeAsInt = 0;
            while (guessedAgeAsInt != myAge)
            {
                Console.Write("Guess my age! Enter a number between 0-100: ");
                var guessedAge = Console.ReadLine();
                bool parseSuccessful = int.TryParse(guessedAge, out guessedAgeAsInt);

                if (parseSuccessful && guessedAgeAsInt >= 0 && guessedAgeAsInt <= 100)
                {
                    if (guessedAgeAsInt < myAge)
                    {
                        Console.WriteLine($"{guessedAgeAsInt} is too low.  Guess again!");
                    }
                    else if (guessedAgeAsInt > myAge)
                    {
                        Console.WriteLine($"{guessedAgeAsInt} is too high. Guess again!");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it!!! I am {myAge} years old.");
                    }
                }
                else
                {
                    Console.WriteLine("Your input is invalid.  Please try again.");
                }
            }

        }
    }
}
