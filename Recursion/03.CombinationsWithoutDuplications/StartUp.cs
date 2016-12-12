using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CombinationsWithoutDuplications
{
    class StartUp
    {
        static void Combinations(int n, int k, string text = "")
        {
            if (n == 0)
            {
                Console.WriteLine(text);
                return;
            }

            for (int i = 1; i <= k; i++)
            {
                Combinations(n - 1, k, text + i);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Combinations(k, n);
        }
    }
}
