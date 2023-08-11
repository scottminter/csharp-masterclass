using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V109ParamsMinValue
    {
        public static void Lesson()
        {
            var minVal = MinimumValue(23, 342, 2, 534, 6453, 52, 53, 84, 2200, 1, -32);
            Console.WriteLine($"minimum value: {minVal}");
            
        }

        private static int MinimumValue(params int[] numbers)
        {
            int minVal = numbers.Max();

            foreach (int num in numbers)
            {
                if (num < minVal)
                {
                    minVal = num;
                }
            }

            return minVal;
        }
    }
}
