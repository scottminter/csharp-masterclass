using System;

namespace S7CollectionsInCSharp
{
    public class V115Dictionaries
    {
        public static void Lesson()
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>()
            {
                {"one", "hello"},
                {"two", "world" },
                {"three", "scott" }
            };

            myDictionary.Add("mytestkey", "mytestvalue");

            for (int i = 0; i < myDictionary.Count; i++)
            {
                KeyValuePair<string, string> keyValuePair = myDictionary.ElementAt(i);
                Console.WriteLine($"key: {keyValuePair.Key}, value: {keyValuePair.Value}");
            }

            // updating entries in dictionary
            Console.WriteLine("\n");
            var keyToUpdate = "two";
            if (myDictionary.ContainsKey(keyToUpdate))
            {
                myDictionary[keyToUpdate] = "updated value";
            }

            for (int i = 0; i < myDictionary.Count; i++)
            {
                KeyValuePair<string, string> keyValuePair = myDictionary.ElementAt(i);
                Console.WriteLine($"key: {keyValuePair.Key}, value: {keyValuePair.Value}");
            }

            //deleting entries in dictionary
            Console.WriteLine("\n");
            var keyToDelete = "three";
            if (myDictionary.Remove(keyToDelete))
            {
                Console.WriteLine($"Item {keyToDelete} was removed from Dictionary");
            }

            for (int i = 0; i < myDictionary.Count; i++)
            {
                KeyValuePair<string, string> keyValuePair = myDictionary.ElementAt(i);
                Console.WriteLine($"key: {keyValuePair.Key}, value: {keyValuePair.Value}");
            }
        }

        public static string Convert(int i)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };


            if (dict.ContainsKey(i))
            {
                return dict[i];
            }
            else
            {
                return "nope";
            }
        }
    }
}

