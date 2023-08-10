using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V103JaggedArraysOrMultiDimensionalArrays
    {
        public static void Lesson()
        {
            /*
             * Use Jagged Arrays when you need nested data structures of varying sizes
             * Use Multidimensional Arrays for mathematics or computations
             */


            Console.WriteLine("Jagged Array");
            // declare and initialize a jagged array
            int[][] triangle = new int[][]
            {
                new int[] { 1 },
                new int[] { 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9, 10 }
            };

            // use nested foreach loop to iterate over jagged array
            foreach (int[] row in triangle)
            {
                foreach (int number in row)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("\nMultidimensional Array");
            // declare and initial a multidimensional array
            int[,] grid = new int[,]
            {
                {1, 2},
                {3, 4}, 
                {5, 6},
                {7, 8},
            };

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i, j]);
                }
            }

        }
    }
}
