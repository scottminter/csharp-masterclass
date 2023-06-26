using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class IntFloatDouble
    {
        /// <summary>
        /// Material for Section 2.22
        /// Datatypes Int, Float, Double
        /// </summary>
        public void Lesson()
        {
            // Integers
            int num1;
            num1 = 15;
            int num2 = 65;
            int sum = num1 + num2;
            Console.WriteLine($"int sum {num1} + {num2} = {sum}");

            // Doubles
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine($"Double product of {d1} / {d2} = {dDiv}");

            // Floats
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine($"Float production of {f1} / {f2} = {fDiv}");

            // Mix it up
            double dIDiv = d1 / num1;
            Console.WriteLine($"Double d1 / Int num1 = {d1} / {num1} = {dIDiv}");

        }
    }
}
