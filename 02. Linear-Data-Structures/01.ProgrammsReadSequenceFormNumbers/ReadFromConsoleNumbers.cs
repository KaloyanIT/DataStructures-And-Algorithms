using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProgrammsReadSequenceFormNumbers
{
    public class ReadFromConsoleNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            int number = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                }
                numbers.Add(number);
            }

            int sum = 0;

            foreach (int currNumber in numbers)
            {
                sum += currNumber;
            }

            int average = sum / numbers.Count;

            Console.WriteLine(sum);
            Console.WriteLine(average);
        }
    }
}
