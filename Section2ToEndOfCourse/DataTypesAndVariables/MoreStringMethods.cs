using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class MoreStringMethods
    {
        public void Lesson()
        {
            // SubString(int32)
            // gets Substring from string starting at the specified index
            string rudy = "Rudy Marion Minter";
            string subStringOfRudy = rudy.Substring(3);
            Console.WriteLine($"substring: original string ({rudy}). Substring: {subStringOfRudy}");
            Console.WriteLine($"substring with end point: original string ({rudy}). Substring: {rudy.Substring(5, 8)}\n");

            // ToLower()
            Console.WriteLine($"ToLower(): {rudy.ToLower()}\n");

            // ToUpper()
            Console.Write($"ToUpper(): {rudy.ToUpper()}\n");

            // Trim
            string trimMe = " Trim this string. ";
            Console.WriteLine($"Trim:\n{trimMe.Trim()}\n");

            // IndexOf(string)
            string getIndex = "Get the index of foo in here.";
            Console.WriteLine($"IndexOf(string): {getIndex.IndexOf("foo")}\n");

            // IsNullOrWhiteSpace
            string nullString = null;
            string whiteSpace = "      ";
            string goodString = "I am a string";
            Console.WriteLine($"Null or White Space: Null String - {String.IsNullOrWhiteSpace(nullString)}");
            Console.WriteLine($"Null or White Space: White Space - {String.IsNullOrWhiteSpace(whiteSpace)}");
            Console.WriteLine($"Null or White Space: Good String - {String.IsNullOrWhiteSpace(goodString)}\n");
        }
    }
}
