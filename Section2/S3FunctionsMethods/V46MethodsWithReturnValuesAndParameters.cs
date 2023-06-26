using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace S3FunctionsMethods
{
    public class V46MethodsWithReturnValuesAndParameters
    {
        public static void Lesson()
        {
            int num1 = GetUserInput("(Addition) Enter a whole number: ");
            int num2 = GetUserInput("(Addition) Enter another whole number: ");
            int sum = Add(num1, num2);

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.\n");

            int num3 = GetUserInput("(Multiplication) Enter a whole number: ");
            int num4 = GetUserInput("(Multiplication) Enter another whole number: ");
            int product = Multiply(num3, num4);
            
            Console.WriteLine($"The product of {num3} and {num4} is {product}.\n");

            int num5 = GetUserInput("(Division) Enter a whole number: ");
            int num6 = GetUserInput("(Division) Enter another whole number: ");
            double quotient = Divide(num5, num6);

            Console.WriteLine($"The quotient of {num5} and {num6} is {quotient}.\n");
        }

        public static void Challenge()
        {
            var friends = new List<string>()
            {
                "Jon",
                "Jared",
                "Erin"
            };

            string a = "phone";
            var b = a.Length;

            foreach (var friend in friends)
            {
                GreetFriend(friend);
            }
        }

        private static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hi {friend}, my friend!");
        }

        private static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        private static int Multiply(int param1, int param2)
        {
            return param1 * param2;
        }

        private static double Divide(int param1, int param2)
        {
            return (double)param1 / (double)param2;
        }

        private static int GetUserInput(string? promptMessage)
        {
            if (!String.IsNullOrEmpty(promptMessage))
            {
                Console.Write(promptMessage);
            }

            var userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("No Input Was Given");
                return 0;
            }

            var inputAsInt = int.Parse(userInput);

            return inputAsInt;
        }
    }
}
