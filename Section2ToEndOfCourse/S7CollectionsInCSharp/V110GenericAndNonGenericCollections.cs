using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7CollectionsInCSharp
{
    public class V110GenericAndNonGenericCollections
    {
        public static void Lesson()
        {
            // Non-Generic Collection
            int num1 = 5;
            float num2 = 3.14f;
            string name = "Scott";

            var myArrayList = new ArrayList();
            myArrayList.Add(num1);
            myArrayList.Add(num2);
            myArrayList.Add(name);

            foreach (var item in myArrayList)
            {
                Console.WriteLine($"item: {item}");
            }

            Console.WriteLine("\n");
            // Generic Collection
            string animal1 = "Cat";
            string animal2 = "Dog";
            string animal3 = "walrus";

            // LISTS!!!!
            List<string> myList = new List<string>();
            myList.Add(animal1);
            myList.Add(animal2);
            myList.Add(animal3);

            foreach (var item in myList)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }
}
