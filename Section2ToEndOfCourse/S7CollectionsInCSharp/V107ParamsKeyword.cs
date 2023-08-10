using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V107ParamsKeyword
    {
        public static void Lesson()
        {
            // params keyword basically allows us to pass as many params as we want

            ParamsMethod("Hi", "there", "how", "are", "you", "there", "how", "are");

            Console.WriteLine("\n\n==> Params 2");

            int a = 5;
            string b = "hello";
            double c = 32.543;
            bool d = true;
            char e = '$';
            ParamsMethod2(a, b, c, d, e);
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write($"{sentence[i]} ");
            }
        }

        public static void ParamsMethod2(params Object[] stuff)
        {
            foreach (Object o in stuff)
            {
                Console.Write($"{o} ");
            }
        }
    }
}
