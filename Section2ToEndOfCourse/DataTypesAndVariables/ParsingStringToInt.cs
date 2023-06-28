using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class ParsingStringToInt
    {
        public void Lesson()
        {
            string myString = "15a";
            string myString2 = "13";

            bool isMyStringParseable = Int32.TryParse(myString, out int myStringAsInt);
            bool isMyString2Parseable = Int32.TryParse(myString2, out int myStringAsInt2);

            int sum = 0;
            if (isMyStringParseable && isMyString2Parseable)
            {
                sum = myStringAsInt + myStringAsInt2;
            }
            else
            {
                Console.WriteLine(
                    $"Either myString ({myString}) or myString2 ({myString2}) cannot be parsed into an int.");
                return;
            }

            Console.WriteLine($"myString ({myString}) + myString2 ({myString2}) = {sum}");
        }
    }
}
