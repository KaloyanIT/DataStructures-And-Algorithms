using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadsASequenceAndSortIncreasingly
{
    public class ReadsAndSortIncreasingly
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

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
