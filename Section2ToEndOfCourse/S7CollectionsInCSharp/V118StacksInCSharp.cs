using System;

namespace S7CollectionsInCSharp
{
    public class V118StacksInCSharp
    {
        public static void Lesson()
        {
            // defining a stack
            Stack<int> stack = new Stack<int>();
            // add element to stack
            stack.Push(1);
            stack.Push(1535);

            // Peek() will return the top of the stack without removing it
            Console.WriteLine($"top of stack: {stack.Peek()}");

            // Remove top item from stack
            if (stack.Count > 0)
            {
                int topOfStack = stack.Pop();
                Console.WriteLine($"prev top of stack: {topOfStack}");
            }

            Console.WriteLine($"top of stack: {stack.Peek()}");
        }

        public static void Challenge()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(423);
            stack.Push(5);
            stack.Push(62);
            stack.Push(108);
            stack.Push(12);
            stack.Push(1056);
            stack.Push(13);

            while (stack.Count > 0)
            {
                var stackItem = stack.Pop();
                Console.WriteLine($"item: {stackItem}");
            }
        }
    }
}

