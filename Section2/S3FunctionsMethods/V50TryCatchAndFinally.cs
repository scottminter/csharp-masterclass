using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3FunctionsMethods
{
    public static class V50TryCatchAndFinally
    {
        public static void Lesson()
        {
            Console.Write("Input something: ");
            var input = Console.ReadLine();
            int output = 0;

            try
            {
                output = ConvertStringToInt(input);
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Format Error: {fe.Message}");
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine($"Overflow Error: {oe.Message}");
            }
            finally
            {

            }
            
            Console.WriteLine(output);
        }

        public static int ConvertStringToInt(string input)
        {
            return int.Parse(input);
        }

        
    }
}
