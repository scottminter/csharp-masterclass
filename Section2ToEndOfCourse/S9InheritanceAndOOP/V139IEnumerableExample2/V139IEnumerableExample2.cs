using System;
namespace S9InheritanceAndOOP.V139IEnumerableExample2
{
    public class V139IEnumerableExample2
    {
        public static void Lesson()
        {
            List<int> numberList = new List<int>() { 5, 10, 15 };
            CollectionSum(numberList);

            int[] numberArray = new int[] { 10, 20, 30 };
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (var num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

