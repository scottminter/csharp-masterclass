using System;
namespace S9InheritanceAndOOP.V138IEnumerableExample1
{
    public class V138IEnumerableExample1
    {
        public static void Lesson()
        {
            IEnumerable<int> unknownCollection;
            // List<int>
            unknownCollection = GetCollection(1);
            Display(unknownCollection);

            // Queue<int>
            unknownCollection = GetCollection(2);
            Display(unknownCollection);

            // int[]
            unknownCollection = GetCollection(-1);
            Display(unknownCollection);
        }

        public static void Display(IEnumerable<int> collection)
        {
            foreach (int num in collection)
            {
                Console.WriteLine($"{num}");
            }

            Console.WriteLine("------");
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}

