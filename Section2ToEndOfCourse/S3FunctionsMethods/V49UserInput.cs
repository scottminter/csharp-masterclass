using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3FunctionsMethods
{
    public class V49UserInput
    {
        public static void Lesson()
        {
            Console.Write("Enter a whole number: \n");
            var num1 = Console.ReadLine();

            var isNum1Parseable = Int32.TryParse(num1, out int int1);

            Console.Write("Enter another whole number: \n");
            var num2 = Console.ReadLine();

            var isNum2Parseable = Int32.TryParse(num2, out int int2);

            if (isNum1Parseable && isNum2Parseable)
            {
                var sum = GetSumOfUserInputs(int1, int2);
                Console.WriteLine($"The sum of {int1} + {int2} = {sum}");
            }
            else
            {
                Console.WriteLine("Error: Invalid Input");
            }
        }

        public static int GetSumOfUserInputs(int int1, int int2)
        {
            return int1 + int2;
        }
    }
}
