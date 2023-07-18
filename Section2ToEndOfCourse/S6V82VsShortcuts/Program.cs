using System;

namespace S6V82VsShortcuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var otherClass1 = new OtherClass();

            TestFunc(otherClass1);

            // have cursor over method and hit F12 to go to Definition
            // have cursor over method and hit Ctrl + F12 to go to Implementation
            // Ctrl + - will take you back

            otherClass1.AnotherMethod();
            otherClass1.FooBar();
        }

        private static void TestFunc(IOtherClass otherClass)
        {
            otherClass.AnotherMethod();
        }
    }
}
