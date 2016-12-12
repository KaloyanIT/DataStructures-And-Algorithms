using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimulationOfNestedLoopsWithRecursion
{
    class Start
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
            Combinations(n, n);
        }
    }
}
