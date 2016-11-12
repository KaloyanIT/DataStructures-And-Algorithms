using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSubsequenceOfEqualNumbers
{
    public class FindLongestSubsequenceOfEqualNumbers
    {
        private static List<int> list = new List<int>()
            {
                3, 4, 5, 6, 6, 6, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9, 9, 9, 9, 9
            };
        public static void Main(string[] args)
        {
            int currentNumber = list[0];
            int nextNumber = 0;
            int currentIndex;
            int sequneceLength;
            int bestSequenceLength = 0;
            int sequenceNumber = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                currentNumber = list[i];
                nextNumber = list[i + 1];
                if (currentNumber == nextNumber)
                {
                    currentIndex = i;
                    sequneceLength = StartSequence(currentIndex, currentNumber);
                    if (sequneceLength > bestSequenceLength)
                    {
                        bestSequenceLength = sequneceLength;
                        sequenceNumber = currentNumber;
                        //sequneceLength = 0;
                    }
                    i += sequneceLength;
                }
            }

            var listOfSequence = new List<int>();

            for (int i = 0; i < bestSequenceLength; i++)
            {
                listOfSequence.Add(sequenceNumber);
            }

            Console.WriteLine(string.Join(", ", listOfSequence));

            Console.WriteLine(bestSequenceLength);
        }

        public static int StartSequence(int startIndex, int currentNumber)
        {
            int sequnece = 1;
            for (int i = startIndex; i < list.Count - 1; i++)
            {
                if (currentNumber != list[i + 1])
                {
                    return sequnece;
                }
                else
                {
                    sequnece++;
                }
            }
            return sequnece;
        }
    }
}
