using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3FunctionsMethods
{
    public class V45VoidMethods
    {
        public static void Lesson()
        {
            WriteSomething();

            // Print user input
            var promptMessage = "Enter some input: ";
            var userInput = GetUserInput(promptMessage);

            WriteSomethingSpecific(userInput);
        }

        private static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        private static void WriteSomethingSpecific(string writeThis)
        {
            Console.WriteLine($"Input: {writeThis}");
        }

        private static string GetUserInput(string? promptMessage)
        {
            if (!String.IsNullOrEmpty(promptMessage))
            {
                Console.Write(promptMessage);
            }
            
            var userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("No Input Was Given");
                return String.Empty;
            }

            return userInput;
        }
    }
}
