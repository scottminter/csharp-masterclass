using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class StringMethodsChallenge
    {
        public void Lesson()
        {
            string myString;
            Console.Write("Please input your name and press enter: ");
            myString = Console.ReadLine();
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.Trim());
            Console.WriteLine(myString.Substring(2));
        }
    }
}
