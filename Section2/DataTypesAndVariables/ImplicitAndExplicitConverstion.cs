using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class ImplicitAndExplicitConverstion
    {
        public void Lesson()
        {
            double myDouble = 13.37;
            int myInt;

            // cast double to int
            myInt = (int)myDouble;
            Console.WriteLine($"Explicit cast double {myDouble} to int: {myInt}");

            int num = 12345684;
            long bigNum = num;
            Console.WriteLine($"Implicit cast int {num} to long: {bigNum}");

            // double to string
            double double2 = 432.563434;
            string double2AsString = double2.ToString();
            Console.WriteLine($"Double {double2} to string: {double2AsString}");

            // bool to string
            bool myBool = true;
            string myBoolAsString = myBool.ToString();
            Console.WriteLine($"Bool {myBool} to string: {myBoolAsString}");
        }
    }
}
