using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace S3FunctionsMethods
{
    public static class V51Operators
    {
        public static void Lesson()
        {
            // unary operators
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;
            Console.WriteLine($"num3 = {num3}");   

            bool isSunny = false;
            Console.WriteLine($"Is it sunny? {isSunny}");

            // increment operators
            int num4 = 10;

            Console.WriteLine($"num4: {num4}");
            Console.WriteLine($"num4++: {num4++}"); // post increment: increment happens after execution
            Console.WriteLine($"num4: {num4}");
            Console.WriteLine($"++num4: {++num4}"); // pre increment: increment happens before execution
            Console.WriteLine($"num4: {num4}");
        }
    }
}
