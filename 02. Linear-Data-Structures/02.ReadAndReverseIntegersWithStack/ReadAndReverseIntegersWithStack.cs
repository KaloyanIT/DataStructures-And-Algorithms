using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadAndReverseIntegersWithStack
{
    public class ReadAndReverseIntegersWithStack
    {
        public static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int currentNumber = 0;

            var stack = new Stack<int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                stack.Push(currentNumber);
            }

            Console.WriteLine("Reversed numbers");

            for (int a = 0; a < numberOfInputs; a++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
