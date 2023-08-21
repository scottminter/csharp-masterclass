using System;
namespace S9InheritanceAndOOP.V137IEnumeratorAndIEnumerable
{
    public class V137IEnumeratorAndIEnumerable
    {
        /*
         * There are 2 implementations:
         * 1. IEnumerable <T> for generic collections (recommended)
         * 2. IEnumerable for non-generic collections
         */

        /// <summary>
        /// IEnumberable<T> contains a single method that you must implement when implements this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The return IEnumerator<T> provides the ability to iterate through the collection by
        /// exposing a Current property that points at the object we are currently at in the collection.
        /// </summary>

        /// when do you use IEnumerable interface:
        /// - when your collection represents a massive database table and you don't want to load all the entries into memory
        /// When do you NOT use IEnumberable interface:
        /// - when you need results right away
        /// - when you are mutating/editing the objects later one
        /// -- in this case use an Array or List


        public static void Lesson()
        {
            var dogShelter = new DogShelter();

            foreach (var dog in dogShelter)
            {
                //Console.WriteLine($"{dog.Name} is naughty ({dog.IsNaughtyDog}).");
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(4);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

        }
    }
}

