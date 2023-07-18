using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5Loops
{
    public class V72BreakAndContinue
    {
        public static void Lesson()
        {
            // break
            int stopAt = 25;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"i: {i}");
                if (i == stopAt)
                {
                    Console.WriteLine($"We stop at {stopAt}");
                    break;
                }
            }

            // continue
            int skipIt = stopAt;
            for (int i = 0; i < 50; i++)
            {
                if (i == skipIt)
                {
                    Console.WriteLine($"We skip {skipIt}");
                    continue;
                }
                Console.WriteLine($"i: {i}");
            }
        }
    }
}
