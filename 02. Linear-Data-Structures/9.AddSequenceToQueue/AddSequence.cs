using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.AddSequenceToQueue
{
    public class AddSequence
    {
        public static void Main(string[] args)
        {
            var number = 2;// int.Parse(Console.ReadLine());

            var queue = new Queue<int>();
            queue.Enqueue(number);
            int numberToAdd = 1;
            int row = 1;
            int nextSequenceNumberToAdd = number;

            for (int i = 0; i < 50; i++)
            {
                if (row == 1)
                {
                    queue.Enqueue(nextSequenceNumberToAdd + numberToAdd);
                    row++;
                    continue;
                }
                if (row == 2)
                {
                    queue.Enqueue(nextSequenceNumberToAdd * 2 + numberToAdd);
                    row++;
                    continue;
                }
                if (row == 3)
                {
                    queue.Enqueue(nextSequenceNumberToAdd + 2);
                    row = 1;
                    nextSequenceNumberToAdd =  nextSequenceNumberToAdd + numberToAdd;
                    continue;
                }
            }

            Console.WriteLine();
        }
    }
}
