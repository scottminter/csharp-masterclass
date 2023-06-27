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
            bool errorOccured = false;
            try
            {
                output = ConvertStringToInt(input);
            }
            catch (FormatException fe)
            {
                errorOccured = true;
                Console.WriteLine($"Format Error: {fe.Message}");
            }
            catch (OverflowException oe)
            {
                errorOccured = true;
                Console.Error.WriteLine($"Overflow Error: {oe.Message}");
            }
            finally
            {
                Console.WriteLine("This is called from Finally");
            }

            if (errorOccured == false)
            {
                Console.WriteLine($"No Error: {output}");
            }
        }

        public static int ConvertStringToInt(string input)
        {
            return int.Parse(input);
        }

        
    }
}
