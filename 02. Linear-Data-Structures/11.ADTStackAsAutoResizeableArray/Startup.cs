using System;

namespace _11.ADTStackAsAutoResizeableArray
{
    public class Startup
    {
        public static void Main()
        {
            var stack = new StackAsAutoResizebleArray<int>();

            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
        }
    }
}