using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V100NestedForLoops
    {
        public static void Lesson()
        {
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var iStart = 0;
            var jStart = 2;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (i == iStart && j == jStart)
                    {
                        Console.WriteLine($"matrix[{i}][{j}]: {array2D[i, j]} ");
                        jStart--;
                    }
                }

                iStart++;
            }
        }
    }
}
