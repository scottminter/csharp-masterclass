using System;

namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> Int, Float, and Double\n");
            var intFloatDouble = new IntFloatDouble();
            intFloatDouble.Lesson();

            Console.WriteLine("\n*********************\n");

            Console.WriteLine("==> String and Methods\n");
            var stringAndMethods = new StringAndMethods();
            stringAndMethods.Lesson();

            Console.WriteLine("\n*********************\n");

            Console.WriteLine("==> Console Class and Methods\n");
            var consoleMethods = new ConsoleClass();
            consoleMethods.Lesson();

            Console.WriteLine("\n*********************\n");

            Console.WriteLine("==> Naming Conventions and Coding Standards\n");
            var namingAndStandards = new NamingAndStandards();
            namingAndStandards.Lesson();

            Console.WriteLine("\n*********************\n");

            Console.WriteLine("==> Naming Conventions and Coding Standards\n");
            var implicitAndExplicitConversions = new ImplicitAndExplicitConverstion();
            implicitAndExplicitConversions.Lesson();

            Console.WriteLine("\n*********************\n");
            Console.WriteLine("==> Parsing a string to an integer\n");
            var stringToInt = new ParsingStringToInt();
            stringToInt.Lesson();

            Console.WriteLine("\n*********************\n");
            Console.WriteLine("==> String Manipulation\n");
            var stringManipulation = new StringManipulation();
            stringManipulation.Lesson();

            Console.WriteLine("\n*********************\n");
            Console.WriteLine("==> More String Methods\n");
            var moreStringMethods = new MoreStringMethods();
            moreStringMethods.Lesson();

            Console.WriteLine("\n*********************\n");
            Console.WriteLine("==> String Method Challenge\n");
            var stringMethodChallenge = new StringMethodsChallenge();
            stringMethodChallenge.Lesson();

            Console.WriteLine("\n*********************\n");
            Console.WriteLine("==> String Method Challenge 2\n");
            var stringMethodChallenge2 = new StringMethodsChallenge2();
            stringMethodChallenge2.Lesson();

            Console.Read();
        }
    }
}
