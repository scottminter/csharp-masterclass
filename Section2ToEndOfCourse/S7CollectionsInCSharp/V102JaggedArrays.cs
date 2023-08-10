using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V102JaggedArrays
    {
        public static void Lesson()
        {
            /*
             * Jagged arrays are arrays of arrays
             */

            // declared jagged arrays
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 5, 8, 10 };
            jaggedArray[2] = new int[] { 14, 32 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 5, 8, 10 },
                new int[] {14, 32}
            };

            // Console.WriteLine($"ja2[1][2] = {jaggedArray2[1][2]}");

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine($"ja2[{i}][{j}]: {jaggedArray2[i][j]}");
                }
            }
        }
    }
}
