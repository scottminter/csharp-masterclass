using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V111ArrayLists
    {
        public static void Lesson()
        {
            ArrayList myArrayList = new ArrayList(); // will contain unlimited objects
            //ArrayList myArrayList2 = new ArrayList(100); // will only hold 100 objects

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(25.875);
            myArrayList.Add('#');
            myArrayList.Add(45);
            myArrayList.Add("hello");

            Display(myArrayList);

            // remove element by value
            myArrayList.Remove("hello");
            myArrayList.Remove(45);
            myArrayList.Remove(45);

            Display(myArrayList);

            // remove element by position
            myArrayList.RemoveAt(2);

            Display(myArrayList);
        }

        private static void Display(ArrayList myList)
        {
            foreach (var item in myList)
            {
                Console.WriteLine($"item: {item}");
            }

            Console.WriteLine("\n***\n");
        }
    }
}
