using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindAppearanceInSequenceOnEachOfThem
{
    public class FindOccurency
    {
        public static void Main(string[] args)
        {
            int[] numbers = new[] {3, 4, 4, 2, 3, 3, 4, 3, 2};

            var listOfFoundNumbers = new List<int>();
            int currentNumber = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if(listOfFoundNumbers.IndexOf(currentNumber) < 0) 
                {
                    listOfFoundNumbers.Add(currentNumber);
                    for (int a = i; a < numbers.Length; a++)
                    {
                        if (currentNumber == numbers[a])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{currentNumber} - {count} times");

                    count = 0;
                } 
            }
        }
    }
}
