using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V96ForeachLoops
    {
        public static void Lesson()
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine($"num at {j}: {nums[j]}");
            }

            Console.WriteLine("\n");
            int index = 0;
            foreach (int num in nums)
            {
                Console.WriteLine($"num at {index}: {nums[index]}");
                index++;
            }
        }
    }
}
