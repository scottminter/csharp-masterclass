using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V104JaggedArrayChallenge
    {
        public static void Lesson()
        {
            string[][] family = new string[][]
            {
                new string[] { "Jeremy", "Megan", },
                new string[] { "Toffer", "Amanda" },
                new string[] { "Denise", "Dawn" }
            };

            foreach (string[] familyGroup in family)
            {
                foreach (string friend in familyGroup)
                {
                    Console.WriteLine(friend);
                }
            }
        }
    }
}
