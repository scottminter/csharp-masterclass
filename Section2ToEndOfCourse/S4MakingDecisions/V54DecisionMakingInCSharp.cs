using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4MakingDecisions
{
    public static class V54DecisionMakingInCSharp
    {
        public static void Lesson()
        {
            Console.Write("Enter the temperature: ");
            var temperature = Console.ReadLine();
            var tempAsInt = Int32.Parse(temperature);

            if (tempAsInt >= 87)
            {
                Console.WriteLine("To to the beach immediately!");
            }
            else if (tempAsInt < 87 && tempAsInt > 75)
            {
                Console.WriteLine("Consider the beach");
            }
            else if (tempAsInt <= 75)
            {
                Console.WriteLine("Fire pit time!!!");
            }
        }
    }
}
