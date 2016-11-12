using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveAllNumbersOccurOddNumberOfTimes
{
    public class RemoveAllNumbersOccurOddNumberOfTimes
    {
        public static void Main(string[] args)
        {
            var list = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };

            var listOfOddOccurancedNUmbers = new List<int>();

            int timesOfOccurance = 0;
            int currentNumber = 0;

            for (int i = 0; i < list.Count; i++)
            {
                currentNumber = list[i];
                for (int a = 0; a < list.Count; a++)
                {
                    if (list[a] == currentNumber)
                    {
                        timesOfOccurance++;
                    }
                }

                if (timesOfOccurance % 2 == 0)
                {
                    listOfOddOccurancedNUmbers.Add(currentNumber);
                }

                timesOfOccurance = 0;
            }

            Console.WriteLine(string.Join(", ", listOfOddOccurancedNUmbers));
        }
    }
}
