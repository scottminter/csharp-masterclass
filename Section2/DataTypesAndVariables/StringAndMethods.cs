using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class StringAndMethods
    {
        /// <summary>
        /// Material for Section 2.23
        /// Datatype String and some of
        /// it's Methods
        /// </summary>
        public void Lesson()
        {
            // Coding standards for strings are lower case class (ex. string instead of String)
            string myName = "Scott";
            Console.WriteLine($"my name: {myName}");

            string message = "My name is " + myName + ".";
            Console.WriteLine(message);

            Console.WriteLine($"My name uppercase: {myName.ToUpper()}");

            string uppercaseString = "HERE IS AN ALL UPPERCASE STRING";
            Console.WriteLine($"Uppercase string: {uppercaseString}");
            Console.WriteLine($"Uppercase to lowercase string: {uppercaseString.ToLower()}");
        }
    }
}
