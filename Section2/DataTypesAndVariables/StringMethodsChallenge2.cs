using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class StringMethodsChallenge2
    {
        public void Lesson()
        {
            string input;
            string characterToSearchFor;
            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            Console.Write("Search for a character: ");
            characterToSearchFor = Console.ReadLine();

            Console.WriteLine(
                $"Index of ({characterToSearchFor}) in the string ({input}) is {input.IndexOf(characterToSearchFor)}");
        }
    }
}
