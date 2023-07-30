using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace S7CollectionsInCSharp
{
    public class V98MultiDimensionalArrays
    {
        public static void Lesson()
        {
            // declare 2d array
            string[,] matrix;

            // 3d array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6}, 
                {7, 8, 9}
            };

            Console.WriteLine($"central value is: {array2D[1, 1]}");
            Console.WriteLine($"lower left value: {array2D[2, 0]}");

            // 3D array
            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001" },
                    { "100", "101" }
                },
                {
                    {"100", "101"},
                    {"110", "111"}
                }
            };

            Console.WriteLine($"3D first: {array3D[0, 0, 0]}");
            Console.WriteLine($"3D 6: {array3D[1, 0, 1]}");

        }
    }
}
