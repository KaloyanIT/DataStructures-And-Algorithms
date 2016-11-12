using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveAllNegativeNumbersFromSequence
{
    public class RemoveAllNegativeNumbers
    {
        public static void Main(string[] args)
        {
            var list = new List<int>()
            {
                2, -5, 8, 9, -1, 2, -3, -2
            };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
