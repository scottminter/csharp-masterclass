using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4MakingDecisions
{
    public class V56IfElseTryParse
    {
        public static void Lesson()
        {
            Console.Write("Enter the temperature: ");
            var inputTemperature = Console.ReadLine();

            if (int.TryParse(inputTemperature, out int temperature))
            {
                Console.WriteLine($"Acceptable Input: {temperature}");
            }
            else
            {
                temperature = 0;
                Console.WriteLine("Invalid input.  Temperature set to 0.");
            }
        }
    }
}
